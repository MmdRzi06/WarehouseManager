using MyCollections;

namespace WarehouseManager {

	public class CartValidationException: Exception {
		public CartValidationException(string message): base(message) { }
	}

	public class CartItem {
		public readonly IReadOnlyProduct Product;
		public string Name => Product.Name;
		public decimal Price => Product.Price;

		private readonly int _quantity;
		public int Quantity => _quantity;

		public CartItem(IReadOnlyProduct product, int quantity) {
			Product = product;
			_quantity = quantity;
		}
	}

	public static class Cart {
		private static HashMap<IReadOnlyProduct, int> _cart;
		public static int ProductCount => _cart.Count;

		static Cart() {
			_cart = new HashMap<IReadOnlyProduct, int>();
		}

		public delegate void CartChangeHandler();
		public static event CartChangeHandler? CartChanged;

		public static decimal Total {
			get {
				decimal total = 0;
				foreach (MyKeyValuePair<IReadOnlyProduct, int> pair in _cart)
					total += pair.Key.Price * pair.Value;
				return total;
			}
		}

		private static void CheckStock(IReadOnlyProduct product, int neededStock) {
			if (product.StockQuantity < neededStock) throw new CartValidationException("Not enough stock.");
		}

		public static void AddToCart(IReadOnlyProduct product) {
			if (_cart.ContainsKey(product)) {
				CheckStock(product, _cart[product] + 1);
				++_cart[product];
			}
			else {
				CheckStock(product, 1);
				_cart[product] = 1;
			}

			CartChanged?.Invoke();
		}

		public static void RemoveFromCart(IReadOnlyProduct product) {
			if (!_cart.RemoveByKey(product)) throw new InvalidOperationException($"The product is not in the cart. Product ID: {product.ID}.");
			CartChanged?.Invoke();
		}

		public static void IncrementItemQuantity(IReadOnlyProduct product) {
			CheckStock(product, _cart[product] + 1);
			++_cart[product];
			CartChanged?.Invoke();
		}

		public static void DecrementItemQuanity(IReadOnlyProduct product) {
			if (_cart[product] == 1) throw new CartValidationException("Cannot decrement further.");
			--_cart[product];
			CartChanged?.Invoke();
		}

		public static CartItem[] GetCartItems() {
			CartItem[] cartItems = new CartItem[_cart.Count];
			int index = 0;
			foreach (MyKeyValuePair<IReadOnlyProduct, int> pair in _cart) {
				cartItems[index++] = new CartItem(pair.Key, pair.Value);
			}
			return cartItems;
		}

		public static void FinalizeOrder() {
			if (_cart.Empty) throw new InvalidOperationException("Cart is empty.");
			HashMap<IReadOnlyProduct, int> cart = new HashMap<IReadOnlyProduct, int>(_cart);
			_cart.Clear();
			CartChanged?.Invoke();
			Users.AddOrder(cart);
			Products.UpdateStockFromCart(cart);
		}
	}
}

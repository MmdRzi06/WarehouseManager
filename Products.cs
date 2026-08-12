
using MyCollections;
using System;
using System.Linq;

namespace WarehouseManager {

	public static partial class Products {
		private static HashMap<long, Product> _products;

		static Products() {
			_products = new HashMap<long, Product>();
			MyList<IReadOnlyProduct>? readOnlyProducts = Serializer.GetProducts();
			if (readOnlyProducts is not null) {
				foreach (IReadOnlyProduct readOnlyProduct in readOnlyProducts)
					_products.TryAdd(readOnlyProduct.ID, (Product)readOnlyProduct);
			}
		}

		public static event ISerializableObj.Handler? ProductUpdated;

		public delegate void ProductsChangeHandler();
		public static event ProductsChangeHandler? ProductsChanged;

		private static long GenerateUniqueID() {
			long ID = 0;
			do {
				ID = IIdentifiable.GenerateID();
			} while (_products.ContainsKey(ID));
			return ID;
		}

		private static void ValidateValue(string propertyName, int? value) {
			if (value is int && value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		private static void ValidateValue(string propertyName, decimal? value) {
			if (value is decimal && value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		private static void ValidateValue(string propertyName, double? value) {
			if (value is double && value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		private static void ValidateValue(string propertyName, string? value) {
			if (value is string && string.IsNullOrWhiteSpace(value)) throw new ProductValidationException($"\"{propertyName}\" cannot be empty)");
		}

		private static void CheckName(string name) {
			foreach (MyKeyValuePair<long, Product> pair in _products) 
				if (pair.Value.Name == name) throw new ProductValidationException($"A product with the name \"{name}\" already exists");
		}

		private static void RaiseCreatedOrModifiedEvent(Product product) {
			ProductUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, product);
			ProductsChanged?.Invoke();
		}

		private static void AddProductToMap(Product product) {
			if (_products.TryAdd(product.ID, product))
				RaiseCreatedOrModifiedEvent(product);
		}

		public static void RemoveProduct(long ID) {
			Product tempProduct = _products[ID];
			_products.RemoveByKey(ID);
			ProductUpdated?.Invoke(ISerializableObj.Action.Deleted, tempProduct);
			ProductsChanged?.Invoke();
		}

		public static BenchmarkInformation? GetComponentBenchmarkInfo(long ID) {
			ComputerComponent component = (ComputerComponent)_products[ID];
			BenchmarkInformation? info = component.BenchmarkInfo;
			if (info is not null)
				return new BenchmarkInformation(info.Score, info.MaxScore, info.Source);
			else
				return null;
		}

		public static void UpdateStockFromCart(HashMap<IReadOnlyProduct, int> cart) {
			foreach (MyKeyValuePair<IReadOnlyProduct, int> pair in cart) {
				Product product = (Product)pair.Key;
				product.StockQuantity -= pair.Value;
				RaiseCreatedOrModifiedEvent(product);
			}
		}

		public delegate bool ProductFilter(IReadOnlyProduct product);
		private static ProductFilter filter = product => product is Product;

		public static void SetFilterToType<T>() where T: Product {
			filter = product => { 
				if (product is T) {
					if (!string.IsNullOrWhiteSpace(_searchTerm) && !product.Name.ToLower().Contains(_searchTerm.ToLower())) return false;
					return true;
				}
				return false;
			};
			ProductsChanged?.Invoke();
		}

		private static string _searchTerm = string.Empty;

		private static bool _showOutOfStock = false;
		private static bool _showAlmostOutOfStock = false;

		public static bool ShowOutOfStock {
			get => _showOutOfStock;
			set {
				_showOutOfStock = value;
				ProductsChanged?.Invoke();
			}
		}

		public static bool ShowAlmostOutOfStock {
			get => _showAlmostOutOfStock;
			set {
				_showAlmostOutOfStock = value;
				ProductsChanged?.Invoke();
			}
		}

		public static string SearchTerm {
			get => _searchTerm;
			set {
				_searchTerm = value.Trim();
				ProductsChanged?.Invoke();
			}
		}

		public static IReadOnlyProduct[] GetProducts() {
			MyList<IReadOnlyProduct> products = new MyList<IReadOnlyProduct>();
			if (Users.CurrentIsAdmin) {
				foreach (MyKeyValuePair<long, Product> pair in _products) {
					Product product = pair.Value;
					if (filter(product)) {
						if (_showOutOfStock && product.IsOutOfStock) products.Add(product);
						else if (_showAlmostOutOfStock && product.IsAlmostOutOfStock) products.Add(product);
						else if (!_showAlmostOutOfStock && !_showOutOfStock) products.Add(product);
					}
				}
			}
			else if (Users.CurrentIsCustomer) {
				foreach (MyKeyValuePair<long, Product> pair in _products) {
					Product product = pair.Value;
					if (!product.IsOutOfStock && filter(product)) {
						products.Add(product);
					}
				}
			}
			return products.ToArray();
		}
	}
}

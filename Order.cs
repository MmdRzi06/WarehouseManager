using MyCollections;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public readonly struct OrderItem {
		private readonly string _name;
		private readonly decimal _unitPrice;
		private readonly int _quantity;

		public string Name => _name;
		public decimal UnitPrice => _unitPrice;
		public int Quantity => _quantity;

		public OrderItem(IReadOnlyProduct product, int quantity) {
			_name = product.Name;
			_unitPrice = product.Price;
			_quantity = quantity;
		}

		[JsonConstructor]
		private OrderItem(string name, decimal unitPrice, int quantity) {
			_name = name;
			_unitPrice = unitPrice;
			_quantity = quantity;
		}
	}

	public class Order {
		[JsonInclude]
		private readonly MyList<OrderItem> _items;

		private readonly string _ID;
		private readonly decimal _total;

		public string ID => _ID;
		public decimal Total => _total;

		public Order(string ID, HashMap<IReadOnlyProduct, int> cart) {
			_ID = ID;
			_items = new MyList<OrderItem>();
			_total = 0;
			foreach (MyKeyValuePair<IReadOnlyProduct, int> pair in cart) {
				_items.Add(new OrderItem(pair.Key, pair.Value));
				_total += pair.Key.Price * pair.Value;
			}
		}

		public OrderItem[] GetOrderItems() => _items.ToArray();

		[JsonConstructor]
		private Order(MyList<OrderItem> _items, string ID, decimal total) {
			this._items = _items;
			_ID = ID;
			_total = total;
		}
	}
}

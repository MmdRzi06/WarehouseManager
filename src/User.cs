using System.Text.Json.Serialization;
using System.Text.Json;
using MyCollections;

namespace WarehouseManager {
	public abstract class User: IReadOnlyUser {
		private const int PasswordMinLength = 8;

		private long _ID;
		public long ID => _ID;

		private string _username = string.Empty;
		private string _password = string.Empty;

		public string Username {
			get => _username;
			set {
				if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Username cannot be Empty");
				_username = value;
			}
		}

		public string Password {
			get => _password;
			set {
				if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Password cannot be Empty");
				if (value.Length < PasswordMinLength) throw new UserValidationException("Password must contain at least 8 characters");
				_password = value;
			}
		}

		public User(long ID, string username, string password) {
			_ID = ID;
			Username = username;
			Password = password;
		}

		public override int GetHashCode() => _ID.GetHashCode();

	}

	public class Customer: User, IReadOnlyCustomer {
		[JsonInclude]
		private MyList<Order> _orders;

		public Customer(long ID, string username, string password) : base(ID, username, password) {
			_orders = new MyList<Order>();
		}

		[JsonConstructor]
		private Customer(long ID, string username, string password, MyList<Order> _orders): base(ID, username, password) {
			if (_orders == null) throw new JsonException("_orderIDs is invalid");
			this._orders = _orders;
		}
		
		public Order[] GetOrders() => _orders.ToArray();

		public void AddOrder(Order order) => _orders.Add(order);
	}

	public class Admin: User, IReadOnlyAdmin {
		public Admin(long ID, string username, string password) : base(ID, username, password) { }
	}
}

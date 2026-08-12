using MyCollections;

namespace WarehouseManager {

	public class UserValidationException: Exception {
		public UserValidationException(string message): base(message) { }
	}

	public enum UserAction {
		LoggedIn,
		LoggedOut,
		UsernameChanged,
		PasswordChanged
	}

	public static class Users {
		private const long AdminID = 1111111111;
		private static readonly string DefaultAdminUsername = "admin";
		private static readonly string DefaultAdminPassword = "12345678";

		private static readonly Admin _admin;
		private static HashMap<long, Customer> _customers;
		private static User? _currentUser;

		private static bool? _currentIsAdmin;
		public static bool CurrentIsAdmin => _currentIsAdmin ?? false;
		public static bool CurrentIsCustomer => !_currentIsAdmin ?? false;
		public static bool UserIsLoggedIn => _currentUser is not null;

		public static event ISerializableObj.Handler? UsersUpdated;

		public delegate void UserHandler(UserAction userAction, IReadOnlyUser? user);
		public static event UserHandler? UserActed;

		public delegate void OrderAddHandler(Order order);
		public static event OrderAddHandler? OrderAdded;


		static Users() {
			IReadOnlyAdmin? readOnlyAdmin = Serializer.GetAdmin();
			if (readOnlyAdmin is Admin admin) {
				_admin = admin;
			} else {
				_admin = new Admin(AdminID, DefaultAdminUsername, DefaultAdminPassword);
				UsersUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, _admin);
			}

			_customers = new HashMap<long, Customer>();
			MyList<IReadOnlyCustomer>? readOnlyCustomers = Serializer.GetCustomers();
			if (readOnlyCustomers is not null) {
				foreach (IReadOnlyCustomer readOnlyCustomer in readOnlyCustomers)
					_customers.TryAdd(readOnlyCustomer.ID, (Customer)readOnlyCustomer);
			}
		}

		private static bool ContainsUsername(string username) {
			if (_currentUser is not Admin && DefaultAdminUsername == username) return true;
			if (_admin.Username == username) return true;
			foreach (MyKeyValuePair<long, Customer> pair in _customers)
				if (pair.Value.Username == username) return true;
			return false;
		}

		public static void CreateCustomer(string username, string password) {
			if (ContainsUsername(username)) throw new UserValidationException("Username is already taken.");

			long ID = GenerateUniqueID();

			Customer customer = new Customer(ID, username, password);
			_customers.TryAdd(ID, customer);

			UsersUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, customer);
		}

		public static void DeleteCurrentCustomer() {
			if (_currentUser is Customer customer) {
				_customers.RemoveByKey(_currentUser.ID);
				UsersUpdated?.Invoke(ISerializableObj.Action.Deleted, customer);
				LogOut();
				return;
			}

			throw new InvalidOperationException("No customer is logged in.");
		}

		public static void ChangeCurrentUsername(string newUsername) {
			if (_currentUser is null) throw new InvalidOperationException("No user is Logged in.");
			if (_currentUser.Username == newUsername) throw new UserValidationException("New username must be different from your current username.");
			if (ContainsUsername(newUsername)) throw new UserValidationException("Username is already taken.");
			_currentUser.Username = newUsername;
			UsersUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, _currentUser);
			UserActed?.Invoke(UserAction.UsernameChanged, _currentUser);
		}

		public static void ChangeCurrentPassword(string newPassword) {
			if (_currentUser is null) throw new InvalidOperationException("No user is Logged in.");
			_currentUser.Password = newPassword;
			UsersUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, _currentUser);
			UserActed?.Invoke(UserAction.PasswordChanged, _currentUser);
		}

		private static long GenerateUniqueID() {
			long ID = 0;
			do {
				ID = IIdentifiable.GenerateID();
			} while (_customers.ContainsKey(ID) || AdminID == ID);
			return ID;
		}

		public static void LogIn(string username, string password) {
			if (_admin.Username == username && _admin.Password == password) {
				_currentUser = _admin;
				_currentIsAdmin = true;
				UserActed?.Invoke(UserAction.LoggedIn, _admin);
				return;
			}

			foreach (MyKeyValuePair<long, Customer> pair in _customers) {
				Customer customer = pair.Value;
				if (customer.Username == username && customer.Password == password) {
					_currentUser = customer;
					_currentIsAdmin = false;
					UserActed?.Invoke(UserAction.LoggedIn, customer);
					return;
				}
			}

			throw new UserValidationException("Incorrect username or password.");
		}

		public static void LogOut() {
			if (_currentUser is null) throw new InvalidOperationException("No user is logged in.");
			_currentUser = null;
			_currentIsAdmin = null;
			UserActed?.Invoke(UserAction.LoggedOut, null);
		}

		public static Order[] GetOrders() {
			if (_currentUser is Customer customer) return customer.GetOrders();
			throw new InvalidOperationException("No customer is logged in.");
		}

		public static Order[] GetAllOrders() {
			if (_currentUser is not Admin) throw new InvalidOperationException("No admin is logged in.");
			MyList<Order> orders = new MyList<Order>();
			foreach (MyKeyValuePair<long, Customer> pair in _customers)
				foreach (Order order in pair.Value.GetOrders())
					orders.Add(order);
			return orders.ToArray();
		}

		public static void AddOrder(HashMap<IReadOnlyProduct, int> cart) {
			if (_currentUser is Customer customer) {
				string ID = $"{customer.ID}-{customer.GetOrders().Length + 1}";
				Order order = new Order(ID, cart);
				customer.AddOrder(order);
				UsersUpdated?.Invoke(ISerializableObj.Action.CreatedOrModified, customer);
				OrderAdded?.Invoke(order);
			} else {
				throw new InvalidOperationException("No customer is logged in.");
			}
		}

		public static string GetCurrentUsername() {
			if (_currentUser is null) throw new InvalidOperationException("No user is logged in.");
			return _currentUser.Username;
		}
		public static string GetCurrentPassword() {
			if (_currentUser is null) throw new InvalidOperationException("No user is logged in.");
			return _currentUser.Password;
		}

	}
}
using System;

namespace WarehouseManager {

		public interface IReadOnlyUser: ISerializableObj, IIdentifiable {
			public string Username { get; }
			public string Password { get; }
		}

		public interface IReadOnlyCustomer: IReadOnlyUser {
			public Order[] GetOrders();
		}

		public interface IReadOnlyAdmin: IReadOnlyUser { }
}
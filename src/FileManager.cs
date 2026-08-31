namespace WarehouseManager {
	public static class FileManager {

		private static readonly string DatabaseDir = "Database";
		private static readonly string ProductsDir = Path.Combine(DatabaseDir, "Products");
		private static readonly string UsersDir = Path.Combine(DatabaseDir, "Users");
		private static readonly string CustomersDir = Path.Combine(UsersDir, "Customers");
		private static readonly string AdminDir = Path.Combine(UsersDir, "Admin");
		public static readonly string AdminPath = Path.Combine(AdminDir, "admin.json");

		static FileManager() {
			Directory.CreateDirectory(DatabaseDir);
			Directory.CreateDirectory(ProductsDir);
			Directory.CreateDirectory(UsersDir);
			Directory.CreateDirectory(CustomersDir);
			Directory.CreateDirectory(AdminDir);
		}

		public static string DetermineSerializationPath(ISerializableObj obj) {
			return obj switch {
				IReadOnlyProduct product => $"{ProductsDir}\\{product.ID}.json",
				IReadOnlyCustomer customer => $"{CustomersDir}\\{customer.ID}.json",
				IReadOnlyAdmin => AdminPath,
				_ => "Invallid"
			};
		}

		public static string[] GetCustomerPaths() => Directory.GetFiles(CustomersDir);
		public static string[] GetProductPaths() => Directory.GetFiles(ProductsDir);
	}
}

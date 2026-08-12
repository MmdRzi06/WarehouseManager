using System.Text.Json;
using System.Text.Json.Serialization;
using MyCollections;

namespace WarehouseManager {

	[JsonPolymorphic]
	[JsonDerivedType(typeof(ThermalPad), "ThermalPad")]
	[JsonDerivedType(typeof(ThermalPaste), "ThermalPaste")]
	[JsonDerivedType(typeof(RAMKit), "RAMKit")]
	[JsonDerivedType(typeof(CPU), "CPU")]
	[JsonDerivedType(typeof(PSU), "PSU")]
	[JsonDerivedType(typeof(AirCooler), "AirCooler")]
	[JsonDerivedType(typeof(AIOCooler), "AIOCooler")]
	[JsonDerivedType(typeof(Motherboard), "Motherboard")]
	[JsonDerivedType(typeof(CaseFan), "CaseFan")]
	[JsonDerivedType(typeof(Case), "Case")]
	[JsonDerivedType(typeof(NVMeSSD), "NVMeSSD")]
	[JsonDerivedType(typeof(SataSSD), "SataSSD")]
	[JsonDerivedType(typeof(HDD), "HDD")]
	[JsonDerivedType(typeof(GraphicsCard), "GraphicsCard")]
	[JsonDerivedType(typeof(Customer), "Customer")]
	[JsonDerivedType(typeof(Admin), "Admin")]
	public interface ISerializableObj { 
		public enum Action {
			CreatedOrModified,
			Deleted
		}

		public delegate void Handler(Action action, ISerializableObj obj);
	}

	public static class Serializer {
		private static MyList<string> _deserializationErrors = new MyList<string>();

		public static string[] GetDeserializationErrors() {
			string[] temp = _deserializationErrors.ToArray();
			_deserializationErrors.Clear();
			return temp;
		}

		static Serializer() {
			Users.UsersUpdated += ObjChangeHandler;
			Products.ProductUpdated += ObjChangeHandler;
		}

		private static readonly JsonSerializerOptions Options = new JsonSerializerOptions() { WriteIndented = true };
		
		public static void Serialize(ISerializableObj obj) {
			string path = FileManager.DetermineSerializationPath(obj);
			using FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write);
			JsonSerializer.Serialize(fs, obj, Options);
		}

		public static ISerializableObj? Deserialize(string path) {
			if (!Path.Exists(path)) {
				_deserializationErrors.Add($"The file \"{path}\" doesn't exist");
				return null;
			}
			
			try {
				using FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
				ISerializableObj? obj = JsonSerializer.Deserialize<ISerializableObj>(fs);
				return obj;
			} catch (Exception ex) {
				_deserializationErrors.Add($"Error during deserialization of \"{path}\":\n\t{ex.Message}");
			}

			return null;
		}

		public static void DeleteData(ISerializableObj obj) {
			string path = FileManager.DetermineSerializationPath(obj);
			if (Path.Exists(path)) File.Delete(path);
		}

		private static void ObjChangeHandler(ISerializableObj.Action action, ISerializableObj obj) {
			switch (action) {
				case ISerializableObj.Action.CreatedOrModified: Serialize(obj); break;
				case ISerializableObj.Action.Deleted: DeleteData(obj); break;
			}
		}

		public static IReadOnlyAdmin? GetAdmin() {
			ISerializableObj? obj = Deserialize(FileManager.AdminPath);
			if (obj is IReadOnlyAdmin admin) return admin;
			else return null;
		}

		public static MyList<IReadOnlyCustomer>? GetCustomers() {
			string[] customerPaths = FileManager.GetCustomerPaths();
			if (customerPaths.Length != 0) {
				MyList<IReadOnlyCustomer> customers = new MyList<IReadOnlyCustomer>();
				foreach (string customerPath in customerPaths) {
					ISerializableObj? customerObj = Deserialize(customerPath);
					if (customerObj is IReadOnlyCustomer customer) customers.Add(customer);
				}
				return customers;
			}
			return null;
		}

		public static MyList<IReadOnlyProduct>? GetProducts() {
			string[] productPaths = FileManager.GetProductPaths();
			if (productPaths.Length != 0) {
				MyList<IReadOnlyProduct> products = new MyList<IReadOnlyProduct>();
				foreach (string productPath in productPaths) {
					ISerializableObj? productObj = Deserialize(productPath);
					if (productObj is IReadOnlyProduct product) products.Add(product);
				}
				return products;
			}
			return null;
		}
	}
}
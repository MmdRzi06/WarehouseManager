using MyCollections;
using System;

namespace WarehouseManager {

	public interface IReadOnlyProduct: IIdentifiable, ISerializableObj, IEquatable<IReadOnlyProduct> {
		public string Name { get; }
		public string Manufacturer { get; }
		public decimal Price { get; }
		public int StockQuantity { get; }
		public double WeightKg { get; }
		public bool IsAlmostOutOfStock { get; }
		public bool IsOutOfStock { get; }
		public string Category { get; }
		public HashMap<string, string> GetSpecifications();
	}
	
}

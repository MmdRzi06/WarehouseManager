using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {

	public class ProductValidationException: Exception {
		public ProductValidationException(string message): base(message) { }
	}

	public abstract class Product: IReadOnlyProduct, IEquatable<Product> {

		private const int StockLevelWarningThreshhold = 4;

		private readonly long _ID;
		public long ID => _ID;

		private string _name = string.Empty;
		private string _manufacturer = string.Empty;
		private decimal _price;
		private int _stockQuantity;
		private double _weightKg;

		public string Name {
			get => _name;
			set {
				CheckValue(NameStr, value);
				_name = value.Trim();
			}
		}

		public string Manufacturer {
			get => _manufacturer;
			set {
				CheckValue(ManufacturerStr, value);
				_manufacturer = value.Trim(); ;
			}
		}
		public decimal Price {
			get => _price;
			set {
				CheckValue(PriceStr, value);
				_price = value;
			}
		}

		public int StockQuantity {
			get => _stockQuantity;
			set {
				if (value < 0) throw new ProductValidationException($"{StockQuantityStr} cannot be negative.");
				_stockQuantity = value;
			}
		}

		public double WeightKg {
			get => _weightKg;
			set {
				CheckValue(WeightKgStr, value);
				_weightKg = value;
			}
		}

		[JsonIgnore]
		public bool IsAlmostOutOfStock => _stockQuantity < StockLevelWarningThreshhold && _stockQuantity > 0;

		[JsonIgnore]
		public bool IsOutOfStock => _stockQuantity == 0;
		
		public Product(long ID,string name, string manufacturer, decimal price, int stockQuantity, double weightKg) {
			_ID = ID;
			Name = name;
			Manufacturer = manufacturer;
			Price = price;
			StockQuantity = stockQuantity;
			WeightKg = weightKg;
		}

		public const string NameStr = "Name";
		public const string ManufacturerStr = "Manufacturer";
		public const string PriceStr = "Price";
		public const string StockQuantityStr = "Stock Quantity";
		public const string WeightKgStr = "Weight";

		public abstract HashMap<string, string> GetSpecifications();

		[JsonIgnore]
		public abstract string Category { get; }

		public override int GetHashCode() => _ID.GetHashCode();

		public bool Equals(Product? other) {
			if (other is null) return false;
			return this._name == other._name && this._ID == other._ID;
		}

		public bool Equals(IReadOnlyProduct? other) {
			if (other is null) return false;
			return _name == other.Name && _ID == other.ID;
		}

		protected static void CheckValue(string propertyName, int value) {
			if (value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		protected static void CheckValue(string propertyName, decimal value) {
			if (value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		protected static void CheckValue(string propertyName, double value) {
			if (value <= 0) throw new ProductValidationException($"\"{propertyName}\" cannot be less than 1.");
		}
		protected static void CheckValue(string propertyName, string value) {
			if (string.IsNullOrWhiteSpace(value)) throw new ProductValidationException($"\"{propertyName}\" cannot be empty)");
		}
	}

}
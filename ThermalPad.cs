using MyCollections;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class ThermalPad : Product {
		private double _thicknessMm;
		private double _lengthMm;
		private double _widthMm;

		public double ThicknessMm {
			get => _thicknessMm;
			set {
				CheckValue(ThicknessMmStr, value);
				_thicknessMm = value;
			}
		}
			
		public double LengthMm {
			get => _lengthMm;
			set {
				CheckValue(LengthMmStr, value);
				_lengthMm = value;
			}
		}

		public double WidthMm {
			get => _widthMm;
			set {
				CheckValue(WidthMmStr, value);
				_widthMm = value;
			}
		}

		public ThermalPad(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			double thicknessMm, double lengthMm, double widthMm):
			base(ID, name, manufacturer, price, stockQuantity, weightKg)
		{
			ThicknessMm = thicknessMm;
			LengthMm = lengthMm;
			WidthMm = widthMm;
		}

		public const string ThicknessMmStr = "Thickness";
		public const string LengthMmStr = "Length";
		public const string WidthMmStr = "Width";

		public override HashMap<string, string> GetSpecifications() {
			return new HashMap<string, string>() {
				[ThicknessMmStr] = $"{_thicknessMm} mm",
				[LengthMmStr] = $"{_lengthMm} mm",
				[WidthMmStr] = $"{_widthMm} mm",
			};
		}

		[JsonIgnore]
		public override string Category => "Thermal Pad";
	}
}
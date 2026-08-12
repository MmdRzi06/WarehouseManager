using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class ThermalPaste : Product {
		private int _volumeGrams;

		public int VolumeGrams {
			get => _volumeGrams;
			set {
				CheckValue(VolumeGramsStr, value);
				_volumeGrams = value;
			}
		}

		public ThermalPaste(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			int volumeGrams):
			base(ID, name, manufacturer, price, stockQuantity, weightKg)
		{
			VolumeGrams = volumeGrams;
		}

		public const string VolumeGramsStr = "Volume";

		public override HashMap<string, string> GetSpecifications() {
			return new HashMap<string, string>() {
				[VolumeGramsStr] = $"{_volumeGrams} g"
			};
		}

		[JsonIgnore]
		public override string Category => "Thermal Paste";
	}
}
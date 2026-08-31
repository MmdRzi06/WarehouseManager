using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class AirCooler: CPUCooler {
		private int _coolerHeightMm;

		public int CoolerHeightMm {
			get => _coolerHeightMm;
			set {
				CheckValue(CoolerHeightMmStr, value);
				_coolerHeightMm = value;
			}
		}

		public AirCooler(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int minFanSpeedRpm, int maxFanSpeedRpm, int fanSizeMm, double maxNoiseLevelDbA,
			int coolerHeightMm):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA)
		{
			CoolerHeightMm = coolerHeightMm;
		}

		public const string CoolerHeightMmStr = "Cooler Height";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[CoolerHeightMmStr] = $"{_coolerHeightMm} mm";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "Air Cooler";
	}
}

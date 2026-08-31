using MyCollections;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class AIOCooler: CPUCooler {
		private int _radiatorSizeMm;

		public int RadiatorSizeMm {
			get => _radiatorSizeMm;
			set {
				CheckValue(RadiatorSizeMmStr, value);
				_radiatorSizeMm = value;
			}
		}

		public AIOCooler(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int minFanSpeedRpm, int maxFanSpeedRpm, int fanSizeMm, double maxNoiseLevelDbA,
			int radiatorSizeMm):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA)
		{
			RadiatorSizeMm = radiatorSizeMm;
		}

		public const string RadiatorSizeMmStr = "Radiator Size";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[RadiatorSizeMmStr] = $"{_radiatorSizeMm} mm";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "AIO Cooler";
	}
}

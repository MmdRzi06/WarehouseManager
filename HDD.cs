using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class HDD: StorageDevice {
		private int _rpm;

		public int RPM {
			get => _rpm;
			set {
				CheckValue(RPMStr, value);
				_rpm = value;
			}
		}

		public HDD(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs,
			int rpm):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs)
		{
			RPM = rpm;
		}

		public const string RPMStr = "RPM";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[RPMStr] = _rpm.ToString();

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "HDD";
	}
}

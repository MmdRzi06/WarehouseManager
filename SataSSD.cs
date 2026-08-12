using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class SataSSD: StorageDevice {

		public SataSSD(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs)
			{ }

		public override HashMap<string, string> GetSpecifications() {
			return base.GetSpecifications();
		}

		[JsonIgnore]
		public override string Category => "Sata SSD";
	}
}

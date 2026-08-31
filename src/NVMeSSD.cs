using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum PcieGeneration {
		Gen3_0,
		Gen4_0,
		Gen5_0,
		Gen6_0
	}

	public sealed class NVMeSSD: StorageDevice {
		private PcieGeneration _pcieGeneration;

		public PcieGeneration PcieGeneration {
			get => _pcieGeneration;
			set => _pcieGeneration = value;
		}

		public NVMeSSD(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs,
			PcieGeneration pcieGeneration):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs)
		{
			_pcieGeneration = pcieGeneration;
		}

		public const string PcieGenerationStr = "PCIe Generation";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[PcieGenerationStr] = EnumUtils.EnumToDisplayString(_pcieGeneration);

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "NVMe SSD";
	}
}

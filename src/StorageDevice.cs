using MyCollections;
using System;

namespace WarehouseManager {
	public abstract class StorageDevice: ComputerComponent {
		private int _capacityGB;
		private int _readSpeedMBs;
		private int _writeSpeedMBs;

		public int CapacityGB {
			get => _capacityGB;
			set {
				CheckValue(CapacityGBStr, value);
				_capacityGB = value;
			}
		}

		public int ReadSpeedMBs {
			get => _readSpeedMBs;
			set {
				CheckValue(ReadSpeedMBsStr, value);
				_readSpeedMBs = value;
			}
		}

		public int WriteSpeedMBs {
			get => _writeSpeedMBs;
			set {
				CheckValue(WriteSpeedMBsStr, value);
				_writeSpeedMBs = value;
			}
		}

		public StorageDevice(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
			{
				CapacityGB = capacityGB;
				ReadSpeedMBs = readSpeedMBs;
				WriteSpeedMBs = writeSpeedMBs;
			}

		public const string CapacityGBStr = "Capacity";
		public const string ReadSpeedMBsStr = "Read Speed";
		public const string WriteSpeedMBsStr = "Write Speed";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[CapacityGBStr] = $"{_capacityGB} GB";
			specifications[ReadSpeedMBsStr] = $"{_readSpeedMBs} MB/s";
			specifications[WriteSpeedMBsStr] = $"{_writeSpeedMBs} MB/s";

			return specifications;
		}
	}
}
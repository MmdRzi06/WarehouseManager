using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum MemoryType {
		DDR3,
		DDR4,
		DDR5
	}

	public sealed class RAMKit: ComputerComponent {

		private int _moduleCapacityGB;
		private int _moduleCount;
		private MemoryType _memoryType;
		private int _speedMTs;
		private int _casLatency;
		private bool _xmpSupport;
		private bool _expoSupport;

		public int ModuleCapacityGB {
			get => _moduleCapacityGB;
			set {
				CheckValue(ModuleCapacityGBStr, value);
				_moduleCapacityGB = value;
			}
		}

		public int ModuleCount {
			get => _moduleCount;
			set {
				CheckValue(ModuleCountStr, value);
				_moduleCount = value;
			}
		}

		[JsonIgnore]
		public int TotalCapacityGB => _moduleCapacityGB * _moduleCount;

		public MemoryType MemoryType {
			get => _memoryType;
			set => _memoryType = value;
		}

		public int SpeedMTs {
			get => _speedMTs;
			set {
				CheckValue(SpeedMTsStr, value);
				_speedMTs = value;
			}
		}

		public int CasLatency {
			get => _casLatency;
			set {
				CheckValue(CasLatencyStr, value);
				_casLatency = value;
			}
		}

		public bool XmpSupport {
			get => _xmpSupport;
			set => _xmpSupport = value;
		}

		public bool ExpoSupport {
			get => _expoSupport;
			set => _expoSupport = value;
		}

		public RAMKit(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int moduleCapacityGB, int moduleCount, MemoryType memoryType, int speedMTs, int casLatency, bool xmpSupport, bool expoSupport) :
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			ModuleCapacityGB = moduleCapacityGB;
			ModuleCount = moduleCount;
			_memoryType = memoryType;
			SpeedMTs = speedMTs;
			CasLatency = casLatency;
			XmpSupport = xmpSupport;
			ExpoSupport = expoSupport;
		}

		public const string ModuleCapacityGBStr = "Module Capacity";
		public const string ModuleCountStr = "Number Of Modules";
		public const string MemoryTypeStr = "Memory Type";
		public const string SpeedMTsStr = "Speed";
		public const string CasLatencyStr = "CAS Latency";
		public const string XmpSupportStr = "XMP Support";
		public const string ExpoSupportStr = "EXPO Support";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[ModuleCapacityGBStr] = $"{_moduleCapacityGB} GB";
			specifications[ModuleCountStr] = _moduleCount.ToString();
			specifications[MemoryTypeStr] = _memoryType.ToString();
			specifications[SpeedMTsStr] = $"{_speedMTs} MT/s";
			specifications[CasLatencyStr] = $"CL{_casLatency}";
			specifications[XmpSupportStr] = _xmpSupport ? "Supports XMP" : "Doesn't support XMP";
			specifications[ExpoSupportStr] = _expoSupport ? "Supports EXPO" : "Doesn't support EXPO";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "RAM Kit";

	}
}

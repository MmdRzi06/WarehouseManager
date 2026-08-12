using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class CPU: ComputerComponent {

		private string _socket = string.Empty;
		private string _microarchitecture = string.Empty;
		private int _coreCount;
		private int _threadCount;
		private int _baseClockMHz;
		private int _boostClockMHz;
		private int _l3CacheMB;
		private int _memoryChannelCount;
		private int _maxSupportedMemoryGB;
		private int _tdpWatts;
		private bool _supportsOverclocking;

		public string Socket{
			get => _socket;
			set {
				CheckValue(SocketStr, value);
				_socket = value.Trim();
			}
		}

		public string Microarchitecture {
			get => _microarchitecture;
			set {
				CheckValue(MicroarchitectureStr, value);
				_microarchitecture = value.Trim();
			}
		}

		public int CoreCount {
			get => _coreCount;
			set {
				CheckValue(CoreCountStr, value);
				_coreCount = value;
			}
		}
		public int ThreadCount {
			get => _threadCount;
			set {
				CheckValue(ThreadCountStr, value);
				_threadCount = value;
			}
		}

		public int BaseClockMHz {
			get => _baseClockMHz;
			set {
				CheckValue(BaseClockStr, value);
				_baseClockMHz = value;
			}
		}
		public int BoostClockMHz {
			get => _boostClockMHz;
			set {
				CheckValue(BoostClockStr, value);
				_boostClockMHz = value;
			}
		}

		public int L3CacheMB {
			get => _l3CacheMB;
			set {
				CheckValue(L3CacheMBStr, value);
				_l3CacheMB = value;
			}
		}

		public int MemoryChannelCount {
			get => _memoryChannelCount;
			set {
				CheckValue(MemoryChannelCountStr, value);
				_memoryChannelCount = value;
			}
		}

		public int MaxSupportedMemoryGB {
			get => _maxSupportedMemoryGB;
			set {
				CheckValue(MaxSupportedMemoryGBStr, value);
				_maxSupportedMemoryGB = value;
			}
		}

		public int TdpWatts {
			get => _tdpWatts;
			set {
				CheckValue(TdpWattsStr, value);
				_tdpWatts = value;
			}
		}

		public bool SupportsOverclocking {
			get => _supportsOverclocking;
			set => _supportsOverclocking = value;
		}

		public CPU(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string socket, string microarchitecture, int coreCount, int threadCount, int baseClockMHz, int boostClockMHz,
			int l3CacheMB, int tdpWatts, int memoryChannelCount, int maxSupportedMemoryGB, bool supportsOverclocking):
			base (ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			Socket = socket;
			Microarchitecture = microarchitecture;
			CoreCount = coreCount;
			ThreadCount = threadCount;
			BaseClockMHz = baseClockMHz;
			BoostClockMHz = boostClockMHz;
			L3CacheMB = l3CacheMB;
			TdpWatts = tdpWatts;
			MemoryChannelCount = memoryChannelCount;
			MaxSupportedMemoryGB = maxSupportedMemoryGB;
			SupportsOverclocking = supportsOverclocking;
		}

		public const string SocketStr = "Socket Type";
		public const string MicroarchitectureStr = "Microarchitecture";
		public const string CoreCountStr = "Number Of Cores";
		public const string ThreadCountStr = "Number Of Threads";
		public const string BaseClockStr = "Base Clock";
		public const string BoostClockStr = "Boost Clock";
		public const string L3CacheMBStr = "L3 Cache Size";
		public const string TdpWattsStr = "TDP";
		public const string MemoryChannelCountStr = "Number Of Memory Channels";
		public const string MaxSupportedMemoryGBStr = "Maximum Supported Memory Capacity";
		public const string SupportsOverclockingStr = "Overclocking Support";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[SocketStr] = _socket;
			specifications[MicroarchitectureStr] = _microarchitecture;
			specifications[CoreCountStr] = _coreCount.ToString();
			specifications[ThreadCountStr] = _threadCount.ToString();
			specifications[BaseClockStr] = $"{_baseClockMHz} MHz";
			specifications[BoostClockStr] = $"{_boostClockMHz} MHz";
			specifications[L3CacheMBStr] = $"{_l3CacheMB} MB";
			specifications[TdpWattsStr] = $"{TdpWatts} W";
			specifications[MemoryChannelCountStr] = _memoryChannelCount.ToString();
			specifications[MaxSupportedMemoryGBStr] = $"{_maxSupportedMemoryGB} GB";
			specifications[SupportsOverclockingStr] = (_supportsOverclocking) ? "Unlocked for overclocking" : "Locked and cannot be overclocked";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "CPU";

	}
}

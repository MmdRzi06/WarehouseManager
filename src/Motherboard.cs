using MyCollections;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum MotherboardFormFactor {
		MiniITX,
		MicroATX,
		ATX,
		EATX
	}

	public sealed class Motherboard: ComputerComponent {

		private string _socket = string.Empty;
		private string _chipset = string.Empty;
		private MotherboardFormFactor _formFactor;
		private MemoryType _memoryType;
		private int _memorySlotCount;
		private int _maxSupportedMemoryGB;
		private int _pcieSlotCount;
		private int _m2SlotCount;
		private int _sataPortCount;
		private bool _hasWifi;
		private bool _allowsCpuOverclocking;


		public string Socket {
			get => _socket;
			set {
				CheckValue(SocketStr, value);
				_socket = value.Trim();
			}
		}

		public string Chipset {
			get => _chipset;
			set {
				CheckValue(ChipsetStr, value);
				_chipset = value.Trim();
			}
		}

		public MotherboardFormFactor FormFactor {
			get => _formFactor;
			set => _formFactor = value;
		}

		public MemoryType MemoryType {
			get => _memoryType;
			set => _memoryType = value;
		}

		public int MemorySlotCount {
			get => _memorySlotCount;
			set {
				CheckValue(MemorySlotCountStr, value);
				_memorySlotCount = value;
			}
		}

		public int MaxSupportedMemoryGB {
			get => _maxSupportedMemoryGB;
			set {
				CheckValue(MaxSupportedMemoryGBStr, value);
				_maxSupportedMemoryGB = value;
			}
		}

		public int PcieSlotCount {
			get => _pcieSlotCount;
			set {
				CheckValue(PcieSlotCountStr, value);
				_pcieSlotCount = value;
			}
		}

		public int M2SlotCount {
			get => _m2SlotCount;
			set {
				CheckValue(M2SlotCountStr, value);
				_m2SlotCount = value;
			}
		}

		public int SataPortCount {
			get => _sataPortCount;
			set {
				CheckValue(SataPortCountStr, value);
				_sataPortCount = value;
			}
		}

		public bool HasWifi {
			get => _hasWifi;
			set => _hasWifi = value;
		}

		public bool AllowsCpuOverclocking {
			get => _allowsCpuOverclocking;
			set => _allowsCpuOverclocking = value;
		}

		public Motherboard(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string socket, string chipset, MotherboardFormFactor formFactor, MemoryType memoryType, int memorySlotCount, int maxSupportedMemoryGB,
			int pcieSlotCount, int m2SlotCount, int sataPortCount, bool hasWifi, bool allowsCpuOverclocking):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			Socket = socket;
			Chipset = chipset;
			_formFactor = formFactor;
			_memoryType = memoryType;
			MemorySlotCount = memorySlotCount;
			MaxSupportedMemoryGB = maxSupportedMemoryGB;
			PcieSlotCount = pcieSlotCount;
			M2SlotCount = m2SlotCount;
			SataPortCount = sataPortCount;
			HasWifi = hasWifi;
			AllowsCpuOverclocking = allowsCpuOverclocking;
		}

		public const string SocketStr = "Socket Type";
		public const string ChipsetStr = "Chipset";
		public const string FormFactorStr = "Form Factor";
		public const string MemoryTypeStr = "Memory Type";
		public const string MemorySlotCountStr = "Number Of Memory Slots";
		public const string MaxSupportedMemoryGBStr = "Maximum Supported Memory Capacity";
		public const string PcieSlotCountStr = "Number Of PCIe Slots";
		public const string M2SlotCountStr = "Number Of M.2 Slots";
		public const string SataPortCountStr = "Number Of Sata Ports";
		public const string HasWiFiStr = "Wi-Fi";
		public const string CpuOverclockingStr = "CPU Overclocking";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[SocketStr] = _socket;
			specifications[ChipsetStr] = _chipset;
			specifications[FormFactorStr] = EnumUtils.EnumToDisplayString(_formFactor);
			specifications[MemoryTypeStr] = _memoryType.ToString();
			specifications[MemorySlotCountStr] = _memorySlotCount.ToString();
			specifications[MaxSupportedMemoryGBStr] = $"{_maxSupportedMemoryGB} GB";
			specifications[PcieSlotCountStr] = _pcieSlotCount.ToString();
			specifications[M2SlotCountStr] = _m2SlotCount.ToString();
			specifications[SataPortCountStr] =_sataPortCount.ToString();
			specifications[HasWiFiStr] = (_hasWifi) ? "Includes Wi-Fi" : "Doesn't include Wi-Fi";
			specifications[CpuOverclockingStr] = (_allowsCpuOverclocking) ? "Allows for CPU overclocking" : "Doesn't allow for CPU overclocking";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "Motherboard";
	}
}
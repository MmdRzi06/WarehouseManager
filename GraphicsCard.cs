using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum GpuMemoryType {
		GDDR6,
		GDDR6X,
		GDDR7,
	}

	public sealed class GraphicsCard: ComputerComponent {

		private string _gpuManufacturer = string.Empty;
		private string _chipModel = string.Empty;
		private string _architecture = string.Empty;
		private int _coreCount;
		private int _baseClockMHz;
		private int _boostClockMHz;
		private int _memoryCapacityGB;
		private GpuMemoryType _memoryType;
		private PcieGeneration _pcieGeneration;
		private int _pcieLaneCount;
		private int _tdpWatts;
		private int _displayPortCount;
		private int _hdmiPortCount;

		public string GpuManufacturer {
			get => _gpuManufacturer;
			set {
				CheckValue(GpuManufacturerStr, value);
				_gpuManufacturer = value.Trim();
			}
		}

		public string ChipModel {
			get => _chipModel;
			set {
				CheckValue(ChipModelStr, value);
				_chipModel = value.Trim();
			}
		}

		public string Architecture {
			get => _architecture;
			set {
				CheckValue(ArchitectureStr, value);
				_architecture = value.Trim();
			}
		}

		public int CoreCount {
			get => _coreCount;
			set {
				CheckValue(CoreCountStr, value);
				_coreCount = value;
			}
		}

		public int BaseClockMHz {
			get => _baseClockMHz;
			set {
				CheckValue(BaseClockMHzStr, value);
				_baseClockMHz = value;
			}
		}

		public int BoostClockMHz {
			get => _boostClockMHz;
			set {
				CheckValue(BoostClockMHzStr, value);
				_boostClockMHz = value;
			}
		}

		public int MemoryCapacityGB {
			get => _memoryCapacityGB;
			set {
				CheckValue(MemoryCapacityGBStr, value);
				_memoryCapacityGB = value;
			}
		}

		public GpuMemoryType MemoryType {
			get => _memoryType;
			set => _memoryType = value;
		}

		public PcieGeneration PcieGeneration {
			get => _pcieGeneration;
			set => _pcieGeneration = value;
		}

		public int PcieLaneCount {
			get => _pcieLaneCount;
			set {
				CheckValue(PcieLaneCountStr, value);
				_pcieLaneCount = value;
			}
		}

		public int TdpWatts {
			get => _tdpWatts;
			set {
				CheckValue(TdpWattsStr, value);
				_tdpWatts = value;
			}
		}

		public int DisplayPortCount {
			get => _displayPortCount;
			set {
				CheckValue(DisplayPortCountStr, value);
				_displayPortCount = value;
			}
		}

		public int HdmiPortCount {
			get => _hdmiPortCount;
			set {
				CheckValue(HdmiPortCountStr, value);
				_hdmiPortCount = value;
			}
		}

		public GraphicsCard(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string gpuManufacturer, string chipModel, string architecture, int coreCount, int baseClockMHz, int boostClockMHz,
			int memoryCapacityGB, GpuMemoryType memoryType, PcieGeneration pcieGeneration, int pcieLaneCount, int tdpWatts, int displayPortCount, int hdmiPortCount):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			GpuManufacturer = gpuManufacturer;
			ChipModel = chipModel;
			Architecture = architecture;
			CoreCount = coreCount;
			BaseClockMHz = baseClockMHz;
			BoostClockMHz = boostClockMHz;
			MemoryCapacityGB = memoryCapacityGB;
			_memoryType = memoryType;
			_pcieGeneration = pcieGeneration;
			PcieLaneCount = pcieLaneCount;
			TdpWatts = tdpWatts;
			DisplayPortCount = displayPortCount;
			HdmiPortCount = hdmiPortCount;
		}

		public const string GpuManufacturerStr = "GPU Manufacturer";
		public const string ChipModelStr = "Chip Model";
		public const string ArchitectureStr = "Architecture";
		public const string CoreCountStr = "Number Of Cores";
		public const string BaseClockMHzStr = "Base Clock";
		public const string BoostClockMHzStr = "Boost Clock";
		public const string MemoryCapacityGBStr = "Memory Capacity";
		public const string MemoryTypeStr = "Memory Type";
		public const string PcieGenerationStr = "PCIe Generation";
		public const string PcieLaneCountStr = "Number Of PCIe Lanes";
		public const string TdpWattsStr = "TDP";
		public const string DisplayPortCountStr = "Number Of DisplayPorts";
		public const string HdmiPortCountStr = "Number Of HDMI Ports";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[GpuManufacturerStr] = _gpuManufacturer;
			specifications[ChipModelStr] = _chipModel;
			specifications[ArchitectureStr] = _architecture;
			specifications[CoreCountStr] = _coreCount.ToString();
			specifications[BaseClockMHzStr] = $"{_baseClockMHz} MHz";
			specifications[BoostClockMHzStr] = $"{_boostClockMHz} MHz";
			specifications[MemoryCapacityGBStr] = $"{_memoryCapacityGB} MHz";
			specifications[MemoryTypeStr] = _memoryType.ToString();
			specifications[PcieGenerationStr] = EnumUtils.EnumToDisplayString(_pcieGeneration);
			specifications[PcieLaneCountStr] = _pcieLaneCount.ToString();
			specifications[TdpWattsStr] = $"{_tdpWatts} W";
			specifications[DisplayPortCountStr] = _displayPortCount.ToString();
			specifications[HdmiPortCountStr] = _hdmiPortCount.ToString();

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "Graphics Card";
	}
}
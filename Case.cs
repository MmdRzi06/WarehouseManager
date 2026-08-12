using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum CaseFormFactor {
		MiniITX,
		MiniTower,
		MidTower,
		FullTower
	}

	public sealed class Case: ComputerComponent {
		private CaseFormFactor _formFactor;
		private MotherboardFormFactor _largestSupportedMotherboardFormFactor;
		private int _maxGpuLengthMm;
		private int _maxCpuCoolerHeightMm;

		public CaseFormFactor FormFactor {
			get => _formFactor;
			set => _formFactor = value;
		}

		public MotherboardFormFactor LargestSupportedMotherboardFormFactor {
			get => _largestSupportedMotherboardFormFactor;
			set => _largestSupportedMotherboardFormFactor = value;
		}

		public int MaxGpuLengthMm {
			get => _maxGpuLengthMm;
			set {
				CheckValue(MaxGpuLengthMmStr, value);
				_maxGpuLengthMm = value;
			}
		}

		public int MaxCpuCoolerHeightMm {
			get => _maxCpuCoolerHeightMm;
			set {
				CheckValue(MaxCpuCoolerHeightMmStr, value);
				_maxCpuCoolerHeightMm = value;
			}
		}

		public Case(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			CaseFormFactor formFactor, MotherboardFormFactor largestSupportedMotherboardFormFactor, int maxGpuLengthMm, int maxCpuCoolerHeightMm):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			_formFactor = formFactor;
			_largestSupportedMotherboardFormFactor = largestSupportedMotherboardFormFactor;
			MaxGpuLengthMm = maxGpuLengthMm;
			MaxCpuCoolerHeightMm = maxCpuCoolerHeightMm;
		}

		public const string FormFactorStr = "Form Factor";
		public const string LargestSupportedMotherboardFormFactorStr = "Largest Supported Motherboard Form Factor";
		public const string MaxGpuLengthMmStr = "Maximum GPU Length";
		public const string MaxCpuCoolerHeightMmStr = "Maximum CPU Cooler Height";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[FormFactorStr] = EnumUtils.EnumToDisplayString(_formFactor);
			specifications[LargestSupportedMotherboardFormFactorStr] = EnumUtils.EnumToDisplayString(_largestSupportedMotherboardFormFactor);
			specifications[MaxGpuLengthMmStr] = $"{_maxGpuLengthMm} mm";
			specifications[MaxCpuCoolerHeightMmStr] = $"{_maxCpuCoolerHeightMm} mm";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "Case";

	}
}

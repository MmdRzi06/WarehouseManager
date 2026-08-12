using MyCollections;
using System;
using System.Runtime.CompilerServices;

namespace WarehouseManager {
	public abstract class CPUCooler: ComputerComponent {
		private int _minFanSpeedRpm;
		private int _maxFanSpeedRpm;
		private int _fanSizeMm;
		private double _maxNoiseLevelDbA;

		public int MinFanSpeedRpm {
			get => _minFanSpeedRpm;
			set {
				CheckValue(MinFanSpeedRpmStr, value);
				_minFanSpeedRpm = value;
			}
		}

		public int MaxFanSpeedRpm {
			get => _maxFanSpeedRpm;
			set {
				CheckValue(MaxFanSpeedRpmStr, value);
				_maxFanSpeedRpm = value;
			}
		}

		public int FanSizeMm {
			get => _fanSizeMm;
			set {
				CheckValue(FanSizeMmStr, value);
				_fanSizeMm = value;
			}
		}

		public double MaxNoiseLevelDbA {
			get => _maxNoiseLevelDbA;
			set {
				CheckValue(MaxNoiseLevelDbAStr, value);
				_maxNoiseLevelDbA = value;
			}
		}

		public CPUCooler(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo, 
			int minFanSpeedRpm, int maxFanSpeedRpm, int fanSizeMm, double maxNoiseLevelDbA) :
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
			{
				MinFanSpeedRpm = minFanSpeedRpm;
				MaxFanSpeedRpm = maxFanSpeedRpm;
				FanSizeMm = fanSizeMm;
				MaxNoiseLevelDbA = maxNoiseLevelDbA;
			}

		public const string MinFanSpeedRpmStr = "Minimum Fan Speed";
		public const string MaxFanSpeedRpmStr = "Maximum Fan Speed";
		public const string FanSpeedRpmStr = "Fan Speed";
		public const string FanSizeMmStr = "Fan Size";
		public const string MaxNoiseLevelDbAStr = "Max Noise Level";

		public override HashMap<string, string> GetSpecifications() {

			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[FanSpeedRpmStr] = $"{_minFanSpeedRpm}-{_maxFanSpeedRpm} RPM";
			specifications[MaxNoiseLevelDbAStr] = $"{_maxNoiseLevelDbA} dBA";

			return specifications;
		}
	}
}

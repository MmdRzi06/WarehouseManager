using MyCollections;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public sealed class CaseFan: ComputerComponent {
		private int _sizeMm;
		private int _maxFanSpeedRpm;
		private int _minFanSpeedRpm;
		private bool _pwmSupport;

		public int SizeMm {
			get => _sizeMm;
			set {
				CheckValue(SizeMmStr, value);
				_sizeMm = value;
			}
		}

		public int MaxFanSpeedRpm {
			get => _maxFanSpeedRpm;
			set {
				CheckValue(MaxFanSpeedRpmStr, value);
				_maxFanSpeedRpm = value;
			}
		}

		public int MinFanSpeedRpm {
			get => _minFanSpeedRpm;
			set {
				CheckValue(MinFanSpeedRpmStr, value);
				_minFanSpeedRpm = value;
			}
		}

		public bool PwmSupport {
			get => _pwmSupport;
			set => _pwmSupport = value;
		}

		public CaseFan(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int sizeMm, int maxFanSpeedRpm, int minFanSpeedRpm, bool pwmSupport):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			SizeMm = sizeMm;
			MaxFanSpeedRpm = maxFanSpeedRpm;
			MinFanSpeedRpm = minFanSpeedRpm;
			_pwmSupport = pwmSupport;
		}

		public const string SizeMmStr = "Size";
		public const string MaxFanSpeedRpmStr = "Maximum Fan Speed";
		public const string MinFanSpeedRpmStr = "Minimum Fan Speed";
		public const string SpeedRpmStr = "Speed";
		public const string PwmSupportStr = "PWM Support";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[SizeMmStr] = $"{_sizeMm} mm";
			specifications[SpeedRpmStr] = $"{_minFanSpeedRpm}-{_maxFanSpeedRpm} RPM";
			specifications[PwmSupportStr] = _pwmSupport ? "Supports PWM" : "Doesn't support PWM";

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "Case Fan";
	}
}

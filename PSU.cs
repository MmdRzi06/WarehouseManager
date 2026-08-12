using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {
	public enum PSUEfficiencyRating {
		Plus80,
		Plus80Bronze,
		Plus80Silver,
		Plus80Gold,
		Plus80Platinum,
		Plus80Titanium,
	}

	public enum PSUModularity {
		None,
		Semi,
		Full
	}

	public enum PSUFormFactor {
		SFX,
		ATX,
		SFX_L
	}

	public sealed class PSU: ComputerComponent {
		private int _wattage;
		private PSUEfficiencyRating _efficiencyRating;
		private PSUModularity _modularity;
		private PSUFormFactor _formFactor;

		public int Wattage {
			get => _wattage;
			set {
				CheckValue(WattageStr, value);
				_wattage = value;
			}
		}

		public PSUEfficiencyRating EfficiencyRating {
			get => _efficiencyRating;
			set => _efficiencyRating = value;
		}

		public PSUModularity Modularity {
			get => _modularity;
			set => _modularity = value;
		}

		public PSUFormFactor FormFactor {
			get => _formFactor;
			set => _formFactor = value;
		}

		public PSU(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int wattage, PSUEfficiencyRating efficiencyRating, PSUModularity modularity, PSUFormFactor formFactor):
			base(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo)
		{
			Wattage = wattage;
			_efficiencyRating = efficiencyRating;
			_modularity = modularity;
			_formFactor = formFactor;
		}

		public const string WattageStr = "Wattage";
		public const string EfficiencyRatingStr = "Efficiency Rating";
		public const string ModularityStr = "Modularity";
		public const string FormFactorStr = "Form Factor";

		public override HashMap<string, string> GetSpecifications() {
			HashMap<string, string> specifications = base.GetSpecifications();

			specifications[WattageStr] = $"{_wattage} W";
			specifications[EfficiencyRatingStr] = EnumUtils.EnumToDisplayString(_efficiencyRating);
			specifications[ModularityStr] = EnumUtils.EnumToDisplayString(_modularity);
			specifications[FormFactorStr] = EnumUtils.EnumToDisplayString(_formFactor);

			return specifications;
		}

		[JsonIgnore]
		public override string Category => "PSU";
	}
}

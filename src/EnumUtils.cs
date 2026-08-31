
namespace WarehouseManager {

	public static class EnumUtils {

		public static string EnumToDisplayString(Enum @enum) {
			return @enum switch {
				PcieGeneration.Gen3_0 => "PCIe 3.0",
				PcieGeneration.Gen4_0 => "PCIe 4.0",
				PcieGeneration.Gen5_0 => "PCIe 5.0",
				PcieGeneration.Gen6_0 => "PCIe 6.0",
				MotherboardFormFactor.EATX => "E-ATX",
				MotherboardFormFactor.ATX or PSUFormFactor.ATX => "ATX",
				MotherboardFormFactor.MicroATX => "Micro-ATX",
				MotherboardFormFactor.MiniITX or CaseFormFactor.MiniITX => "Mini-ITX",
				PSUEfficiencyRating.Plus80 => "80+",
				PSUEfficiencyRating.Plus80Bronze => "80+ Bronze",
				PSUEfficiencyRating.Plus80Silver => "80+ Silver",
				PSUEfficiencyRating.Plus80Gold => "80+ Gold",
				PSUEfficiencyRating.Plus80Platinum => "80+ Platinum",
				PSUEfficiencyRating.Plus80Titanium => "80+ Titanium",
				PSUModularity.Full => "Fully Modular",
				PSUModularity.Semi => "Semi-Modular",
				PSUModularity.None => "Non-Modular",
				PSUFormFactor.SFX => "SFX",
				PSUFormFactor.SFX_L => "SFX-L",
				CaseFormFactor.MiniTower => "Mini Tower",
				CaseFormFactor.MidTower => "Mid Tower",
				CaseFormFactor.FullTower => "Full Tower",
				_ => throw new ArgumentException($"Invalid enum. Value: {@enum}")
			};
		}

		public static Enum DisplayStringToEnum(string str) {
			return str switch {
				"PCIe 3.0" => PcieGeneration.Gen3_0,
				"PCIe 4.0" => PcieGeneration.Gen4_0,
				"PCIe 5.0" => PcieGeneration.Gen5_0,
				"PCIe 6.0" => PcieGeneration.Gen6_0,
				"E-ATX" => MotherboardFormFactor.EATX,
				"Micro-ATX" => MotherboardFormFactor.MicroATX,
				"80+" => PSUEfficiencyRating.Plus80,
				"80+ Bronze" => PSUEfficiencyRating.Plus80Bronze,
				"80+ Silver" => PSUEfficiencyRating.Plus80Silver,
				"80+ Gold" => PSUEfficiencyRating.Plus80Gold,
				"80+ Platinum" => PSUEfficiencyRating.Plus80Platinum,
				"80+ Titanium" => PSUEfficiencyRating.Plus80Titanium,
				"Fully Modular" => PSUModularity.Full,
				"Semi-Modular" => PSUModularity.Semi,
				"Non-Modular" => PSUModularity.None,
				"SFX" => PSUFormFactor.SFX,
				"SFX-L" => PSUFormFactor.SFX_L,
				"Mini Tower" => CaseFormFactor.MiniTower,
				"Mid Tower" => CaseFormFactor.MidTower,
				"Full Tower" => CaseFormFactor.FullTower,
				"GDDR6" => GpuMemoryType.GDDR6,
				"GDDR6X" => GpuMemoryType.GDDR6X,
				"GDDR7" => GpuMemoryType.GDDR7,
				"DDR3" => MemoryType.DDR3,
				"DDR4" => MemoryType.DDR4,
				"DDR5" => MemoryType.DDR5,
				_ => throw new ArgumentException($"Invalid string. Value: {str}")
			};
		}
	}
}
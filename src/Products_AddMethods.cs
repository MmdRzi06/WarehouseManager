
namespace WarehouseManager {
	public static partial class Products {
		public static void AddThermalPad(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			double thicknessMm, double lengthMm, double widthMm)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			ThermalPad tp = new ThermalPad(ID, name, manufacturer, price, stockQuantity, weightKg, thicknessMm, lengthMm, widthMm);
			AddProductToMap(tp);
		}

		public static void AddThermalPaste(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			int volumeGrams)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			ThermalPaste tp = new ThermalPaste(ID, name, manufacturer, price, stockQuantity, weightKg, volumeGrams);
			AddProductToMap(tp);
		}

		public static void AddNVMeSSD(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs,
			PcieGeneration pcieGeneration)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			NVMeSSD ssd = new NVMeSSD(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs, pcieGeneration);
			AddProductToMap(ssd);
		}

		public static void AddSataSSD(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			SataSSD ssd = new SataSSD(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs);
			AddProductToMap(ssd);
		}

		public static void AddHDD(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int capacityGB, int readSpeedMBs, int writeSpeedMBs,
			int rpm)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			HDD hdd = new HDD(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, capacityGB, readSpeedMBs, writeSpeedMBs, rpm);
			AddProductToMap(hdd);
		}

		public static void AddAIOCooler(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int minFanSpeedRpm, int maxFanSpeedRpm, int fanSizeMm, double maxNoiseLevelDbA,
			int radiatorSizeMm)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			AIOCooler cooler = new AIOCooler(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, minFanSpeedRpm, maxFanSpeedRpm,
				fanSizeMm, maxNoiseLevelDbA, radiatorSizeMm);
			AddProductToMap(cooler);
		}

		public static void AddAirCooler(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int minFanSpeedRpm, int maxFanSpeedRpm, int fanSizeMm, double maxNoiseLevelDbA,
			int coolerHeightMm)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			AirCooler cooler = new AirCooler(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, minFanSpeedRpm, maxFanSpeedRpm,
				fanSizeMm, maxNoiseLevelDbA, coolerHeightMm);
			AddProductToMap(cooler);
		}

		public static void AddMotherboard(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string socket, string chipset, MotherboardFormFactor formFactor, MemoryType memoryType, int memorySlotCount, int maxSupportedMemoryGB,
			int pcieSlotCount, int m2SlotCount, int sataPortCount, bool hasWifi, bool allowsCpuOverclocking)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			Motherboard mb = new Motherboard(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, socket, chipset, formFactor, memoryType,
				memorySlotCount, maxSupportedMemoryGB, pcieSlotCount, m2SlotCount, sataPortCount, hasWifi, allowsCpuOverclocking);
			AddProductToMap(mb);
		}

		public static void AddCase(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			CaseFormFactor formFactor, MotherboardFormFactor largestSupportedMotherboardFormFactor, int maxGpuLengthMm, int maxCpuCoolerHeightMm)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			Case c = new Case(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, formFactor, largestSupportedMotherboardFormFactor,
				maxGpuLengthMm, maxCpuCoolerHeightMm);
			AddProductToMap(c);
		}

		public static void AddPSU(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int wattage, PSUEfficiencyRating efficiencyRating, PSUModularity modularity, PSUFormFactor formFactor)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			PSU psu = new PSU(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, wattage, efficiencyRating, modularity, formFactor);
			AddProductToMap(psu);
		}

		public static void AddCaseFan(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int sizeMm, int maxFanSpeedRpm, int minFanSpeedRpm, bool pwmSupport)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			CaseFan cf = new CaseFan(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, sizeMm, maxFanSpeedRpm, minFanSpeedRpm, pwmSupport);
			AddProductToMap(cf);
		}

		public static void AddGraphicsCard(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string gpuManufacturer, string chipModel, string architecture, int coreCount, int baseClockMHz, int boostClockMHz,
			int memoryCapacityGB, GpuMemoryType memoryType, PcieGeneration pcieGeneration, int pcieLaneCount, int tdpWatts, int displayPortCount, int hdmiPortCount)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			GraphicsCard gpu = new GraphicsCard(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, gpuManufacturer,
				chipModel, architecture, coreCount, baseClockMHz, boostClockMHz, memoryCapacityGB, memoryType, pcieGeneration, pcieLaneCount,
				tdpWatts, displayPortCount, hdmiPortCount);
			AddProductToMap(gpu);
		}

		public static void AddCPU(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			string socket, string microarchitecture, int coreCount, int threadCount, int baseClockMHz, int boostClockMHz,
			int l3CacheMB, int tdpWatts, int memoryChannelCount, int maxSupportedMemoryGB, bool supportsOverclocking)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			CPU cpu = new CPU(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, socket, microarchitecture, coreCount,
				threadCount, baseClockMHz, boostClockMHz, l3CacheMB, tdpWatts, memoryChannelCount, maxSupportedMemoryGB, supportsOverclocking);
			AddProductToMap(cpu);
		}

		public static void AddRAMKit(string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo,
			int moduleCapacityGB, int moduleCount, MemoryType memoryTypem, int speedMTs, int casLatency, bool xmpSupport, bool expoSupport)
		{
			CheckName(name);
			long ID = GenerateUniqueID();
			RAMKit ram = new RAMKit(ID, name, manufacturer, price, stockQuantity, weightKg, benchmarkInfo, moduleCapacityGB, moduleCount,
				memoryTypem, speedMTs, casLatency, xmpSupport, expoSupport);
			AddProductToMap(ram);
		}
	}
}

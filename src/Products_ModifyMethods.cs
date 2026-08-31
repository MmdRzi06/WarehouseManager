namespace WarehouseManager {
	public static partial class Products {
		public static void ModifyProduct(long ID, string? name, string? manufacturer, decimal? price, int? stockQuantity, double? weightKg) {
			Product product = _products[ID];

			ValidateValue(Product.NameStr, name);
			ValidateValue(Product.ManufacturerStr, manufacturer);
			ValidateValue(Product.PriceStr, price);
			ValidateValue(Product.WeightKgStr, weightKg);
			if (stockQuantity < 0) throw new ProductValidationException($"{Product.StockQuantityStr} cannot be negative.");

			if (name is string n) {
				CheckName(n);
				product.Name = n;
			}
			if (manufacturer is string m) product.Manufacturer = m;
			if (price is decimal p) product.Price = p;
			if (stockQuantity is int sq) product.StockQuantity = sq;
			if (weightKg is double w) product.WeightKg = w;

			RaiseCreatedOrModifiedEvent(product);
		}

		public static void ModifyComputerComponent(long ID, BenchmarkInformation? benchmarkInfo) {
			ComputerComponent component = (ComputerComponent)_products[ID];
			component.BenchmarkInfo = benchmarkInfo;
			RaiseCreatedOrModifiedEvent(component);
		}

		public static void ModifyThermalPad(long ID, double? thicknessMm, double? lengthMm, double? widthMm) {
			ThermalPad tp = (ThermalPad)_products[ID];

			ValidateValue(ThermalPad.ThicknessMmStr, thicknessMm);
			ValidateValue(ThermalPad.LengthMmStr, lengthMm);
			ValidateValue(ThermalPad.WidthMmStr, widthMm);

			if (thicknessMm is double t) tp.ThicknessMm = t;
			if (lengthMm is double l) tp.LengthMm = l;
			if (widthMm is double w) tp.WidthMm = w;

			RaiseCreatedOrModifiedEvent(tp);
		}

		public static void ModifyThermalPaste(long ID, int? volumeGrams) {
			ThermalPaste tp = (ThermalPaste)_products[ID];

			ValidateValue(ThermalPaste.VolumeGramsStr, volumeGrams);

			if (volumeGrams is int v) tp.VolumeGrams = v;

			RaiseCreatedOrModifiedEvent(tp);
		}

		private static void ModifyStorageDevice(StorageDevice device, int? capacityGB, int? readSpeedMBs, int? writeSpeedMBs) {
			ValidateValue(StorageDevice.CapacityGBStr, capacityGB);
			ValidateValue(StorageDevice.ReadSpeedMBsStr, readSpeedMBs);
			ValidateValue(StorageDevice.WriteSpeedMBsStr, writeSpeedMBs);

			if (capacityGB is int c) device.CapacityGB = c;
			if (readSpeedMBs is int rs) device.ReadSpeedMBs = rs;
			if (writeSpeedMBs is int ws) device.WriteSpeedMBs = ws;
		}

		public static void ModifyNVMeSSD(long ID, int? capacityGB, int? readSpeedMBs, int? writeSpeedMBs,
			PcieGeneration? pcieGeneration) {
			NVMeSSD ssd = (NVMeSSD)_products[ID];

			ModifyStorageDevice(ssd, capacityGB, readSpeedMBs, writeSpeedMBs);
			if (pcieGeneration is PcieGeneration pg) ssd.PcieGeneration = pg;

			RaiseCreatedOrModifiedEvent(ssd);
		}

		public static void ModifySataSSD(long ID, int? capacityGB, int? readSpeedMBs, int? writeSpeedMBs) {
			SataSSD ssd = (SataSSD)_products[ID];

			ModifyStorageDevice(ssd, capacityGB, readSpeedMBs, writeSpeedMBs);

			RaiseCreatedOrModifiedEvent(ssd);
		}

		public static void ModifyHDD(long ID, int? capacityGB, int? readSpeedMBs, int? writeSpeedMBs, int? rpm) {
			HDD hdd = (HDD)_products[ID];

			ModifyStorageDevice(hdd, capacityGB, readSpeedMBs, writeSpeedMBs);

			ValidateValue(HDD.RPMStr, rpm);

			if (rpm is int r_) hdd.RPM = r_;

			RaiseCreatedOrModifiedEvent(hdd);
		}

		private static void ModifyCPUCooler(CPUCooler cooler, int? minFanSpeedRpm, int? maxFanSpeedRpm, int? fanSizeMm, double? maxNoiseLevelDbA) {
			ValidateValue(CPUCooler.MinFanSpeedRpmStr, minFanSpeedRpm);
			ValidateValue(CPUCooler.MaxFanSpeedRpmStr, maxFanSpeedRpm);
			ValidateValue(CPUCooler.FanSizeMmStr, fanSizeMm);
			ValidateValue(CPUCooler.MaxNoiseLevelDbAStr, maxNoiseLevelDbA);

			if (minFanSpeedRpm is int mfs) cooler.MinFanSpeedRpm = mfs;
			if (maxFanSpeedRpm is int mxfs) cooler.MaxFanSpeedRpm = mxfs;
			if (fanSizeMm is int fs) cooler.FanSizeMm = fs;
			if (maxNoiseLevelDbA is double mnl) cooler.MaxNoiseLevelDbA = mnl;
		}

		public static void ModifyAIOCooler(long ID, int? minFanSpeedRpm, int? maxFanSpeedRpm, int? fanSizeMm, double? maxNoiseLevelDbA, int? radiatorSizeMm) {
			AIOCooler cooler = (AIOCooler)_products[ID];

			ModifyCPUCooler(cooler, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA);

			ValidateValue(AIOCooler.RadiatorSizeMmStr, radiatorSizeMm);

			if (radiatorSizeMm is int r) cooler.RadiatorSizeMm = r;

			RaiseCreatedOrModifiedEvent(cooler);
		}

		public static void ModifyAirCooler(long ID, int? minFanSpeedRpm, int? maxFanSpeedRpm, int? fanSizeMm, double? maxNoiseLevelDbA, int? coolerHeightMm) {
			AirCooler cooler = (AirCooler)_products[ID];

			ModifyCPUCooler(cooler, minFanSpeedRpm, maxFanSpeedRpm, fanSizeMm, maxNoiseLevelDbA);

			ValidateValue(AirCooler.CoolerHeightMmStr, coolerHeightMm);

			if (coolerHeightMm is int ch) cooler.CoolerHeightMm = ch;

			RaiseCreatedOrModifiedEvent(cooler);
		}

		public static void ModifyMotherboard(long ID, string? socket, string? chipset, MotherboardFormFactor? formFactor, MemoryType? memoryType, int? memorySlotCount, int? maxSupportedMemoryGB,
			int? pcieSlotCount, int? m2SlotCount, int? sataPortCount, bool? hasWifi, bool? allowsCpuOverclocking) {
			Motherboard mb = (Motherboard)_products[ID];

			ValidateValue(Motherboard.SocketStr, socket);
			ValidateValue(Motherboard.ChipsetStr, chipset);
			ValidateValue(Motherboard.MemorySlotCountStr, memorySlotCount);
			ValidateValue(Motherboard.MaxSupportedMemoryGBStr, maxSupportedMemoryGB);
			ValidateValue(Motherboard.PcieSlotCountStr, pcieSlotCount);
			ValidateValue(Motherboard.M2SlotCountStr, m2SlotCount);
			ValidateValue(Motherboard.SataPortCountStr, sataPortCount);

			if (socket is string s) mb.Socket = s;
			if (chipset is string c) mb.Chipset = c;
			if (formFactor is MotherboardFormFactor ff) mb.FormFactor = ff;
			if (memoryType is MemoryType mt) mb.MemoryType = mt;
			if (memorySlotCount is int msc) mb.MemorySlotCount = msc;
			if (maxSupportedMemoryGB is int msm) mb.MaxSupportedMemoryGB = msm;
			if (pcieSlotCount is int psc) mb.PcieSlotCount = psc;
			if (m2SlotCount is int m2sc) mb.M2SlotCount = m2sc;
			if (sataPortCount is int spc) mb.SataPortCount = spc;
			if (hasWifi is bool hw) mb.HasWifi = hw;
			if (allowsCpuOverclocking is bool aco) mb.AllowsCpuOverclocking = aco;

			RaiseCreatedOrModifiedEvent(mb);
		}

		public static void ModifyCase(long ID, CaseFormFactor? formFactor, MotherboardFormFactor? largestSupportedMotherboardFormFactor, int? maxGpuLengthMm, int? maxCpuCoolerHeightMm) {
			Case c = (Case)_products[ID];

			ValidateValue(Case.MaxGpuLengthMmStr, maxGpuLengthMm);
			ValidateValue(Case.MaxCpuCoolerHeightMmStr, maxCpuCoolerHeightMm);

			if (formFactor is CaseFormFactor ff) c.FormFactor = ff;
			if (largestSupportedMotherboardFormFactor is MotherboardFormFactor lsmff) c.LargestSupportedMotherboardFormFactor = lsmff;
			if (maxGpuLengthMm is int mgl) c.MaxGpuLengthMm = mgl;
			if (maxCpuCoolerHeightMm is int mcch) c.MaxCpuCoolerHeightMm = mcch;

			RaiseCreatedOrModifiedEvent(c);
		}

		public static void ModifyPSU(long ID, int? wattage, PSUEfficiencyRating? efficiencyRating, PSUModularity? modularity, PSUFormFactor? formFactor) {
			PSU psu = (PSU)_products[ID];

			ValidateValue(PSU.WattageStr, wattage);

			if (wattage is int w) psu.Wattage = w;
			if (efficiencyRating is PSUEfficiencyRating er) psu.EfficiencyRating = er;
			if (modularity is PSUModularity m) psu.Modularity = m;
			if (formFactor is PSUFormFactor ff) psu.FormFactor = ff;

			RaiseCreatedOrModifiedEvent(psu);
		}

		public static void ModifyCaseFan(long ID, int? sizeMm, int? maxFanSpeedRpm, int? minFanSpeedRpm, bool? pwmSupport) {
			CaseFan cf = (CaseFan)_products[ID];

			ValidateValue(CaseFan.SizeMmStr, sizeMm);
			ValidateValue(CaseFan.MaxFanSpeedRpmStr, maxFanSpeedRpm);
			ValidateValue(CaseFan.MinFanSpeedRpmStr, minFanSpeedRpm);

			if (sizeMm is int s) cf.SizeMm = s;
			if (maxFanSpeedRpm is int mfsr) cf.MaxFanSpeedRpm = mfsr;
			if (minFanSpeedRpm is int mnfsr) cf.MinFanSpeedRpm = mnfsr;
			if (pwmSupport is bool ps) cf.PwmSupport = ps;

			RaiseCreatedOrModifiedEvent(cf);
		}

		public static void ModifyGraphicsCard(long ID, string? gpuManufacturer, string? chipModel, string? architecture, int? coreCount, int? baseClockMHz, int? boostClockMHz,
			int? memoryCapacityGB, GpuMemoryType? memoryType, PcieGeneration? pcieGeneration, int? pcieLaneCount, int? tdpWatts, int? displayPortCount, int? hdmiPortCount) {
			GraphicsCard gpu = (GraphicsCard)_products[ID];

			ValidateValue(GraphicsCard.GpuManufacturerStr, gpuManufacturer);
			ValidateValue(GraphicsCard.ChipModelStr, chipModel);
			ValidateValue(GraphicsCard.ArchitectureStr, architecture);
			ValidateValue(GraphicsCard.CoreCountStr, coreCount);
			ValidateValue(GraphicsCard.BaseClockMHzStr, baseClockMHz);
			ValidateValue(GraphicsCard.BoostClockMHzStr, boostClockMHz);
			ValidateValue(GraphicsCard.MemoryCapacityGBStr, memoryCapacityGB);
			ValidateValue(GraphicsCard.PcieLaneCountStr, pcieLaneCount);
			ValidateValue(GraphicsCard.TdpWattsStr, tdpWatts);
			ValidateValue(GraphicsCard.DisplayPortCountStr, displayPortCount);
			ValidateValue(GraphicsCard.HdmiPortCountStr, hdmiPortCount);

			if (gpuManufacturer is string gm) gpu.Manufacturer = gm;
			if (chipModel is string cm) gpu.ChipModel = cm;
			if (architecture is string a) gpu.Architecture = a;
			if (coreCount is int cc) gpu.CoreCount = cc;
			if (baseClockMHz is int bc) gpu.BaseClockMHz = bc;
			if (boostClockMHz is int bstc) gpu.BoostClockMHz = bstc;
			if (memoryCapacityGB is int mc) gpu.MemoryCapacityGB = mc;
			if (memoryType is GpuMemoryType mt) gpu.MemoryType = mt;
			if (pcieGeneration is PcieGeneration pg) gpu.PcieGeneration = pg;
			if (pcieLaneCount is int plc) gpu.PcieLaneCount = plc;
			if (tdpWatts is int t) gpu.TdpWatts = t;
			if (displayPortCount is int dpc) gpu.DisplayPortCount = dpc;
			if (hdmiPortCount is int hpc) gpu.HdmiPortCount = hpc;

			RaiseCreatedOrModifiedEvent(gpu);
		}

		public static void ModifyCPU(long ID, string? socket, string? microarchitecture, int? coreCount, int? threadCount, int? baseClockMHz, int? boostClockMHz,
			int? l3CacheMB, int? tdpWatts, int? memoryChannelCount, int? maxSupportedMemoryGB, bool? supportsOverclocking) {
			CPU cpu = (CPU)_products[ID];

			ValidateValue(CPU.SocketStr, socket);
			ValidateValue(CPU.MicroarchitectureStr, microarchitecture);
			ValidateValue(CPU.CoreCountStr, coreCount);
			ValidateValue(CPU.ThreadCountStr, threadCount);
			ValidateValue(CPU.BaseClockStr, baseClockMHz);
			ValidateValue(CPU.BoostClockStr, boostClockMHz);
			ValidateValue(CPU.L3CacheMBStr, l3CacheMB);
			ValidateValue(CPU.TdpWattsStr, tdpWatts);
			ValidateValue(CPU.MemoryChannelCountStr, memoryChannelCount);
			ValidateValue(CPU.MaxSupportedMemoryGBStr, maxSupportedMemoryGB);

			if (socket is string s) cpu.Socket = s;
			if (microarchitecture is string ma) cpu.Microarchitecture = ma;
			if (coreCount is int cc) cpu.CoreCount = cc;
			if (threadCount is int tc) cpu.ThreadCount = tc;
			if (baseClockMHz is int bs) cpu.BaseClockMHz = bs;
			if (boostClockMHz is int bstc) cpu.BoostClockMHz = bstc;
			if (l3CacheMB is int l3c) cpu.L3CacheMB = l3c;
			if (tdpWatts is int t) cpu.TdpWatts = t;
			if (memoryChannelCount is int mcc) cpu.MemoryChannelCount = mcc;
			if (maxSupportedMemoryGB is int msm) cpu.MaxSupportedMemoryGB = msm;
			if (supportsOverclocking is bool so) cpu.SupportsOverclocking = so;

			RaiseCreatedOrModifiedEvent(cpu);
		}

		public static void ModifyRAMKit(long ID, int? moduleCapacityGB, int? moduleCount, MemoryType? memoryType, int? speedMTs, int? casLatency, bool? xmpSupport, bool? expoSupport) {
			RAMKit ram = (RAMKit)_products[ID];

			ValidateValue(RAMKit.ModuleCapacityGBStr, moduleCapacityGB);
			ValidateValue(RAMKit.ModuleCountStr, moduleCount);
			ValidateValue(RAMKit.SpeedMTsStr, speedMTs);
			ValidateValue(RAMKit.CasLatencyStr, casLatency);

			if (moduleCapacityGB is int mc) ram.ModuleCapacityGB = mc;
			if (moduleCount is int mct) ram.ModuleCount = mct;
			if (memoryType is MemoryType mt) ram.MemoryType = mt;
			if (speedMTs is int s) ram.SpeedMTs = s;
			if (casLatency is int cl) ram.CasLatency = cl;
			if (xmpSupport is bool xs) ram.XmpSupport = xs;
			if (expoSupport is bool es) ram.ExpoSupport = es;

			RaiseCreatedOrModifiedEvent(ram);
		}
	}
}

using MyCollections;
using System;
using System.Text.Json.Serialization;

namespace WarehouseManager {

	public abstract class ComputerComponent: Product {

		private BenchmarkInformation? _benchmarkInfo;

		public BenchmarkInformation? BenchmarkInfo {
			get => _benchmarkInfo;
			set => _benchmarkInfo = value;
		}

		public ComputerComponent(long ID, string name, string manufacturer, decimal price, int stockQuantity, double weightKg,
			BenchmarkInformation? benchmarkInfo):
			base(ID, name, manufacturer, price, stockQuantity, weightKg)
		{
			_benchmarkInfo = benchmarkInfo;
		}

		public const string BenchmarkInfoStr = "Benchmark Information";

		public override HashMap<string, string> GetSpecifications() {
			return new HashMap<string, string>() {
				[BenchmarkInfoStr] = (_benchmarkInfo is not null) ? _benchmarkInfo.ToString() : "Not available"
			};
		}

	}
}
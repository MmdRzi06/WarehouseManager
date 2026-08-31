using MyCollections;
using System;

namespace WarehouseManager {
	public interface IIdentifiable {
		public long ID { get; }

		private static readonly long IDLowerBound = 1000000000L;
		private static readonly long IDUpperBound = 10000000000L;
		public static long GenerateID() => Random.Shared.NextInt64(IDLowerBound, IDUpperBound);
	}
}
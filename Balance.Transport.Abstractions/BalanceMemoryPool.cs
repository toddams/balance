using System.Buffers;
using Balance.Shared.Buffers;

namespace Balance.Transport.Abstractions
{
	public static class BalanceMemoryPool
	{
		public static MemoryPool<byte> Create()
		{
#if DEBUG
			return new DiagnosticMemoryPool(CreateSlabMemoryPool());
#else
            return CreateSlabMemoryPool();
#endif
		}

		public static MemoryPool<byte> CreateSlabMemoryPool()
		{
			return new SlabMemoryPool();
		}

		public static readonly int MinimumSegmentSize = 4096;
	}
}

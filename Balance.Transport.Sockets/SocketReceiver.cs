﻿using System;
using System.IO.Pipelines;
using System.Net.Sockets;

namespace Balance.Transport.Sockets
{
	public sealed class SocketReceiver : SocketSenderReceiverBase
	{
		public SocketReceiver(Socket socket, PipeScheduler scheduler) : base(socket, scheduler)
		{
		}

		public SocketAwaitableEventArgs WaitForDataAsync()
		{
#if NETCOREAPP2_1
			_awaitableEventArgs.SetBuffer(Memory<byte>.Empty);
#elif NETSTANDARD2_0
            _awaitableEventArgs.SetBuffer(Array.Empty<byte>(), 0, 0);
#else
#error TFMs need to be updated
#endif

			if (!_socket.ReceiveAsync(_awaitableEventArgs))
			{
				_awaitableEventArgs.Complete();
			}

			return _awaitableEventArgs;
		}

		public SocketAwaitableEventArgs ReceiveAsync(Memory<byte> buffer)
		{
#if NETCOREAPP2_1
			_awaitableEventArgs.SetBuffer(buffer);
#elif NETSTANDARD2_0
            var segment = buffer.GetArray();

            _awaitableEventArgs.SetBuffer(segment.Array, segment.Offset, segment.Count);
#else
#error TFMs need to be updated
#endif
			if (!_socket.ReceiveAsync(_awaitableEventArgs))
			{
				_awaitableEventArgs.Complete();
			}

			return _awaitableEventArgs;
		}
	}
}

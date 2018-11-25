using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Balance.Transport.Sockets
{
	internal static class NativeMethods
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool SetHandleInformation(IntPtr hObject, HANDLE_FLAGS dwMask, HANDLE_FLAGS dwFlags);

		[Flags]
		private enum HANDLE_FLAGS : uint
		{
			None = 0,
			INHERIT = 1,
			PROTECT_FROM_CLOSE = 2
		}

		internal static void DisableHandleInheritance(Socket socket)
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				SetHandleInformation(socket.Handle, HANDLE_FLAGS.INHERIT, 0);
			}
		}
	}
}

﻿using System;
using System.IO;

namespace Balance.Connection.Abstractions.Exceptions
{
	public class ConnectionResetException : IOException
	{
		public ConnectionResetException(string message) : base(message)
		{
		}

		public ConnectionResetException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
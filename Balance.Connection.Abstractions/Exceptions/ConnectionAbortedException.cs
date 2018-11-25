﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Balance.Connection.Abstractions.Exceptions
{
	public class ConnectionAbortedException : OperationCanceledException
	{
		public ConnectionAbortedException() :
			this("The connection was aborted")
		{

		}

		public ConnectionAbortedException(string message) : base(message)
		{
		}

		public ConnectionAbortedException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}

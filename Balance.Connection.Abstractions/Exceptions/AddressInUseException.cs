using System;
using System.Collections.Generic;
using System.Text;

namespace Balance.Connection.Abstractions.Exceptions
{
	public class AddressInUseException : InvalidOperationException
	{
		public AddressInUseException(string message) : base(message)
		{
		}

		public AddressInUseException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}

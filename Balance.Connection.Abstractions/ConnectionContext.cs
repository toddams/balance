using System.Collections.Generic;
using System.IO.Pipelines;
using Balance.Connection.Abstractions.Exceptions;

namespace Balance.Connection.Abstractions
{
	public abstract class ConnectionContext
	{
		public abstract string ConnectionId { get; set; }

		public abstract IDictionary<object, object> Items { get; set; }

		public abstract IDuplexPipe Transport { get; set; }

		public virtual void Abort(ConnectionAbortedException abortReason)
		{
		}

		public virtual void Abort() => Abort(new ConnectionAbortedException("The connection was aborted by the application."));
	}
}

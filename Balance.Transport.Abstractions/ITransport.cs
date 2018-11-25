using System;
using System.Threading.Tasks;

namespace Balance.Transport.Abstractions
{
	public interface ITransport
	{
		// Can only be called once per ITransport
		Task BindAsync();

		Task UnbindAsync();

		Task StopAsync();
	}
}

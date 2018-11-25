using System.Threading.Tasks;

namespace Balance.Transport.Abstractions
{
	public interface IConnectionDispatcher
	{
		Task OnConnection(TransportConnection connection);
	}
}

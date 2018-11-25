namespace Balance.Transport.Abstractions
{
	/// <summary>
	/// Enumerates the <see cref="IEndPointInformation"/> types.
	/// </summary>
	public enum ListenType
	{
		IPEndPoint,
		SocketPath,
		FileHandle
	}
}

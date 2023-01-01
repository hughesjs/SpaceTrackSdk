namespace SpaceTrackSdk.Public.Clients;

public interface IClientAdapter<T>
{
	public Task<T?> Get();
	public Task<List<T>?> GetMany();
}
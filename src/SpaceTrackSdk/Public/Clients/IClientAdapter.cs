namespace SpaceTrackSdk.Public.Clients;

public interface IClientAdapter<T>
{
	public Task<T?> Get(string predicates = "");
	public Task<List<T>?> GetMany(string predicates = "");
}
namespace SpaceTrackSdk.Public.Queries.Predicates;

public abstract class Predicate<T>: IQueryComponent
{
	protected readonly T Value;
	protected abstract string Key { get; }
	
	protected Predicate(T value)
	{
		Value = value;
	}

	public virtual string GetQueryString() => $"{Key}/{Value}";
}
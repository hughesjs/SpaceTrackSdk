namespace SpaceTrackSdk.Public.Queries.Predicates;

public class CustomPredicate: Predicate<string>
{
	public CustomPredicate(string key, string value) : base(value)
	{
		Key = key;
	}

	protected override string Key { get; }
}
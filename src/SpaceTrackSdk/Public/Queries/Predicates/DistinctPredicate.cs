namespace SpaceTrackSdk.Public.Queries.Predicates;

public class DistinctPredicate: Predicate<bool>
{
	protected override string Key => "distinct";
	public DistinctPredicate(bool value) : base(value) { }
}
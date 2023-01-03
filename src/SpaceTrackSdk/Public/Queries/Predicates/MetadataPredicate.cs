namespace SpaceTrackSdk.Public.Queries.Predicates;

public class MetadataPredicate: Predicate<bool>
{
	public MetadataPredicate(bool value) : base(value){ }

	protected override string Key => "metadata";
}
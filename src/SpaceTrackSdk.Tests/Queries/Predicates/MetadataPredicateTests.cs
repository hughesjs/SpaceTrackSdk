using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class MetadataPredicateTests: PredicateTest
{
	protected override IPredicate SimplePredicate => new MetadataPredicate(false);
	protected override string SimpleExpected => "metadata/false";
}
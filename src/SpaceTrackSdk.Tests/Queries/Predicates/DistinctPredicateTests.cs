using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class DistinctPredicateTests: PredicateTest
{
	protected override IPredicate SimplePredicate => new DistinctPredicate(true);
	protected override string SimpleExpected => "distinct/true";
}
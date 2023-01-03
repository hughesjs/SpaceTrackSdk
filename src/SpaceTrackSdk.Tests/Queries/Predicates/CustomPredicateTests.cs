using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class CustomPredicateTests: PredicateTest
{
	protected override IPredicate SimplePredicate => new CustomPredicate("myCustomPredicate", "myValue");
	protected override string SimpleExpected => "myCustomPredicate/myValue";
}
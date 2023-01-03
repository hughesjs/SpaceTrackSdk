using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class LimitPredicateTests: PredicateTest
{
	protected override IPredicate SimplePredicate => new LimitPredicate(12);
	protected override string SimpleExpected => "limit/12";

	[Fact]
	public void CanUseGenerateOffsetLimit() => new LimitPredicate(12, 10).GetQueryString().ShouldBe("limit/12,10");
}
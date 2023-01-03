using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class OrderByPredicateTests : PredicateTest
{
	protected override IPredicate SimplePredicate => new OrderByPredicate("field1", true);
	protected override string SimpleExpected => "orderby/field1 asc";

	[Fact]
	public void OrderByDescendingCase() => new OrderByPredicate("field2", false).GetQueryString().ShouldBe("orderby/field2 desc");
}
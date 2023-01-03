using SpaceTrackSdk.Public.Queries.Operators;
using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public class FieldPredicateTests : PredicateTest
{
	protected override IPredicate SimplePredicate => new FieldPredicate("POWER_LVL", new GreaterThanOperator<int>(9000));
	protected override string SimpleExpected => "POWER_LVL/>9000";

	[Fact]
	public void CanUseCompoundOperatorWithFieldPredicate()
	{
		InclusiveRangeOperator<DateTime, DateTime> compoundOperator = new(new(2022, 10, 11), new(2023, 11, 09));
		IPredicate predicate = new FieldPredicate("LAUNCH_DATE", compoundOperator);
		
		predicate.GetQueryString().ShouldBe("LAUNCH_DATE/22-10-11 00:00:00--23-11-09 00:00:00");
	}

}
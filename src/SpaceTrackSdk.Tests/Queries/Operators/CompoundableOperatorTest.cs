using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

public abstract class CompoundableOperatorTest: OperatorTest
{
	protected abstract IQueryOperator CompoundedOperator { get; }
	protected abstract string CompoundedExpected { get; }

	
	[Fact]
	public void CanGetQueryStringForCompoundCase()
	{
		CompoundedOperator.GetQueryString().ShouldBe(CompoundedExpected);
	}
}
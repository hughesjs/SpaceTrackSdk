using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

public abstract class OperatorTest
{
	protected abstract IQueryOperator SimpleOperator { get; }
	
	
	protected abstract string SimpleExpected { get; }

	[Fact]
	public virtual void CanGetQueryStringForSimpleCase()
	{
		SimpleOperator.GetQueryString().ShouldBe(SimpleExpected);
	}


}
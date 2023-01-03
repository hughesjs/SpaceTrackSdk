using SpaceTrackSdk.Public.Queries.Predicates;

namespace SpaceTrackSdk.Tests.Queries.Predicates;

public abstract class PredicateTest
{
	protected abstract IPredicate SimplePredicate { get; }
	
	
	protected abstract string SimpleExpected { get; }

	[Fact]
	public virtual void CanGetQueryStringForSimpleCase()
	{
		SimplePredicate.GetQueryString().ShouldBe(SimpleExpected);
	}
}
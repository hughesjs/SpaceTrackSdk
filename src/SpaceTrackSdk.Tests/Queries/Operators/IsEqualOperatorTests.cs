using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class IsEqualOperatorTests: OperatorTest
{
	protected override IQueryOperator SimpleOperator => new IsEqualOperator<float>(2.2f);
	protected override string SimpleExpected => "2.2";
}
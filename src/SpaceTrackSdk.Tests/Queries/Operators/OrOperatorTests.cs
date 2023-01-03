using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class OrOperatorTests: OperatorTest
{
	protected override IQueryOperator SimpleOperator => new OrOperator<int>(new(){1,2,3,4,5});
	protected override string SimpleExpected => "1,2,3,4,5";
}
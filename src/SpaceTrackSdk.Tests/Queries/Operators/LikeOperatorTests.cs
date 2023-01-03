using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class LikeOperatorTests: OperatorTest
{
	protected override IQueryOperator SimpleOperator => new LikeOperator("BAD");
	protected override string SimpleExpected => "~~BAD";
}
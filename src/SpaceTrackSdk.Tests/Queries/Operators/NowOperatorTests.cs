using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class NowOperatorTest: OperatorTest
{
	protected override IQueryOperator SimpleOperator => new NowOperator(2.2f);
	protected override string SimpleExpected => "now+2.2";
}
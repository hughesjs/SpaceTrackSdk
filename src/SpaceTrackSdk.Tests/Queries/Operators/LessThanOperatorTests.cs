using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class LessThanOperatorTests: CompoundableOperatorTest
{
	protected override IQueryOperator SimpleOperator => new LessThanOperator<decimal>(2.345m);
	protected override string SimpleExpected => "<2.345";
	protected override IQueryOperator CompoundedOperator => new LessThanOperator<NowOperator>(new(-3));
	protected override string CompoundedExpected => "<now-3";
}
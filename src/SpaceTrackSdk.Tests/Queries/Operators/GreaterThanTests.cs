using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class GreaterThanTests: CompoundableOperatorTest
{
	protected override IQueryOperator SimpleOperator => new GreaterThanOperator<decimal>(2.345m);
	protected override string SimpleExpected => ">2.345";
	protected override IQueryOperator CompoundedOperator => new GreaterThanOperator<NowOperator>(new(-3));
	protected override string CompoundedExpected => ">now-3";
}
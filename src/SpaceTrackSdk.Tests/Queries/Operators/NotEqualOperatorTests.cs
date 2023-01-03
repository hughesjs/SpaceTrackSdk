using JetBrains.Annotations;
using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

[UsedImplicitly]
public class NotEqualOperatorTests: OperatorTest
{
	protected override IQueryOperator SimpleOperator => new NotEqualOperator<string>("P-NP");
	protected override string SimpleExpected => "<>P-NP";
}
using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class LikeOperator: Operator<string>
{
	public LikeOperator(string value) : base(value) { }

	public override string Opcode => "~~";
}
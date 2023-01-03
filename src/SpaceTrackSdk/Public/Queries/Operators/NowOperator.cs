using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class NowOperator: Operator<float?>
{
	public NowOperator(): base(null) { }
	public NowOperator(float value) : base(value) { }

	public override string Opcode => "now";

	public override string GetQueryString()
	{
		return Value switch
		{
			null => Opcode,
			>= 0 => $"{Opcode}+{Value}",
			< 0 => $"{Opcode}{Value}",
			_ => throw new ArgumentOutOfRangeException()
		};
	}
}
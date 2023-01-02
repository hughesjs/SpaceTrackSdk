namespace SpaceTrackSdk.Public.Queries.Operators;

public class Now: Operator<float?>
{
	public Now(): base(null) { }
	public Now(float value) : base(value) { }

	protected override string Opcode => "now";

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
namespace SpaceTrackSdk.Public.Queries.Operators;

public class InclusiveRange<T>: Operator<(T From,T To)>
{
	public InclusiveRange(T from, T to) : base((from, to)) { }

	protected override string Opcode => "--";

	public override string GetQueryString() => $"{Value.From}--{Value.To}";
}
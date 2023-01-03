namespace SpaceTrackSdk.Public.Queries.Operators;

public class InclusiveRangeOperator<T>: Operator<T>
{
	private readonly T _to;

	public InclusiveRangeOperator(T from, T to) : base(from)
	{
		_to = to;
	}

	protected override string Opcode => "--";

	public override string GetQueryString() => $"{Value}--{_to}";
}
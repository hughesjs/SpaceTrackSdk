namespace SpaceTrackSdk.Public.Queries.Operators;

public class OrOperator<T>: Operator<List<T>>
{
	public OrOperator(List<T> value) : base(value) { }

	protected override string Opcode => ",";

	public override string GetQueryString() => $"{string.Join(Opcode, Value)}";
}
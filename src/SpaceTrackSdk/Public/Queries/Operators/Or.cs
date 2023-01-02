namespace SpaceTrackSdk.Public.Queries.Operators;

public class Or<T>: Operator<List<T>>
{
	public Or(List<T> value) : base(value) { }

	protected override string Opcode => ",";

	public override string GetQueryString() => $"{string.Join(Opcode, Value)}";
}
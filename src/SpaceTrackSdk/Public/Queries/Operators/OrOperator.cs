using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class OrOperator<T>: Operator<List<T>>
{
	public OrOperator(List<T> value) : base(value) { }

	public override string Opcode => ",";

	public override string GetQueryString() => $"{string.Join(Opcode, Value)}";
}
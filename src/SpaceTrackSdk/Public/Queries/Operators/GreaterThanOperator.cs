using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class GreaterThanOperator<T>: Operator<T>
{
	public GreaterThanOperator(T value) : base(value) { }

	public override string Opcode => ">";
}
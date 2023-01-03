using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class LessThanOperator<T> : Operator<T>
{
	public LessThanOperator(T value) : base(value) { }

	public override string Opcode => "<";
}
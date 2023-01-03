using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class NotEqualOperator<T>: Operator<T?>
{
	public NotEqualOperator(T? value) : base(value) { }

	public override string Opcode => "<>";
}
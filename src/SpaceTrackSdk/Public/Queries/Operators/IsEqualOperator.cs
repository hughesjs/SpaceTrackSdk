using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class IsEqualOperator<T> : Operator<T?>
{
	public IsEqualOperator(T? value) : base(value) { }

	public override string Opcode => string.Empty;
}
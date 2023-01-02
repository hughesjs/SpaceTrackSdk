namespace SpaceTrackSdk.Public.Queries.Operators;

public class IsEqualOperator<T> : Operator<T?>
{
	public IsEqualOperator(T? value) : base(value) { }

	protected override string Opcode => string.Empty;
}
namespace SpaceTrackSdk.Public.Queries.Operators;

public class NotEqualOperator<T>: Operator<T?>
{
	public NotEqualOperator(T? value) : base(value) { }

	protected override string Opcode => "<>";
}
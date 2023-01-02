namespace SpaceTrackSdk.Public.Queries.Operators;

public class GreaterThanOperator<T>: Operator<T>
{
	public GreaterThanOperator(T value) : base(value) { }

	protected override string Opcode => ">";
}
namespace SpaceTrackSdk.Public.Queries.Operators;

public class GreaterThan<T>: Operator<T>
{
	public GreaterThan(T value) : base(value) { }

	protected override string Opcode => ">";
}
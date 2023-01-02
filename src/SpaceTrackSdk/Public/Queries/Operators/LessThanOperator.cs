namespace SpaceTrackSdk.Public.Queries.Operators;

public class LessThanOperator<T> : Operator<T>
{
	public LessThanOperator(T value) : base(value) { }

	protected override string Opcode => "<";
}
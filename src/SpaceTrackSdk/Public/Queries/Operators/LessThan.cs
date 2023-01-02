namespace SpaceTrackSdk.Public.Queries.Operators;

public class LessThan<T> : Operator<T>
{
	public LessThan(T value) : base(value) { }

	protected override string Opcode => "<";
}
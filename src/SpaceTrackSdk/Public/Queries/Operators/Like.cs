namespace SpaceTrackSdk.Public.Queries.Operators;

public class Like<T>: Operator<T>
{
	public Like(T value) : base(value) { }

	protected override string Opcode => "~~";
}
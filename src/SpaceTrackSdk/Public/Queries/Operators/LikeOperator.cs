namespace SpaceTrackSdk.Public.Queries.Operators;

public class LikeOperator<T>: Operator<T>
{
	public LikeOperator(T value) : base(value) { }

	protected override string Opcode => "~~";
}
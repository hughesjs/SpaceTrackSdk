namespace SpaceTrackSdk.Public.Queries.Predicates;

public class LimitPredicate: Predicate<int>
{
	private readonly int? _offset;
	public LimitPredicate(int value) : base(value) { }

	public LimitPredicate(int value, int offset) : base(value)
	{
		_offset = offset;
	}

	protected override string Key => "limit";

	public override string GetQueryString() => _offset is null ? base.GetQueryString() : $"{base.GetQueryString()},{_offset}";
}
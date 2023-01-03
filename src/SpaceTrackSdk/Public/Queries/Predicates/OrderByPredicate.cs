using SpaceTrackSdk.Public.Exceptions;

namespace SpaceTrackSdk.Public.Queries.Predicates;

public class OrderByPredicate: Predicate<string>
{
	private readonly bool _isAscending;

	public OrderByPredicate(string fieldName, bool isAscending) : base(fieldName)
	{
		_isAscending = isAscending;
	}

	protected override string Key => "orderby";

	public override string GetQueryString() => $"{Key}/{Value} {(_isAscending ? "asc" : "desc")}";
}
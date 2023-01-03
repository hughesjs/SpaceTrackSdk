using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Public.Queries.Predicates;

public class FieldPredicate: Predicate<IQueryOperator>
{
	public FieldPredicate(string fieldName, IQueryOperator value) : base(value)
	{
		Key = fieldName;
	}

	protected override string Key { get; }

	public override string GetQueryString() => $"{Key}/{Value.GetQueryString()}";
}
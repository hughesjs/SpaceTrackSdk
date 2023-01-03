using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Tests.Queries.Operators;

public class InclusiveRangeOperatorTest: CompoundableOperatorTest
{
	[Fact]
	public void CanGetQueryForSimpleInclusiveRange()
	{
		const int start = 2;
		const float end = 3.4f;
		InclusiveRangeOperator<int, float> rangeOperator = new(start, end);
		
		rangeOperator.GetQueryString().ShouldBe("2--3.4");
	}

	[Fact]
	public void CanCreatePartiallyCompoundExclusiveRange()
	{
		NowOperator startTime = new();
		const float endTime = 3.4f;

		InclusiveRangeOperator<NowOperator, float> rangeOperator = new(startTime, endTime);
		
		rangeOperator.GetQueryString().ShouldBe("now--3.4");
	}

	[Fact]
	public void CanCreateDateTimeRange()
	{
		DateTime start = new(23, 10, 1, 11, 12, 13);
		DateTime end = new(22, 10, 1, 11, 12, 13);
		InclusiveRangeOperator<DateTime, DateTime> rangeOperator = new(start, end);
		
		rangeOperator.GetQueryString().ShouldBe("23-10-01 11:12:13--22-10-01 11:12:13");
	}

	protected override IQueryOperator SimpleOperator => new InclusiveRangeOperator<int, float>(2, 3.4f);
	protected override IQueryOperator CompoundedOperator => new InclusiveRangeOperator<NowOperator, NowOperator>(new(1), new(-3));

	protected override string SimpleExpected => "2--3.4";
	protected override string CompoundedExpected => "now+1--now-3";
}
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Internal.Serialisation.Converters;

// TODO - Look into a tidier way to do this... there's a lot of code duplication to handle the nullability
internal abstract class DateTimeConverter
{
	private static DateTime GetDateTime(ref Utf8JsonReader reader, string format)
	{
		string dateString = reader.GetString()!;
		return DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
	}

	private static void WriteDateTime(Utf8JsonWriter writer, DateTime value, string format)
	{
		string dateString = value.ToString(format, CultureInfo.InvariantCulture);
		writer.WriteStringValue(dateString);
	}
	
	internal abstract class Simple
	{
		private const string SimpleDateTimeFormat = "yyyy-MM-dd H:mm:ss";
	
		internal class NullableConverter : JsonConverter<DateTime?>
		{
			public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				if (reader.TokenType is JsonTokenType.Null) return null;
				return GetDateTime(ref reader, SimpleDateTimeFormat);
			}

			public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
			{
				if (value is null)
				{
					writer.WriteNullValue();
					return;
				}

				WriteDateTime(writer, value.Value, SimpleDateTimeFormat);
			}
		}
	
		internal class NotNullableConverter : JsonConverter<DateTime>
		{
			public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) 
				=> GetDateTime(ref reader, SimpleDateTimeFormat);

			public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
				=> WriteDateTime(writer, value, SimpleDateTimeFormat);
		}
	}
	
	internal abstract class Precise
	{
		private const string ComplexDateTimeFormat = "yyyy-MM-dd H:mm:ss.FFFFFF";
	
		internal class NullableConverter : JsonConverter<DateTime?>
		{
			public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				if (reader.TokenType is JsonTokenType.Null) return null;
				return GetDateTime(ref reader, ComplexDateTimeFormat);
			}

			public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
			{
				if (value is null)
				{
					writer.WriteNullValue();
					return;
				}
				WriteDateTime(writer, value.Value, ComplexDateTimeFormat);
			}
		}
	
		internal class NotNullableConverter : JsonConverter<DateTime>
		{
			public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) 
				=> GetDateTime(ref reader, ComplexDateTimeFormat);

			public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
				=> WriteDateTime(writer, value, ComplexDateTimeFormat);
		}
	}

}
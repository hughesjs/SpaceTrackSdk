using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Internal.Serialisation.Converters;

internal class YesNoBoolConverter
{
	private static bool IsTrue(char c) => c is 'y' or 'Y';

	internal class NullableConverter: JsonConverter<bool?>
	{
		public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType is JsonTokenType.Null) return null;
			string c = reader.GetString()!;
			return c.Length == 1 && IsTrue(c[0]);
		}

		public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNullValue();
				return;
			}
			
			writer.WriteStringValue(value is true ? "Y" : "N");
		}
	}
	
	internal class NotNullableConverter: JsonConverter<bool>
	{
		public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string c = reader.GetString()!;
			return c.Length == 1 && IsTrue(c[0]);
		}

		public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value is true ? "Y" : "N");
		}
	}
}
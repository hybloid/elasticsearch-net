// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
internal sealed class TermsQueryConverter : JsonConverter<TermsQuery>
{
	public override TermsQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		var variant = new TermsQuery();
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				variant.Field = property;
				reader.Read();
				variant.Terms = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField>(ref reader, options);
			}
		}

		return variant;
	}

	public override void Write(Utf8JsonWriter writer, TermsQuery value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.Field is not null && value.Terms is not null)
		{
			if (!options.TryGetClientSettings(out var settings))
			{
				throw new JsonException("Unable to retrive client settings for JsonSerializerOptions.");
			}

			var propertyName = settings.Inferrer.Field(value.Field);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, value.Terms, options);
		}

		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(TermsQueryConverter))]
public sealed partial class TermsQuery : Query
{
	public string? QueryName { get; set; }

	public float? Boost { get; set; }

	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	public Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField Terms { get; set; }
}

public sealed partial class TermsQueryDescriptor<TDocument> : SerializableDescriptor<TermsQueryDescriptor<TDocument>>
{
	internal TermsQueryDescriptor(Action<TermsQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public TermsQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField TermsValue { get; set; }

	public TermsQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public TermsQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TermsQueryDescriptor<TDocument> Terms(Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField terms)
	{
		TermsValue = terms;
		return Self;
	}

	public TermsQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && TermsValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, TermsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TermsQueryDescriptor : SerializableDescriptor<TermsQueryDescriptor>
{
	internal TermsQueryDescriptor(Action<TermsQueryDescriptor> configure) => configure.Invoke(this);
	public TermsQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField TermsValue { get; set; }

	public TermsQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public TermsQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TermsQueryDescriptor Terms(Elastic.Clients.Elasticsearch.QueryDsl.TermsQueryField terms)
	{
		TermsValue = terms;
		return Self;
	}

	public TermsQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FieldValue is not null && TermsValue is not null)
		{
			var propertyName = settings.Inferrer.Field(FieldValue);
			writer.WritePropertyName(propertyName);
			JsonSerializer.Serialize(writer, TermsValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WriteEndObject();
	}
}
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
namespace Elastic.Clients.Elasticsearch.Mapping;
public sealed partial class SuggestContext
{
	[JsonInclude]
	[JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Name Name { get; set; }

	[JsonInclude]
	[JsonPropertyName("path")]
	public Elastic.Clients.Elasticsearch.Field? Path { get; set; }

	[JsonInclude]
	[JsonPropertyName("precision")]
	public Union<int?, string?>? Precision { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type { get; set; }
}

public sealed partial class SuggestContextDescriptor<TDocument> : SerializableDescriptor<SuggestContextDescriptor<TDocument>>
{
	internal SuggestContextDescriptor(Action<SuggestContextDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SuggestContextDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Name NameValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? PathValue { get; set; }

	private Union<int?, string?>? PrecisionValue { get; set; }

	private string TypeValue { get; set; }

	public SuggestContextDescriptor<TDocument> Name(Elastic.Clients.Elasticsearch.Name name)
	{
		NameValue = name;
		return Self;
	}

	public SuggestContextDescriptor<TDocument> Path(Elastic.Clients.Elasticsearch.Field? path)
	{
		PathValue = path;
		return Self;
	}

	public SuggestContextDescriptor<TDocument> Path<TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	public SuggestContextDescriptor<TDocument> Precision(Union<int?, string?>? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	public SuggestContextDescriptor<TDocument> Type(string type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("name");
		JsonSerializer.Serialize(writer, NameValue, options);
		if (PathValue is not null)
		{
			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue(TypeValue);
		writer.WriteEndObject();
	}
}

public sealed partial class SuggestContextDescriptor : SerializableDescriptor<SuggestContextDescriptor>
{
	internal SuggestContextDescriptor(Action<SuggestContextDescriptor> configure) => configure.Invoke(this);
	public SuggestContextDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Name NameValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? PathValue { get; set; }

	private Union<int?, string?>? PrecisionValue { get; set; }

	private string TypeValue { get; set; }

	public SuggestContextDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		NameValue = name;
		return Self;
	}

	public SuggestContextDescriptor Path(Elastic.Clients.Elasticsearch.Field? path)
	{
		PathValue = path;
		return Self;
	}

	public SuggestContextDescriptor Path<TDocument, TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	public SuggestContextDescriptor Path<TDocument>(Expression<Func<TDocument, object>> path)
	{
		PathValue = path;
		return Self;
	}

	public SuggestContextDescriptor Precision(Union<int?, string?>? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	public SuggestContextDescriptor Type(string type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("name");
		JsonSerializer.Serialize(writer, NameValue, options);
		if (PathValue is not null)
		{
			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
		}

		if (PrecisionValue is not null)
		{
			writer.WritePropertyName("precision");
			JsonSerializer.Serialize(writer, PrecisionValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue(TypeValue);
		writer.WriteEndObject();
	}
}
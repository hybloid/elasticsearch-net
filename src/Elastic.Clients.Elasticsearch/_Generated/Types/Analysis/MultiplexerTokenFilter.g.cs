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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class MultiplexerTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("filters")]
	public IEnumerable<string> Filters { get; set; }

	[JsonInclude]
	[JsonPropertyName("preserve_original")]
	public bool? PreserveOriginal { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "multiplexer";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class MultiplexerTokenFilterDescriptor : SerializableDescriptor<MultiplexerTokenFilterDescriptor>, IBuildableDescriptor<MultiplexerTokenFilter>
{
	internal MultiplexerTokenFilterDescriptor(Action<MultiplexerTokenFilterDescriptor> configure) => configure.Invoke(this);
	public MultiplexerTokenFilterDescriptor() : base()
	{
	}

	private IEnumerable<string> FiltersValue { get; set; }

	private bool? PreserveOriginalValue { get; set; }

	private string? VersionValue { get; set; }

	public MultiplexerTokenFilterDescriptor Filters(IEnumerable<string> filters)
	{
		FiltersValue = filters;
		return Self;
	}

	public MultiplexerTokenFilterDescriptor PreserveOriginal(bool? preserveOriginal = true)
	{
		PreserveOriginalValue = preserveOriginal;
		return Self;
	}

	public MultiplexerTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("filters");
		JsonSerializer.Serialize(writer, FiltersValue, options);
		if (PreserveOriginalValue.HasValue)
		{
			writer.WritePropertyName("preserve_original");
			writer.WriteBooleanValue(PreserveOriginalValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("multiplexer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	MultiplexerTokenFilter IBuildableDescriptor<MultiplexerTokenFilter>.Build() => new()
	{ Filters = FiltersValue, PreserveOriginal = PreserveOriginalValue, Version = VersionValue };
}
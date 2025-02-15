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
public sealed partial class IcuNormalizationTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType Name { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "icu_normalizer";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class IcuNormalizationTokenFilterDescriptor : SerializableDescriptor<IcuNormalizationTokenFilterDescriptor>, IBuildableDescriptor<IcuNormalizationTokenFilter>
{
	internal IcuNormalizationTokenFilterDescriptor(Action<IcuNormalizationTokenFilterDescriptor> configure) => configure.Invoke(this);
	public IcuNormalizationTokenFilterDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType NameValue { get; set; }

	private string? VersionValue { get; set; }

	public IcuNormalizationTokenFilterDescriptor Name(Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType name)
	{
		NameValue = name;
		return Self;
	}

	public IcuNormalizationTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("name");
		JsonSerializer.Serialize(writer, NameValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("icu_normalizer");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	IcuNormalizationTokenFilter IBuildableDescriptor<IcuNormalizationTokenFilter>.Build() => new()
	{ Name = NameValue, Version = VersionValue };
}
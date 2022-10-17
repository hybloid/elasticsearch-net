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
public sealed partial class StemmerOverrideTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("rules")]
	public IEnumerable<string>? Rules { get; set; }

	[JsonInclude]
	[JsonPropertyName("rules_path")]
	public string? RulesPath { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "stemmer_override";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class StemmerOverrideTokenFilterDescriptor : SerializableDescriptor<StemmerOverrideTokenFilterDescriptor>, IBuildableDescriptor<StemmerOverrideTokenFilter>
{
	internal StemmerOverrideTokenFilterDescriptor(Action<StemmerOverrideTokenFilterDescriptor> configure) => configure.Invoke(this);
	public StemmerOverrideTokenFilterDescriptor() : base()
	{
	}

	private IEnumerable<string>? RulesValue { get; set; }

	private string? RulesPathValue { get; set; }

	private string? VersionValue { get; set; }

	public StemmerOverrideTokenFilterDescriptor Rules(IEnumerable<string>? rules)
	{
		RulesValue = rules;
		return Self;
	}

	public StemmerOverrideTokenFilterDescriptor RulesPath(string? rulesPath)
	{
		RulesPathValue = rulesPath;
		return Self;
	}

	public StemmerOverrideTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (RulesValue is not null)
		{
			writer.WritePropertyName("rules");
			JsonSerializer.Serialize(writer, RulesValue, options);
		}

		if (!string.IsNullOrEmpty(RulesPathValue))
		{
			writer.WritePropertyName("rules_path");
			writer.WriteStringValue(RulesPathValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("stemmer_override");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	StemmerOverrideTokenFilter IBuildableDescriptor<StemmerOverrideTokenFilter>.Build() => new()
	{ Rules = RulesValue, RulesPath = RulesPathValue, Version = VersionValue };
}
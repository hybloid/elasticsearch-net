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
public sealed partial class PhoneticTokenFilter : ITokenFilterDefinition
{
	[JsonInclude]
	[JsonPropertyName("encoder")]
	public Elastic.Clients.Elasticsearch.Analysis.PhoneticEncoder Encoder { get; set; }

	[JsonInclude]
	[JsonPropertyName("languageset")]
	public IEnumerable<Elastic.Clients.Elasticsearch.Analysis.PhoneticLanguage> Languageset { get; set; }

	[JsonInclude]
	[JsonPropertyName("max_code_len")]
	public int? MaxCodeLen { get; set; }

	[JsonInclude]
	[JsonPropertyName("name_type")]
	public Elastic.Clients.Elasticsearch.Analysis.PhoneticNameType NameType { get; set; }

	[JsonInclude]
	[JsonPropertyName("replace")]
	public bool? Replace { get; set; }

	[JsonInclude]
	[JsonPropertyName("rule_type")]
	public Elastic.Clients.Elasticsearch.Analysis.PhoneticRuleType RuleType { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "phonetic";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class PhoneticTokenFilterDescriptor : SerializableDescriptor<PhoneticTokenFilterDescriptor>, IBuildableDescriptor<PhoneticTokenFilter>
{
	internal PhoneticTokenFilterDescriptor(Action<PhoneticTokenFilterDescriptor> configure) => configure.Invoke(this);
	public PhoneticTokenFilterDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Analysis.PhoneticEncoder EncoderValue { get; set; }

	private IEnumerable<Elastic.Clients.Elasticsearch.Analysis.PhoneticLanguage> LanguagesetValue { get; set; }

	private int? MaxCodeLenValue { get; set; }

	private Elastic.Clients.Elasticsearch.Analysis.PhoneticNameType NameTypeValue { get; set; }

	private bool? ReplaceValue { get; set; }

	private Elastic.Clients.Elasticsearch.Analysis.PhoneticRuleType RuleTypeValue { get; set; }

	private string? VersionValue { get; set; }

	public PhoneticTokenFilterDescriptor Encoder(Elastic.Clients.Elasticsearch.Analysis.PhoneticEncoder encoder)
	{
		EncoderValue = encoder;
		return Self;
	}

	public PhoneticTokenFilterDescriptor Languageset(IEnumerable<Elastic.Clients.Elasticsearch.Analysis.PhoneticLanguage> languageset)
	{
		LanguagesetValue = languageset;
		return Self;
	}

	public PhoneticTokenFilterDescriptor MaxCodeLen(int? maxCodeLen)
	{
		MaxCodeLenValue = maxCodeLen;
		return Self;
	}

	public PhoneticTokenFilterDescriptor NameType(Elastic.Clients.Elasticsearch.Analysis.PhoneticNameType nameType)
	{
		NameTypeValue = nameType;
		return Self;
	}

	public PhoneticTokenFilterDescriptor Replace(bool? replace = true)
	{
		ReplaceValue = replace;
		return Self;
	}

	public PhoneticTokenFilterDescriptor RuleType(Elastic.Clients.Elasticsearch.Analysis.PhoneticRuleType ruleType)
	{
		RuleTypeValue = ruleType;
		return Self;
	}

	public PhoneticTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("encoder");
		JsonSerializer.Serialize(writer, EncoderValue, options);
		writer.WritePropertyName("languageset");
		JsonSerializer.Serialize(writer, LanguagesetValue, options);
		if (MaxCodeLenValue.HasValue)
		{
			writer.WritePropertyName("max_code_len");
			writer.WriteNumberValue(MaxCodeLenValue.Value);
		}

		writer.WritePropertyName("name_type");
		JsonSerializer.Serialize(writer, NameTypeValue, options);
		if (ReplaceValue.HasValue)
		{
			writer.WritePropertyName("replace");
			writer.WriteBooleanValue(ReplaceValue.Value);
		}

		writer.WritePropertyName("rule_type");
		JsonSerializer.Serialize(writer, RuleTypeValue, options);
		writer.WritePropertyName("type");
		writer.WriteStringValue("phonetic");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	PhoneticTokenFilter IBuildableDescriptor<PhoneticTokenFilter>.Build() => new()
	{ Encoder = EncoderValue, Languageset = LanguagesetValue, MaxCodeLen = MaxCodeLenValue, NameType = NameTypeValue, Replace = ReplaceValue, RuleType = RuleTypeValue, Version = VersionValue };
}
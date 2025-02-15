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
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed class TermsEnumRequestParameters : RequestParameters<TermsEnumRequestParameters>
{
}

public sealed partial class TermsEnumRequest : PlainRequest<TermsEnumRequestParameters>
{
	public TermsEnumRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceTermsEnum;
	protected override HttpMethod HttpMethod => HttpMethod.POST;
	protected override bool SupportsBody => true;
	[JsonInclude]
	[JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude]
	[JsonPropertyName("size")]
	public int? Size { get; set; }

	[JsonInclude]
	[JsonPropertyName("timeout")]
	public Elastic.Clients.Elasticsearch.Duration? Timeout { get; set; }

	[JsonInclude]
	[JsonPropertyName("case_insensitive")]
	public bool? CaseInsensitive { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? IndexFilter { get; set; }

	[JsonInclude]
	[JsonPropertyName("string")]
	public string? String { get; set; }

	[JsonInclude]
	[JsonPropertyName("search_after")]
	public string? SearchAfter { get; set; }
}

public sealed partial class TermsEnumRequestDescriptor<TDocument> : RequestDescriptor<TermsEnumRequestDescriptor<TDocument>, TermsEnumRequestParameters>
{
	internal TermsEnumRequestDescriptor(Action<TermsEnumRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public TermsEnumRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	public TermsEnumRequestDescriptor(TDocument document) : this(typeof(TDocument))
	{
	}

	internal TermsEnumRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceTermsEnum;
	protected override HttpMethod HttpMethod => HttpMethod.POST;
	protected override bool SupportsBody => true;
	public TermsEnumRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? IndexFilterValue { get; set; }

	private QueryDsl.QueryContainerDescriptor<TDocument> IndexFilterDescriptor { get; set; }

	private Action<QueryDsl.QueryContainerDescriptor<TDocument>> IndexFilterDescriptorAction { get; set; }

	private bool? CaseInsensitiveValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? SearchAfterValue { get; set; }

	private int? SizeValue { get; set; }

	private string? StringValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? TimeoutValue { get; set; }

	public TermsEnumRequestDescriptor<TDocument> IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> IndexFilter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> IndexFilter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> CaseInsensitive(bool? caseInsensitive = true)
	{
		CaseInsensitiveValue = caseInsensitive;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> SearchAfter(string? searchAfter)
	{
		SearchAfterValue = searchAfter;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> String(string? value)
	{
		StringValue = value;
		return Self;
	}

	public TermsEnumRequestDescriptor<TDocument> Timeout(Elastic.Clients.Elasticsearch.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (CaseInsensitiveValue.HasValue)
		{
			writer.WritePropertyName("case_insensitive");
			writer.WriteBooleanValue(CaseInsensitiveValue.Value);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(SearchAfterValue))
		{
			writer.WritePropertyName("search_after");
			writer.WriteStringValue(SearchAfterValue);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (!string.IsNullOrEmpty(StringValue))
		{
			writer.WritePropertyName("string");
			writer.WriteStringValue(StringValue);
		}

		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TermsEnumRequestDescriptor : RequestDescriptor<TermsEnumRequestDescriptor, TermsEnumRequestParameters>
{
	internal TermsEnumRequestDescriptor(Action<TermsEnumRequestDescriptor> configure) => configure.Invoke(this);
	public TermsEnumRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
	{
	}

	internal TermsEnumRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceTermsEnum;
	protected override HttpMethod HttpMethod => HttpMethod.POST;
	protected override bool SupportsBody => true;
	public TermsEnumRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
	{
		RouteValues.Required("index", index);
		return Self;
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? IndexFilterValue { get; set; }

	private QueryDsl.QueryContainerDescriptor IndexFilterDescriptor { get; set; }

	private Action<QueryDsl.QueryContainerDescriptor> IndexFilterDescriptorAction { get; set; }

	private bool? CaseInsensitiveValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private string? SearchAfterValue { get; set; }

	private int? SizeValue { get; set; }

	private string? StringValue { get; set; }

	private Elastic.Clients.Elasticsearch.Duration? TimeoutValue { get; set; }

	public TermsEnumRequestDescriptor IndexFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? indexFilter)
	{
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = null;
		IndexFilterValue = indexFilter;
		return Self;
	}

	public TermsEnumRequestDescriptor IndexFilter(QueryDsl.QueryContainerDescriptor descriptor)
	{
		IndexFilterValue = null;
		IndexFilterDescriptorAction = null;
		IndexFilterDescriptor = descriptor;
		return Self;
	}

	public TermsEnumRequestDescriptor IndexFilter(Action<QueryDsl.QueryContainerDescriptor> configure)
	{
		IndexFilterValue = null;
		IndexFilterDescriptor = null;
		IndexFilterDescriptorAction = configure;
		return Self;
	}

	public TermsEnumRequestDescriptor CaseInsensitive(bool? caseInsensitive = true)
	{
		CaseInsensitiveValue = caseInsensitive;
		return Self;
	}

	public TermsEnumRequestDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsEnumRequestDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsEnumRequestDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TermsEnumRequestDescriptor SearchAfter(string? searchAfter)
	{
		SearchAfterValue = searchAfter;
		return Self;
	}

	public TermsEnumRequestDescriptor Size(int? size)
	{
		SizeValue = size;
		return Self;
	}

	public TermsEnumRequestDescriptor String(string? value)
	{
		StringValue = value;
		return Self;
	}

	public TermsEnumRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout)
	{
		TimeoutValue = timeout;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexFilterDescriptor is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterDescriptor, options);
		}
		else if (IndexFilterDescriptorAction is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(IndexFilterDescriptorAction), options);
		}
		else if (IndexFilterValue is not null)
		{
			writer.WritePropertyName("index_filter");
			JsonSerializer.Serialize(writer, IndexFilterValue, options);
		}

		if (CaseInsensitiveValue.HasValue)
		{
			writer.WritePropertyName("case_insensitive");
			writer.WriteBooleanValue(CaseInsensitiveValue.Value);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(SearchAfterValue))
		{
			writer.WritePropertyName("search_after");
			writer.WriteStringValue(SearchAfterValue);
		}

		if (SizeValue.HasValue)
		{
			writer.WritePropertyName("size");
			writer.WriteNumberValue(SizeValue.Value);
		}

		if (!string.IsNullOrEmpty(StringValue))
		{
			writer.WritePropertyName("string");
			writer.WriteStringValue(StringValue);
		}

		if (TimeoutValue is not null)
		{
			writer.WritePropertyName("timeout");
			JsonSerializer.Serialize(writer, TimeoutValue, options);
		}

		writer.WriteEndObject();
	}
}
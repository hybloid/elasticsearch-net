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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed partial class SlowlogTresholds
{
	[JsonInclude]
	[JsonPropertyName("fetch")]
	public Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? Fetch { get; set; }

	[JsonInclude]
	[JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? Index { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? Query { get; set; }
}

public sealed partial class SlowlogTresholdsDescriptor : SerializableDescriptor<SlowlogTresholdsDescriptor>
{
	internal SlowlogTresholdsDescriptor(Action<SlowlogTresholdsDescriptor> configure) => configure.Invoke(this);
	public SlowlogTresholdsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? FetchValue { get; set; }

	private SlowlogTresholdLevelsDescriptor FetchDescriptor { get; set; }

	private Action<SlowlogTresholdLevelsDescriptor> FetchDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? IndexValue { get; set; }

	private SlowlogTresholdLevelsDescriptor IndexDescriptor { get; set; }

	private Action<SlowlogTresholdLevelsDescriptor> IndexDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? QueryValue { get; set; }

	private SlowlogTresholdLevelsDescriptor QueryDescriptor { get; set; }

	private Action<SlowlogTresholdLevelsDescriptor> QueryDescriptorAction { get; set; }

	public SlowlogTresholdsDescriptor Fetch(Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? fetch)
	{
		FetchDescriptor = null;
		FetchDescriptorAction = null;
		FetchValue = fetch;
		return Self;
	}

	public SlowlogTresholdsDescriptor Fetch(SlowlogTresholdLevelsDescriptor descriptor)
	{
		FetchValue = null;
		FetchDescriptorAction = null;
		FetchDescriptor = descriptor;
		return Self;
	}

	public SlowlogTresholdsDescriptor Fetch(Action<SlowlogTresholdLevelsDescriptor> configure)
	{
		FetchValue = null;
		FetchDescriptor = null;
		FetchDescriptorAction = configure;
		return Self;
	}

	public SlowlogTresholdsDescriptor Index(Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? index)
	{
		IndexDescriptor = null;
		IndexDescriptorAction = null;
		IndexValue = index;
		return Self;
	}

	public SlowlogTresholdsDescriptor Index(SlowlogTresholdLevelsDescriptor descriptor)
	{
		IndexValue = null;
		IndexDescriptorAction = null;
		IndexDescriptor = descriptor;
		return Self;
	}

	public SlowlogTresholdsDescriptor Index(Action<SlowlogTresholdLevelsDescriptor> configure)
	{
		IndexValue = null;
		IndexDescriptor = null;
		IndexDescriptorAction = configure;
		return Self;
	}

	public SlowlogTresholdsDescriptor Query(Elastic.Clients.Elasticsearch.IndexManagement.SlowlogTresholdLevels? query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public SlowlogTresholdsDescriptor Query(SlowlogTresholdLevelsDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public SlowlogTresholdsDescriptor Query(Action<SlowlogTresholdLevelsDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FetchDescriptor is not null)
		{
			writer.WritePropertyName("fetch");
			JsonSerializer.Serialize(writer, FetchDescriptor, options);
		}
		else if (FetchDescriptorAction is not null)
		{
			writer.WritePropertyName("fetch");
			JsonSerializer.Serialize(writer, new SlowlogTresholdLevelsDescriptor(FetchDescriptorAction), options);
		}
		else if (FetchValue is not null)
		{
			writer.WritePropertyName("fetch");
			JsonSerializer.Serialize(writer, FetchValue, options);
		}

		if (IndexDescriptor is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexDescriptor, options);
		}
		else if (IndexDescriptorAction is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, new SlowlogTresholdLevelsDescriptor(IndexDescriptorAction), options);
		}
		else if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new SlowlogTresholdLevelsDescriptor(QueryDescriptorAction), options);
		}
		else if (QueryValue is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		writer.WriteEndObject();
	}
}
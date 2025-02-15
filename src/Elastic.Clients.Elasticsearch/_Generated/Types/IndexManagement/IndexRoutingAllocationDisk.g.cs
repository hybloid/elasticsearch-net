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
public sealed partial class IndexRoutingAllocationDisk
{
	[JsonInclude]
	[JsonPropertyName("threshold_enabled")]
	public Union<bool?, string?>? ThresholdEnabled { get; set; }
}

public sealed partial class IndexRoutingAllocationDiskDescriptor : SerializableDescriptor<IndexRoutingAllocationDiskDescriptor>
{
	internal IndexRoutingAllocationDiskDescriptor(Action<IndexRoutingAllocationDiskDescriptor> configure) => configure.Invoke(this);
	public IndexRoutingAllocationDiskDescriptor() : base()
	{
	}

	private Union<bool?, string?>? ThresholdEnabledValue { get; set; }

	public IndexRoutingAllocationDiskDescriptor ThresholdEnabled(Union<bool?, string?>? thresholdEnabled)
	{
		ThresholdEnabledValue = thresholdEnabled;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ThresholdEnabledValue is not null)
		{
			writer.WritePropertyName("threshold_enabled");
			JsonSerializer.Serialize(writer, ThresholdEnabledValue, options);
		}

		writer.WriteEndObject();
	}
}
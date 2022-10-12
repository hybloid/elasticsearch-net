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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public sealed partial class InferenceAggregate : IAggregate
	{
		[JsonInclude]
		[JsonPropertyName("data")]
		public Dictionary<string, object> Data { get; init; }

		[JsonInclude]
		[JsonPropertyName("feature_importance")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Aggregations.InferenceFeatureImportance>? FeatureImportance { get; init; }

		[JsonInclude]
		[JsonPropertyName("meta")]
		public Dictionary<string, object>? Meta { get; init; }

		[JsonInclude]
		[JsonPropertyName("top_classes")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Aggregations.InferenceTopClassEntry>? TopClasses { get; init; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public Elastic.Clients.Elasticsearch.FieldValue? Value { get; init; }

		[JsonInclude]
		[JsonPropertyName("warning")]
		public string? Warning { get; init; }
	}
}
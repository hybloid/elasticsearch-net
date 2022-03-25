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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Tasks
{
	public partial class TasksListResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("node_failures")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? NodeFailures { get; init; }

		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Tasks.NodeTasks>? Nodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("task_failures")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.TaskFailure>? TaskFailures { get; init; }

		[JsonInclude]
		[JsonPropertyName("tasks")]
		public Elastic.Clients.Elasticsearch.Tasks.TaskInfos? Tasks { get; init; }
	}
}
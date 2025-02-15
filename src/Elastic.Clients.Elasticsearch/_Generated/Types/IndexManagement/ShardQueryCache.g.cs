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
public sealed partial class ShardQueryCache
{
	[JsonInclude]
	[JsonPropertyName("cache_count")]
	public long CacheCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("cache_size")]
	public long CacheSize { get; init; }

	[JsonInclude]
	[JsonPropertyName("evictions")]
	public long Evictions { get; init; }

	[JsonInclude]
	[JsonPropertyName("hit_count")]
	public long HitCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("memory_size_in_bytes")]
	public long MemorySizeInBytes { get; init; }

	[JsonInclude]
	[JsonPropertyName("miss_count")]
	public long MissCount { get; init; }

	[JsonInclude]
	[JsonPropertyName("total_count")]
	public long TotalCount { get; init; }
}
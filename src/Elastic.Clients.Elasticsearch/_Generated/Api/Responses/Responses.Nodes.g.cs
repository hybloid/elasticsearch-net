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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class HotThreadsResponse : ResponseBase
	{
		[JsonPropertyName("hot_threads")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Nodes.HotThreads.HotThread> HotThreads
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InfoResponse : Nodes.NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Info.NodeInfo> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ReloadSecureSettingsResponse : Nodes.NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Union<Elastic.Clients.Elasticsearch.Nodes.Stats, Elastic.Clients.Elasticsearch.Nodes.ReloadSecureSettings.NodeReloadException>> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class StatsResponse : Nodes.NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Stats> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class UsageResponse : Nodes.NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Elastic.Clients.Elasticsearch.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Nodes.Usage.NodeUsage> Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}
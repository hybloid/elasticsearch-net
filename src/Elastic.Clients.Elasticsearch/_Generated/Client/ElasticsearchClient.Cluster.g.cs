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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster;
public class ClusterNamespace : NamespacedClientProxy
{
	internal ClusterNamespace(ElasticsearchClient client) : base(client)
	{
	}

	public ClusterHealthResponse Health(ClusterHealthRequest request)
	{
		request.BeforeRequest();
		return DoRequest<ClusterHealthRequest, ClusterHealthResponse>(request);
	}

	public Task<ClusterHealthResponse> HealthAsync(ClusterHealthRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ClusterHealthRequest, ClusterHealthResponse>(request, cancellationToken);
	}

	public ClusterHealthResponse Health()
	{
		var descriptor = new ClusterHealthRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
	}

	public ClusterHealthResponse Health(Action<ClusterHealthRequestDescriptor> configureRequest)
	{
		var descriptor = new ClusterHealthRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
	}

	public ClusterHealthResponse Health<TDocument>(Action<ClusterHealthRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new ClusterHealthRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<ClusterHealthRequestDescriptor<TDocument>, ClusterHealthResponse>(descriptor);
	}

	public Task<ClusterHealthResponse> HealthAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new ClusterHealthRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
	}

	public Task<ClusterHealthResponse> HealthAsync(Action<ClusterHealthRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ClusterHealthRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
	}

	public Task<ClusterHealthResponse> HealthAsync<TDocument>(Action<ClusterHealthRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ClusterHealthRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterHealthRequestDescriptor<TDocument>, ClusterHealthResponse>(descriptor);
	}
}
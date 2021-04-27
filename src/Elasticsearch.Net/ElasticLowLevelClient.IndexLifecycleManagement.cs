/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elastic.Transport;
using static Elastic.Transport.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.IndexLifecycleManagementApi
{
	///<summary>
	/// Index Lifecycle Management APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.IndexLifecycleManagement"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelIndexLifecycleManagementNamespace : NamespacedClientProxy
	{
		internal LowLevelIndexLifecycleManagementNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-delete-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteLifecycle<TResponse>(string policyId, DeleteLifecycleRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(DELETE, Url($"_ilm/policy/{policyId:policyId}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-delete-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.delete_lifecycle", "policy_id")]
		public Task<TResponse> DeleteLifecycleAsync<TResponse>(string policyId, DeleteLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_ilm/policy/{policyId:policyId}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_ilm/explain <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-explain-lifecycle.html</para></summary>
		///<param name = "index">The name of the index to explain</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ExplainLifecycle<TResponse>(string index, ExplainLifecycleRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_ilm/explain"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_ilm/explain <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-explain-lifecycle.html</para></summary>
		///<param name = "index">The name of the index to explain</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.explain_lifecycle", "index")]
		public Task<TResponse> ExplainLifecycleAsync<TResponse>(string index, ExplainLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_ilm/explain"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetLifecycle<TResponse>(string policyId, GetLifecycleRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, Url($"_ilm/policy/{policyId:policyId}"), null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.get_lifecycle", "policy_id")]
		public Task<TResponse> GetLifecycleAsync<TResponse>(string policyId, GetLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_ilm/policy/{policyId:policyId}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/policy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetLifecycle<TResponse>(GetLifecycleRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, "_ilm/policy", null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/policy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.get_lifecycle", "")]
		public Task<TResponse> GetLifecycleAsync<TResponse>(GetLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, "_ilm/policy", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/status <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-status.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetStatus<TResponse>(GetIlmStatusRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(GET, "_ilm/status", null, RequestParams(requestParameters));
		///<summary>GET on /_ilm/status <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-status.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.get_status", "")]
		public Task<TResponse> GetStatusAsync<TResponse>(GetIlmStatusRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(GET, "_ilm/status", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_ilm/move/{index} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-move-to-step.html</para></summary>
		///<param name = "index">The name of the index whose lifecycle step is to change</param>
		///<param name = "body">The new lifecycle step to move to</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse MoveToStep<TResponse>(string index, PostData body, MoveToStepRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, Url($"_ilm/move/{index:index}"), body, RequestParams(requestParameters));
		///<summary>POST on /_ilm/move/{index} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-move-to-step.html</para></summary>
		///<param name = "index">The name of the index whose lifecycle step is to change</param>
		///<param name = "body">The new lifecycle step to move to</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.move_to_step", "index, body")]
		public Task<TResponse> MoveToStepAsync<TResponse>(string index, PostData body, MoveToStepRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, Url($"_ilm/move/{index:index}"), ctx, body, RequestParams(requestParameters));
		///<summary>PUT on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-put-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "body">The lifecycle policy definition to register</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutLifecycle<TResponse>(string policyId, PostData body, PutLifecycleRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(PUT, Url($"_ilm/policy/{policyId:policyId}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_ilm/policy/{policy_id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-put-lifecycle.html</para></summary>
		///<param name = "policyId">The name of the index lifecycle policy</param>
		///<param name = "body">The lifecycle policy definition to register</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.put_lifecycle", "policy_id, body")]
		public Task<TResponse> PutLifecycleAsync<TResponse>(string policyId, PostData body, PutLifecycleRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_ilm/policy/{policyId:policyId}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ilm/remove <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-remove-policy.html</para></summary>
		///<param name = "index">The name of the index to remove policy on</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse RemovePolicy<TResponse>(string index, RemovePolicyRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_ilm/remove"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ilm/remove <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-remove-policy.html</para></summary>
		///<param name = "index">The name of the index to remove policy on</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.remove_policy", "index")]
		public Task<TResponse> RemovePolicyAsync<TResponse>(string index, RemovePolicyRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_ilm/remove"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ilm/retry <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-retry-policy.html</para></summary>
		///<param name = "index">The name of the indices (comma-separated) whose failed lifecycle step is to be retry</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Retry<TResponse>(string index, RetryIlmRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_ilm/retry"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ilm/retry <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-retry-policy.html</para></summary>
		///<param name = "index">The name of the indices (comma-separated) whose failed lifecycle step is to be retry</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.retry", "index")]
		public Task<TResponse> RetryAsync<TResponse>(string index, RetryIlmRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_ilm/retry"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_ilm/start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-start.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Start<TResponse>(StartIlmRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_ilm/start", null, RequestParams(requestParameters));
		///<summary>POST on /_ilm/start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-start.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.start", "")]
		public Task<TResponse> StartAsync<TResponse>(StartIlmRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_ilm/start", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /_ilm/stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-stop.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse Stop<TResponse>(StopIlmRequestParameters requestParameters = null)
			where TResponse : class, ITransportResponse, new() => DoRequest<TResponse>(POST, "_ilm/stop", null, RequestParams(requestParameters));
		///<summary>POST on /_ilm/stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-stop.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("ilm.stop", "")]
		public Task<TResponse> StopAsync<TResponse>(StopIlmRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, ITransportResponse, new() => DoRequestAsync<TResponse>(POST, "_ilm/stop", ctx, null, RequestParams(requestParameters));
	}
}
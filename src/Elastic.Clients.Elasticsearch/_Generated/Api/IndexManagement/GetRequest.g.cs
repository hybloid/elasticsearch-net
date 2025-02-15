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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed class GetRequestParameters : RequestParameters<GetRequestParameters>
{
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>? Features { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>?>("features"); set => Q("features", value); }
}

public sealed partial class GetRequest : PlainRequest<GetRequestParameters>
{
	public GetRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGet;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	[JsonIgnore]
	public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	[JsonIgnore]
	public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

	[JsonIgnore]
	public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>? Features { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>?>("features"); set => Q("features", value); }
}

public sealed partial class GetRequestDescriptor<TDocument> : RequestDescriptor<GetRequestDescriptor<TDocument>, GetRequestParameters>
{
	internal GetRequestDescriptor(Action<GetRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public GetRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal GetRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGet;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public GetRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public GetRequestDescriptor<TDocument> ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public GetRequestDescriptor<TDocument> Features(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>? features) => Qs("features", features);
	public GetRequestDescriptor<TDocument> FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public GetRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public GetRequestDescriptor<TDocument> IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public GetRequestDescriptor<TDocument> Local(bool? local = true) => Qs("local", local);
	public GetRequestDescriptor<TDocument> MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public GetRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class GetRequestDescriptor : RequestDescriptor<GetRequestDescriptor, GetRequestParameters>
{
	internal GetRequestDescriptor(Action<GetRequestDescriptor> configure) => configure.Invoke(this);
	public GetRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
	{
	}

	internal GetRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGet;
	protected override HttpMethod HttpMethod => HttpMethod.GET;
	protected override bool SupportsBody => false;
	public GetRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public GetRequestDescriptor ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public GetRequestDescriptor Features(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.Feature>? features) => Qs("features", features);
	public GetRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
	public GetRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public GetRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public GetRequestDescriptor Local(bool? local = true) => Qs("local", local);
	public GetRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
	public GetRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
	{
		RouteValues.Required("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}
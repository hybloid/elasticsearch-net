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
namespace Elastic.Clients.Elasticsearch.Sql;
public sealed class SqlDeleteAsyncRequestParameters : RequestParameters<SqlDeleteAsyncRequestParameters>
{
}

public sealed partial class SqlDeleteAsyncRequest : PlainRequest<SqlDeleteAsyncRequestParameters>
{
	public SqlDeleteAsyncRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	protected override HttpMethod HttpMethod => HttpMethod.DELETE;
	protected override bool SupportsBody => false;
}

public sealed partial class SqlDeleteAsyncRequestDescriptor<TDocument> : RequestDescriptor<SqlDeleteAsyncRequestDescriptor<TDocument>, SqlDeleteAsyncRequestParameters>
{
	internal SqlDeleteAsyncRequestDescriptor(Action<SqlDeleteAsyncRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SqlDeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal SqlDeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	protected override HttpMethod HttpMethod => HttpMethod.DELETE;
	protected override bool SupportsBody => false;
	public SqlDeleteAsyncRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

public sealed partial class SqlDeleteAsyncRequestDescriptor : RequestDescriptor<SqlDeleteAsyncRequestDescriptor, SqlDeleteAsyncRequestParameters>
{
	internal SqlDeleteAsyncRequestDescriptor(Action<SqlDeleteAsyncRequestDescriptor> configure) => configure.Invoke(this);
	public SqlDeleteAsyncRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
	{
	}

	internal SqlDeleteAsyncRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlDeleteAsync;
	protected override HttpMethod HttpMethod => HttpMethod.DELETE;
	protected override bool SupportsBody => false;
	public SqlDeleteAsyncRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}
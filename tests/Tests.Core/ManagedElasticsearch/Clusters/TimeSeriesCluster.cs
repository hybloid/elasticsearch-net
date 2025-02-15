// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Tests.Core.ManagedElasticsearch.NodeSeeders;

namespace Tests.Core.ManagedElasticsearch.Clusters;

public class TimeSeriesCluster : ReadOnlyCluster
{
	protected override void SeedNode() => new TimeSeriesSeeder(Client).SeedNode();
}

﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.MachineLearning.GetBuckets
{
	public class GetBucketsUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_ml/anomaly_detectors/job_id/results/buckets")
			.Fluent(c => c.GetBuckets("job_id"))
			.Request(c => c.GetBuckets(new GetBucketsRequest("job_id")))
			.FluentAsync(c => c.GetBucketsAsync("job_id"))
			.RequestAsync(c => c.GetBucketsAsync(new GetBucketsRequest("job_id")));
	}
}

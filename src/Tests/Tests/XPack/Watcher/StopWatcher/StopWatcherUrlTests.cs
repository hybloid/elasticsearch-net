﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Watcher.StopWatcher
{
	public class StopWatcherUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await POST("/_watcher/_stop")
			.Fluent(c => c.StopWatcher())
			.Request(c => c.StopWatcher(new StopWatcherRequest()))
			.FluentAsync(c => c.StopWatcherAsync())
			.RequestAsync(c => c.StopWatcherAsync(new StopWatcherRequest()));
	}
}

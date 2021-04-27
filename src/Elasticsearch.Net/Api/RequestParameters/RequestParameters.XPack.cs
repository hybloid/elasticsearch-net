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
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.XPackApi
{
	///<summary>Request options for Info <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html</para></summary>
	public class XPackInfoRequestParameters : RequestParameters<XPackInfoRequestParameters>
	{
		///<summary>If this param is used it must be set to true</summary>
		[Obsolete("Scheduled to be removed in 8.0, Deprecated as of: 8.0.0, reason: Supported for backwards compatibility with 7.x")]
		public bool? AcceptEnterprise
		{
			get => Q<bool? >("accept_enterprise");
			set => Q("accept_enterprise", value);
		}

		///<summary>Comma-separated list of info categories. Can be any of: build, license, features</summary>
		public string[] Categories
		{
			get => Q<string[]>("categories");
			set => Q("categories", value);
		}
	}

	///<summary>Request options for Usage <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html</para></summary>
	public class XPackUsageRequestParameters : RequestParameters<XPackUsageRequestParameters>
	{
		///<summary>Specify timeout for watch write operation</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}
}
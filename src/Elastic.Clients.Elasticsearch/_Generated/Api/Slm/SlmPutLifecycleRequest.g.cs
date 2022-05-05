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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Slm
{
	public sealed class SlmPutLifecycleRequestParameters : RequestParameters<SlmPutLifecycleRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class SlmPutLifecycleRequest : PlainRequestBase<SlmPutLifecycleRequestParameters>
	{
		public SlmPutLifecycleRequest(Elastic.Clients.Elasticsearch.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("config")]
		public Elastic.Clients.Elasticsearch.Slm.Configuration? Config { get; set; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

		[JsonInclude]
		[JsonPropertyName("repository")]
		public string? Repository { get; set; }

		[JsonInclude]
		[JsonPropertyName("retention")]
		public Elastic.Clients.Elasticsearch.Slm.Retention? Retention { get; set; }

		[JsonInclude]
		[JsonPropertyName("schedule")]
		public string? Schedule { get; set; }
	}

	public sealed partial class SlmPutLifecycleRequestDescriptor : RequestDescriptorBase<SlmPutLifecycleRequestDescriptor, SlmPutLifecycleRequestParameters>
	{
		internal SlmPutLifecycleRequestDescriptor(Action<SlmPutLifecycleRequestDescriptor> configure) => configure.Invoke(this);
		public SlmPutLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}

		internal SlmPutLifecycleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public SlmPutLifecycleRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public SlmPutLifecycleRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public SlmPutLifecycleRequestDescriptor PolicyId(Elastic.Clients.Elasticsearch.Name policy_id)
		{
			RouteValues.Required("policy_id", policy_id);
			return Self;
		}

		private Elastic.Clients.Elasticsearch.Slm.Configuration? ConfigValue { get; set; }

		private ConfigurationDescriptor ConfigDescriptor { get; set; }

		private Action<ConfigurationDescriptor> ConfigDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }

		private string? RepositoryValue { get; set; }

		private Elastic.Clients.Elasticsearch.Slm.Retention? RetentionValue { get; set; }

		private RetentionDescriptor RetentionDescriptor { get; set; }

		private Action<RetentionDescriptor> RetentionDescriptorAction { get; set; }

		private string? ScheduleValue { get; set; }

		public SlmPutLifecycleRequestDescriptor Config(Elastic.Clients.Elasticsearch.Slm.Configuration? config)
		{
			ConfigDescriptor = null;
			ConfigDescriptorAction = null;
			ConfigValue = config;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Config(ConfigurationDescriptor descriptor)
		{
			ConfigValue = null;
			ConfigDescriptorAction = null;
			ConfigDescriptor = descriptor;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Config(Action<ConfigurationDescriptor> configure)
		{
			ConfigValue = null;
			ConfigDescriptor = null;
			ConfigDescriptorAction = configure;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
		{
			NameValue = name;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Repository(string? repository)
		{
			RepositoryValue = repository;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Retention(Elastic.Clients.Elasticsearch.Slm.Retention? retention)
		{
			RetentionDescriptor = null;
			RetentionDescriptorAction = null;
			RetentionValue = retention;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Retention(RetentionDescriptor descriptor)
		{
			RetentionValue = null;
			RetentionDescriptorAction = null;
			RetentionDescriptor = descriptor;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Retention(Action<RetentionDescriptor> configure)
		{
			RetentionValue = null;
			RetentionDescriptor = null;
			RetentionDescriptorAction = configure;
			return Self;
		}

		public SlmPutLifecycleRequestDescriptor Schedule(string? schedule)
		{
			ScheduleValue = schedule;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ConfigDescriptor is not null)
			{
				writer.WritePropertyName("config");
				JsonSerializer.Serialize(writer, ConfigDescriptor, options);
			}
			else if (ConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("config");
				JsonSerializer.Serialize(writer, new ConfigurationDescriptor(ConfigDescriptorAction), options);
			}
			else if (ConfigValue is not null)
			{
				writer.WritePropertyName("config");
				JsonSerializer.Serialize(writer, ConfigValue, options);
			}

			if (NameValue is not null)
			{
				writer.WritePropertyName("name");
				JsonSerializer.Serialize(writer, NameValue, options);
			}

			if (!string.IsNullOrEmpty(RepositoryValue))
			{
				writer.WritePropertyName("repository");
				writer.WriteStringValue(RepositoryValue);
			}

			if (RetentionDescriptor is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, RetentionDescriptor, options);
			}
			else if (RetentionDescriptorAction is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, new RetentionDescriptor(RetentionDescriptorAction), options);
			}
			else if (RetentionValue is not null)
			{
				writer.WritePropertyName("retention");
				JsonSerializer.Serialize(writer, RetentionValue, options);
			}

			if (ScheduleValue is not null)
			{
				writer.WritePropertyName("schedule");
				JsonSerializer.Serialize(writer, ScheduleValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
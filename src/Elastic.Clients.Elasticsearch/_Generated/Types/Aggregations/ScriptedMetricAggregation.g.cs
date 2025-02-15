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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations;
internal sealed class ScriptedMetricAggregationConverter : JsonConverter<ScriptedMetricAggregation>
{
	public override ScriptedMetricAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var aggName = reader.GetString();
		if (aggName != "scripted_metric")
			throw new JsonException("Unexpected JSON detected.");
		var agg = new ScriptedMetricAggregation(aggName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("combine_script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.CombineScript = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("field"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
					if (value is not null)
					{
						agg.Field = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("init_script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.InitScript = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("map_script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.MapScript = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("missing"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<FieldValue?>(ref reader, options);
					if (value is not null)
					{
						agg.Missing = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("params"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
					if (value is not null)
					{
						agg.Params = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("reduce_script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.ReduceScript = value;
					}

					continue;
				}

				if (reader.ValueTextEquals("script"))
				{
					reader.Read();
					var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
					if (value is not null)
					{
						agg.Script = value;
					}

					continue;
				}
			}
		}

		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				if (reader.ValueTextEquals("meta"))
				{
					var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
					if (value is not null)
					{
						agg.Meta = value;
					}

					continue;
				}
			}
		}

		return agg;
	}

	public override void Write(Utf8JsonWriter writer, ScriptedMetricAggregation value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("scripted_metric");
		writer.WriteStartObject();
		if (value.CombineScript is not null)
		{
			writer.WritePropertyName("combine_script");
			JsonSerializer.Serialize(writer, value.CombineScript, options);
		}

		if (value.Field is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, value.Field, options);
		}

		if (value.InitScript is not null)
		{
			writer.WritePropertyName("init_script");
			JsonSerializer.Serialize(writer, value.InitScript, options);
		}

		if (value.MapScript is not null)
		{
			writer.WritePropertyName("map_script");
			JsonSerializer.Serialize(writer, value.MapScript, options);
		}

		if (value.Missing is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, value.Missing, options);
		}

		if (value.Params is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, value.Params, options);
		}

		if (value.ReduceScript is not null)
		{
			writer.WritePropertyName("reduce_script");
			JsonSerializer.Serialize(writer, value.ReduceScript, options);
		}

		if (value.Script is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, value.Script, options);
		}

		writer.WriteEndObject();
		if (value.Meta is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, value.Meta, options);
		}

		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(ScriptedMetricAggregationConverter))]
public sealed partial class ScriptedMetricAggregation : Aggregation
{
	public ScriptedMetricAggregation(string name, Field field) : this(name) => Field = field;
	public ScriptedMetricAggregation(string name) => Name = name;
	internal ScriptedMetricAggregation()
	{
	}

	public Elastic.Clients.Elasticsearch.Script? CombineScript { get; set; }

	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	public Elastic.Clients.Elasticsearch.Script? InitScript { get; set; }

	public Elastic.Clients.Elasticsearch.Script? MapScript { get; set; }

	public Dictionary<string, object>? Meta { get; set; }

	public FieldValue? Missing { get; set; }

	public override string? Name { get; internal set; }

	public Dictionary<string, object>? Params { get; set; }

	public Elastic.Clients.Elasticsearch.Script? ReduceScript { get; set; }

	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
}

public sealed partial class ScriptedMetricAggregationDescriptor<TDocument> : SerializableDescriptor<ScriptedMetricAggregationDescriptor<TDocument>>
{
	internal ScriptedMetricAggregationDescriptor(Action<ScriptedMetricAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ScriptedMetricAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Script? CombineScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? InitScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? MapScriptValue { get; set; }

	private Dictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Dictionary<string, object>? ParamsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ReduceScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public ScriptedMetricAggregationDescriptor<TDocument> CombineScript(Elastic.Clients.Elasticsearch.Script? combineScript)
	{
		CombineScriptValue = combineScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> InitScript(Elastic.Clients.Elasticsearch.Script? initScript)
	{
		InitScriptValue = initScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> MapScript(Elastic.Clients.Elasticsearch.Script? mapScript)
	{
		MapScriptValue = mapScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> ReduceScript(Elastic.Clients.Elasticsearch.Script? reduceScript)
	{
		ReduceScriptValue = reduceScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("scripted_metric");
		writer.WriteStartObject();
		if (CombineScriptValue is not null)
		{
			writer.WritePropertyName("combine_script");
			JsonSerializer.Serialize(writer, CombineScriptValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (InitScriptValue is not null)
		{
			writer.WritePropertyName("init_script");
			JsonSerializer.Serialize(writer, InitScriptValue, options);
		}

		if (MapScriptValue is not null)
		{
			writer.WritePropertyName("map_script");
			JsonSerializer.Serialize(writer, MapScriptValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ReduceScriptValue is not null)
		{
			writer.WritePropertyName("reduce_script");
			JsonSerializer.Serialize(writer, ReduceScriptValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class ScriptedMetricAggregationDescriptor : SerializableDescriptor<ScriptedMetricAggregationDescriptor>
{
	internal ScriptedMetricAggregationDescriptor(Action<ScriptedMetricAggregationDescriptor> configure) => configure.Invoke(this);
	public ScriptedMetricAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Script? CombineScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? InitScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? MapScriptValue { get; set; }

	private Dictionary<string, object>? MetaValue { get; set; }

	private FieldValue? MissingValue { get; set; }

	private Dictionary<string, object>? ParamsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ReduceScriptValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public ScriptedMetricAggregationDescriptor CombineScript(Elastic.Clients.Elasticsearch.Script? combineScript)
	{
		CombineScriptValue = combineScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor InitScript(Elastic.Clients.Elasticsearch.Script? initScript)
	{
		InitScriptValue = initScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor MapScript(Elastic.Clients.Elasticsearch.Script? mapScript)
	{
		MapScriptValue = mapScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Missing(FieldValue? missing)
	{
		MissingValue = missing;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public ScriptedMetricAggregationDescriptor ReduceScript(Elastic.Clients.Elasticsearch.Script? reduceScript)
	{
		ReduceScriptValue = reduceScript;
		return Self;
	}

	public ScriptedMetricAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("scripted_metric");
		writer.WriteStartObject();
		if (CombineScriptValue is not null)
		{
			writer.WritePropertyName("combine_script");
			JsonSerializer.Serialize(writer, CombineScriptValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (InitScriptValue is not null)
		{
			writer.WritePropertyName("init_script");
			JsonSerializer.Serialize(writer, InitScriptValue, options);
		}

		if (MapScriptValue is not null)
		{
			writer.WritePropertyName("map_script");
			JsonSerializer.Serialize(writer, MapScriptValue, options);
		}

		if (MissingValue is not null)
		{
			writer.WritePropertyName("missing");
			JsonSerializer.Serialize(writer, MissingValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (ReduceScriptValue is not null)
		{
			writer.WritePropertyName("reduce_script");
			JsonSerializer.Serialize(writer, ReduceScriptValue, options);
		}

		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		writer.WriteEndObject();
	}
}
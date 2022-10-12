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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public sealed partial class TextProperty : IProperty
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonInclude]
		[JsonPropertyName("copy_to")]
		public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

		[JsonInclude]
		[JsonPropertyName("dynamic")]
		public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

		[JsonInclude]
		[JsonPropertyName("eager_global_ordinals")]
		public bool? EagerGlobalOrdinals { get; set; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public bool? Fielddata { get; set; }

		[JsonInclude]
		[JsonPropertyName("fielddata_frequency_filter")]
		public Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? FielddataFrequencyFilter { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_above")]
		public int? IgnoreAbove { get; set; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public bool? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_phrases")]
		public bool? IndexPhrases { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_prefixes")]
		public Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixes { get; set; }

		[JsonInclude]
		[JsonPropertyName("local_metadata")]
		public Dictionary<string, object>? LocalMetadata { get; set; }

		[JsonInclude]
		[JsonPropertyName("meta")]
		public Dictionary<string, string>? Meta { get; set; }

		[JsonInclude]
		[JsonPropertyName("norms")]
		public bool? Norms { get; set; }

		[JsonInclude]
		[JsonPropertyName("position_increment_gap")]
		public int? PositionIncrementGap { get; set; }

		[JsonInclude]
		[JsonPropertyName("properties")]
		public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_analyzer")]
		public string? SearchAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_quote_analyzer")]
		public string? SearchQuoteAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("similarity")]
		public string? Similarity { get; set; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public bool? Store { get; set; }

		[JsonInclude]
		[JsonPropertyName("term_vector")]
		public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVector { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "text";
	}

	public sealed partial class TextPropertyDescriptor<TDocument> : SerializableDescriptorBase<TextPropertyDescriptor<TDocument>>, IBuildableDescriptor<TextProperty>
	{
		internal TextPropertyDescriptor(Action<TextPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public TextPropertyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private double? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private bool? EagerGlobalOrdinalsValue { get; set; }

		private bool? FielddataValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? FielddataFrequencyFilterValue { get; set; }

		private IndexManagement.FielddataFrequencyFilterDescriptor FielddataFrequencyFilterDescriptor { get; set; }

		private Action<IndexManagement.FielddataFrequencyFilterDescriptor> FielddataFrequencyFilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

		private bool? IndexPhrasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixesValue { get; set; }

		private TextIndexPrefixesDescriptor IndexPrefixesDescriptor { get; set; }

		private Action<TextIndexPrefixesDescriptor> IndexPrefixesDescriptorAction { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NormsValue { get; set; }

		private int? PositionIncrementGapValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SearchAnalyzerValue { get; set; }

		private string? SearchQuoteAnalyzerValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

		public TextPropertyDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Boost(double? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
		{
			EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Fielddata(bool? fielddata = true)
		{
			FielddataValue = fielddata;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> FielddataFrequencyFilter(Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? fielddataFrequencyFilter)
		{
			FielddataFrequencyFilterDescriptor = null;
			FielddataFrequencyFilterDescriptorAction = null;
			FielddataFrequencyFilterValue = fielddataFrequencyFilter;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> FielddataFrequencyFilter(IndexManagement.FielddataFrequencyFilterDescriptor descriptor)
		{
			FielddataFrequencyFilterValue = null;
			FielddataFrequencyFilterDescriptorAction = null;
			FielddataFrequencyFilterDescriptor = descriptor;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> FielddataFrequencyFilter(Action<IndexManagement.FielddataFrequencyFilterDescriptor> configure)
		{
			FielddataFrequencyFilterValue = null;
			FielddataFrequencyFilterDescriptor = null;
			FielddataFrequencyFilterDescriptorAction = configure;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
		{
			IndexOptionsValue = indexOptions;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IndexPhrases(bool? indexPhrases = true)
		{
			IndexPhrasesValue = indexPhrases;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IndexPrefixes(Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? indexPrefixes)
		{
			IndexPrefixesDescriptor = null;
			IndexPrefixesDescriptorAction = null;
			IndexPrefixesValue = indexPrefixes;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IndexPrefixes(TextIndexPrefixesDescriptor descriptor)
		{
			IndexPrefixesValue = null;
			IndexPrefixesDescriptorAction = null;
			IndexPrefixesDescriptor = descriptor;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> IndexPrefixes(Action<TextIndexPrefixesDescriptor> configure)
		{
			IndexPrefixesValue = null;
			IndexPrefixesDescriptor = null;
			IndexPrefixesDescriptorAction = configure;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Norms(bool? norms = true)
		{
			NormsValue = norms;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> PositionIncrementGap(int? positionIncrementGap)
		{
			PositionIncrementGapValue = positionIncrementGap;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> SearchAnalyzer(string? searchAnalyzer)
		{
			SearchAnalyzerValue = searchAnalyzer;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
		{
			SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public TextPropertyDescriptor<TDocument> TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
		{
			TermVectorValue = termVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (EagerGlobalOrdinalsValue.HasValue)
			{
				writer.WritePropertyName("eager_global_ordinals");
				writer.WriteBooleanValue(EagerGlobalOrdinalsValue.Value);
			}

			if (FielddataValue.HasValue)
			{
				writer.WritePropertyName("fielddata");
				writer.WriteBooleanValue(FielddataValue.Value);
			}

			if (FielddataFrequencyFilterDescriptor is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, FielddataFrequencyFilterDescriptor, options);
			}
			else if (FielddataFrequencyFilterDescriptorAction is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, new IndexManagement.FielddataFrequencyFilterDescriptor(FielddataFrequencyFilterDescriptorAction), options);
			}
			else if (FielddataFrequencyFilterValue is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, FielddataFrequencyFilterValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (IndexOptionsValue is not null)
			{
				writer.WritePropertyName("index_options");
				JsonSerializer.Serialize(writer, IndexOptionsValue, options);
			}

			if (IndexPhrasesValue.HasValue)
			{
				writer.WritePropertyName("index_phrases");
				writer.WriteBooleanValue(IndexPhrasesValue.Value);
			}

			if (IndexPrefixesDescriptor is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, IndexPrefixesDescriptor, options);
			}
			else if (IndexPrefixesDescriptorAction is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction), options);
			}
			else if (IndexPrefixesValue is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, IndexPrefixesValue, options);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NormsValue.HasValue)
			{
				writer.WritePropertyName("norms");
				writer.WriteBooleanValue(NormsValue.Value);
			}

			if (PositionIncrementGapValue.HasValue)
			{
				writer.WritePropertyName("position_increment_gap");
				writer.WriteNumberValue(PositionIncrementGapValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SearchAnalyzerValue))
			{
				writer.WritePropertyName("search_analyzer");
				writer.WriteStringValue(SearchAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
			{
				writer.WritePropertyName("search_quote_analyzer");
				writer.WriteStringValue(SearchQuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TermVectorValue is not null)
			{
				writer.WritePropertyName("term_vector");
				JsonSerializer.Serialize(writer, TermVectorValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("text");
			writer.WriteEndObject();
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? BuildFielddataFrequencyFilter()
		{
			if (FielddataFrequencyFilterValue is not null)
			{
				return FielddataFrequencyFilterValue;
			}

			if (FielddataFrequencyFilterDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter?> buildable)
			{
				return buildable.Build();
			}

			if (FielddataFrequencyFilterDescriptorAction is not null)
			{
				var descriptor = new IndexManagement.FielddataFrequencyFilterDescriptor(FielddataFrequencyFilterDescriptorAction);
				if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter?> buildableFromAction)
				{
					return buildableFromAction.Build();
				}
			}

			return null;
		}

		private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? BuildIndexPrefixes()
		{
			if (IndexPrefixesValue is not null)
			{
				return IndexPrefixesValue;
			}

			if (IndexPrefixesDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildable)
			{
				return buildable.Build();
			}

			if (IndexPrefixesDescriptorAction is not null)
			{
				var descriptor = new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction);
				if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildableFromAction)
				{
					return buildableFromAction.Build();
				}
			}

			return null;
		}

		TextProperty IBuildableDescriptor<TextProperty>.Build() => new()
		{ Analyzer = AnalyzerValue, Boost = BoostValue, CopyTo = CopyToValue, Dynamic = DynamicValue, EagerGlobalOrdinals = EagerGlobalOrdinalsValue, Fielddata = FielddataValue, FielddataFrequencyFilter = BuildFielddataFrequencyFilter(), Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = IndexOptionsValue, IndexPhrases = IndexPhrasesValue, IndexPrefixes = BuildIndexPrefixes(), LocalMetadata = LocalMetadataValue, Meta = MetaValue, Norms = NormsValue, PositionIncrementGap = PositionIncrementGapValue, Properties = PropertiesValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue };
	}

	public sealed partial class TextPropertyDescriptor : SerializableDescriptorBase<TextPropertyDescriptor>, IBuildableDescriptor<TextProperty>
	{
		internal TextPropertyDescriptor(Action<TextPropertyDescriptor> configure) => configure.Invoke(this);
		public TextPropertyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private double? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

		private bool? EagerGlobalOrdinalsValue { get; set; }

		private bool? FielddataValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? FielddataFrequencyFilterValue { get; set; }

		private IndexManagement.FielddataFrequencyFilterDescriptor FielddataFrequencyFilterDescriptor { get; set; }

		private Action<IndexManagement.FielddataFrequencyFilterDescriptor> FielddataFrequencyFilterDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

		private int? IgnoreAboveValue { get; set; }

		private bool? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptionsValue { get; set; }

		private bool? IndexPhrasesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixesValue { get; set; }

		private TextIndexPrefixesDescriptor IndexPrefixesDescriptor { get; set; }

		private Action<TextIndexPrefixesDescriptor> IndexPrefixesDescriptorAction { get; set; }

		private Dictionary<string, object>? LocalMetadataValue { get; set; }

		private Dictionary<string, string>? MetaValue { get; set; }

		private bool? NormsValue { get; set; }

		private int? PositionIncrementGapValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

		private string? SearchAnalyzerValue { get; set; }

		private string? SearchQuoteAnalyzerValue { get; set; }

		private string? SimilarityValue { get; set; }

		private bool? StoreValue { get; set; }

		private Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVectorValue { get; set; }

		public TextPropertyDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public TextPropertyDescriptor Boost(double? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public TextPropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
		{
			CopyToValue = copyTo;
			return Self;
		}

		public TextPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
		{
			DynamicValue = dynamic;
			return Self;
		}

		public TextPropertyDescriptor EagerGlobalOrdinals(bool? eagerGlobalOrdinals = true)
		{
			EagerGlobalOrdinalsValue = eagerGlobalOrdinals;
			return Self;
		}

		public TextPropertyDescriptor Fielddata(bool? fielddata = true)
		{
			FielddataValue = fielddata;
			return Self;
		}

		public TextPropertyDescriptor FielddataFrequencyFilter(Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? fielddataFrequencyFilter)
		{
			FielddataFrequencyFilterDescriptor = null;
			FielddataFrequencyFilterDescriptorAction = null;
			FielddataFrequencyFilterValue = fielddataFrequencyFilter;
			return Self;
		}

		public TextPropertyDescriptor FielddataFrequencyFilter(IndexManagement.FielddataFrequencyFilterDescriptor descriptor)
		{
			FielddataFrequencyFilterValue = null;
			FielddataFrequencyFilterDescriptorAction = null;
			FielddataFrequencyFilterDescriptor = descriptor;
			return Self;
		}

		public TextPropertyDescriptor FielddataFrequencyFilter(Action<IndexManagement.FielddataFrequencyFilterDescriptor> configure)
		{
			FielddataFrequencyFilterValue = null;
			FielddataFrequencyFilterDescriptor = null;
			FielddataFrequencyFilterDescriptorAction = configure;
			return Self;
		}

		public TextPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
		{
			FieldsValue = fields;
			return Self;
		}

		public TextPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			FieldsValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor IgnoreAbove(int? ignoreAbove)
		{
			IgnoreAboveValue = ignoreAbove;
			return Self;
		}

		public TextPropertyDescriptor Index(bool? index = true)
		{
			IndexValue = index;
			return Self;
		}

		public TextPropertyDescriptor IndexOptions(Elastic.Clients.Elasticsearch.Mapping.IndexOptions? indexOptions)
		{
			IndexOptionsValue = indexOptions;
			return Self;
		}

		public TextPropertyDescriptor IndexPhrases(bool? indexPhrases = true)
		{
			IndexPhrasesValue = indexPhrases;
			return Self;
		}

		public TextPropertyDescriptor IndexPrefixes(Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? indexPrefixes)
		{
			IndexPrefixesDescriptor = null;
			IndexPrefixesDescriptorAction = null;
			IndexPrefixesValue = indexPrefixes;
			return Self;
		}

		public TextPropertyDescriptor IndexPrefixes(TextIndexPrefixesDescriptor descriptor)
		{
			IndexPrefixesValue = null;
			IndexPrefixesDescriptorAction = null;
			IndexPrefixesDescriptor = descriptor;
			return Self;
		}

		public TextPropertyDescriptor IndexPrefixes(Action<TextIndexPrefixesDescriptor> configure)
		{
			IndexPrefixesValue = null;
			IndexPrefixesDescriptor = null;
			IndexPrefixesDescriptorAction = configure;
			return Self;
		}

		public TextPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public TextPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
			return Self;
		}

		public TextPropertyDescriptor Norms(bool? norms = true)
		{
			NormsValue = norms;
			return Self;
		}

		public TextPropertyDescriptor PositionIncrementGap(int? positionIncrementGap)
		{
			PositionIncrementGapValue = positionIncrementGap;
			return Self;
		}

		public TextPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
		{
			PropertiesValue = properties;
			return Self;
		}

		public TextPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
		{
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
		{
			var descriptor = new PropertiesDescriptor<TDocument>();
			configure?.Invoke(descriptor);
			PropertiesValue = descriptor.PromisedValue;
			return Self;
		}

		public TextPropertyDescriptor SearchAnalyzer(string? searchAnalyzer)
		{
			SearchAnalyzerValue = searchAnalyzer;
			return Self;
		}

		public TextPropertyDescriptor SearchQuoteAnalyzer(string? searchQuoteAnalyzer)
		{
			SearchQuoteAnalyzerValue = searchQuoteAnalyzer;
			return Self;
		}

		public TextPropertyDescriptor Similarity(string? similarity)
		{
			SimilarityValue = similarity;
			return Self;
		}

		public TextPropertyDescriptor Store(bool? store = true)
		{
			StoreValue = store;
			return Self;
		}

		public TextPropertyDescriptor TermVector(Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? termVector)
		{
			TermVectorValue = termVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (CopyToValue is not null)
			{
				writer.WritePropertyName("copy_to");
				JsonSerializer.Serialize(writer, CopyToValue, options);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (EagerGlobalOrdinalsValue.HasValue)
			{
				writer.WritePropertyName("eager_global_ordinals");
				writer.WriteBooleanValue(EagerGlobalOrdinalsValue.Value);
			}

			if (FielddataValue.HasValue)
			{
				writer.WritePropertyName("fielddata");
				writer.WriteBooleanValue(FielddataValue.Value);
			}

			if (FielddataFrequencyFilterDescriptor is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, FielddataFrequencyFilterDescriptor, options);
			}
			else if (FielddataFrequencyFilterDescriptorAction is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, new IndexManagement.FielddataFrequencyFilterDescriptor(FielddataFrequencyFilterDescriptorAction), options);
			}
			else if (FielddataFrequencyFilterValue is not null)
			{
				writer.WritePropertyName("fielddata_frequency_filter");
				JsonSerializer.Serialize(writer, FielddataFrequencyFilterValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IgnoreAboveValue.HasValue)
			{
				writer.WritePropertyName("ignore_above");
				writer.WriteNumberValue(IgnoreAboveValue.Value);
			}

			if (IndexValue.HasValue)
			{
				writer.WritePropertyName("index");
				writer.WriteBooleanValue(IndexValue.Value);
			}

			if (IndexOptionsValue is not null)
			{
				writer.WritePropertyName("index_options");
				JsonSerializer.Serialize(writer, IndexOptionsValue, options);
			}

			if (IndexPhrasesValue.HasValue)
			{
				writer.WritePropertyName("index_phrases");
				writer.WriteBooleanValue(IndexPhrasesValue.Value);
			}

			if (IndexPrefixesDescriptor is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, IndexPrefixesDescriptor, options);
			}
			else if (IndexPrefixesDescriptorAction is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction), options);
			}
			else if (IndexPrefixesValue is not null)
			{
				writer.WritePropertyName("index_prefixes");
				JsonSerializer.Serialize(writer, IndexPrefixesValue, options);
			}

			if (LocalMetadataValue is not null)
			{
				writer.WritePropertyName("local_metadata");
				JsonSerializer.Serialize(writer, LocalMetadataValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NormsValue.HasValue)
			{
				writer.WritePropertyName("norms");
				writer.WriteBooleanValue(NormsValue.Value);
			}

			if (PositionIncrementGapValue.HasValue)
			{
				writer.WritePropertyName("position_increment_gap");
				writer.WriteNumberValue(PositionIncrementGapValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (!string.IsNullOrEmpty(SearchAnalyzerValue))
			{
				writer.WritePropertyName("search_analyzer");
				writer.WriteStringValue(SearchAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SearchQuoteAnalyzerValue))
			{
				writer.WritePropertyName("search_quote_analyzer");
				writer.WriteStringValue(SearchQuoteAnalyzerValue);
			}

			if (!string.IsNullOrEmpty(SimilarityValue))
			{
				writer.WritePropertyName("similarity");
				writer.WriteStringValue(SimilarityValue);
			}

			if (StoreValue.HasValue)
			{
				writer.WritePropertyName("store");
				writer.WriteBooleanValue(StoreValue.Value);
			}

			if (TermVectorValue is not null)
			{
				writer.WritePropertyName("term_vector");
				JsonSerializer.Serialize(writer, TermVectorValue, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("text");
			writer.WriteEndObject();
		}

		private Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? BuildFielddataFrequencyFilter()
		{
			if (FielddataFrequencyFilterValue is not null)
			{
				return FielddataFrequencyFilterValue;
			}

			if (FielddataFrequencyFilterDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter?> buildable)
			{
				return buildable.Build();
			}

			if (FielddataFrequencyFilterDescriptorAction is not null)
			{
				var descriptor = new IndexManagement.FielddataFrequencyFilterDescriptor(FielddataFrequencyFilterDescriptorAction);
				if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter?> buildableFromAction)
				{
					return buildableFromAction.Build();
				}
			}

			return null;
		}

		private Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? BuildIndexPrefixes()
		{
			if (IndexPrefixesValue is not null)
			{
				return IndexPrefixesValue;
			}

			if (IndexPrefixesDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildable)
			{
				return buildable.Build();
			}

			if (IndexPrefixesDescriptorAction is not null)
			{
				var descriptor = new TextIndexPrefixesDescriptor(IndexPrefixesDescriptorAction);
				if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes?> buildableFromAction)
				{
					return buildableFromAction.Build();
				}
			}

			return null;
		}

		TextProperty IBuildableDescriptor<TextProperty>.Build() => new()
		{ Analyzer = AnalyzerValue, Boost = BoostValue, CopyTo = CopyToValue, Dynamic = DynamicValue, EagerGlobalOrdinals = EagerGlobalOrdinalsValue, Fielddata = FielddataValue, FielddataFrequencyFilter = BuildFielddataFrequencyFilter(), Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = IndexOptionsValue, IndexPhrases = IndexPhrasesValue, IndexPrefixes = BuildIndexPrefixes(), LocalMetadata = LocalMetadataValue, Meta = MetaValue, Norms = NormsValue, PositionIncrementGap = PositionIncrementGapValue, Properties = PropertiesValue, SearchAnalyzer = SearchAnalyzerValue, SearchQuoteAnalyzer = SearchQuoteAnalyzerValue, Similarity = SimilarityValue, Store = StoreValue, TermVector = TermVectorValue };
	}
}
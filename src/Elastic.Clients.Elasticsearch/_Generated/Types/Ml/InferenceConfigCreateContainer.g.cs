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
namespace Elastic.Clients.Elasticsearch.Ml;
[JsonConverter(typeof(InferenceConfigCreateContainerConverter))]
public sealed partial class InferenceConfigCreateContainer
{
	internal InferenceConfigCreateContainer(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }

	internal string VariantName { get; }

	public static InferenceConfigCreateContainer Classification(Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions classificationInferenceOptions) => new InferenceConfigCreateContainer("classification", classificationInferenceOptions);
	public static InferenceConfigCreateContainer FillMask(Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions fillMaskInferenceOptions) => new InferenceConfigCreateContainer("fill_mask", fillMaskInferenceOptions);
	public static InferenceConfigCreateContainer Ner(Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions nerInferenceOptions) => new InferenceConfigCreateContainer("ner", nerInferenceOptions);
	public static InferenceConfigCreateContainer PassThrough(Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions passThroughInferenceOptions) => new InferenceConfigCreateContainer("pass_through", passThroughInferenceOptions);
	public static InferenceConfigCreateContainer QuestionAnswering(Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions questionAnsweringInferenceOptions) => new InferenceConfigCreateContainer("question_answering", questionAnsweringInferenceOptions);
	public static InferenceConfigCreateContainer Regression(Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions regressionInferenceOptions) => new InferenceConfigCreateContainer("regression", regressionInferenceOptions);
	public static InferenceConfigCreateContainer TextClassification(Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions textClassificationInferenceOptions) => new InferenceConfigCreateContainer("text_classification", textClassificationInferenceOptions);
	public static InferenceConfigCreateContainer TextEmbedding(Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions textEmbeddingInferenceOptions) => new InferenceConfigCreateContainer("text_embedding", textEmbeddingInferenceOptions);
	public static InferenceConfigCreateContainer ZeroShotClassification(Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions zeroShotClassificationInferenceOptions) => new InferenceConfigCreateContainer("zero_shot_classification", zeroShotClassificationInferenceOptions);
}

internal sealed class InferenceConfigCreateContainerConverter : JsonConverter<InferenceConfigCreateContainer>
{
	public override InferenceConfigCreateContainer Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		if (reader.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException("Expected a property name token representing the variant held within this container.");
		}

		var propertyName = reader.GetString();
		reader.Read();
		if (propertyName == "classification")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "fill_mask")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "ner")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "pass_through")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "question_answering")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "regression")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "text_classification")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "text_embedding")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		if (propertyName == "zero_shot_classification")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions?>(ref reader, options);
			reader.Read();
			return new InferenceConfigCreateContainer(propertyName, variant);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, InferenceConfigCreateContainer value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName(value.VariantName);
		switch (value.VariantName)
		{
			case "classification":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.ClassificationInferenceOptions)value.Variant, options);
				break;
			case "fill_mask":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.FillMaskInferenceOptions)value.Variant, options);
				break;
			case "ner":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.NerInferenceOptions)value.Variant, options);
				break;
			case "pass_through":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.PassThroughInferenceOptions)value.Variant, options);
				break;
			case "question_answering":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.QuestionAnsweringInferenceOptions)value.Variant, options);
				break;
			case "regression":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.RegressionInferenceOptions)value.Variant, options);
				break;
			case "text_classification":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.TextClassificationInferenceOptions)value.Variant, options);
				break;
			case "text_embedding":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.TextEmbeddingInferenceOptions)value.Variant, options);
				break;
			case "zero_shot_classification":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions>(writer, (Elastic.Clients.Elasticsearch.Ml.ZeroShotClassificationInferenceOptions)value.Variant, options);
				break;
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceConfigCreateContainerDescriptor<TDocument> : SerializableDescriptor<InferenceConfigCreateContainerDescriptor<TDocument>>
{
	internal InferenceConfigCreateContainerDescriptor(Action<InferenceConfigCreateContainerDescriptor<TDocument>> configure) => configure.Invoke(this);
	public InferenceConfigCreateContainerDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private InferenceConfigCreateContainerDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigCreateContainerDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigCreateContainerDescriptor<TDocument> Classification(ClassificationInferenceOptions variant) => Set(variant, "classification");
	public InferenceConfigCreateContainerDescriptor<TDocument> Classification(Action<ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigCreateContainerDescriptor<TDocument> FillMask(FillMaskInferenceOptions variant) => Set(variant, "fill_mask");
	public InferenceConfigCreateContainerDescriptor<TDocument> FillMask(Action<FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
	public InferenceConfigCreateContainerDescriptor<TDocument> Ner(NerInferenceOptions variant) => Set(variant, "ner");
	public InferenceConfigCreateContainerDescriptor<TDocument> Ner(Action<NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
	public InferenceConfigCreateContainerDescriptor<TDocument> PassThrough(PassThroughInferenceOptions variant) => Set(variant, "pass_through");
	public InferenceConfigCreateContainerDescriptor<TDocument> PassThrough(Action<PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
	public InferenceConfigCreateContainerDescriptor<TDocument> QuestionAnswering(QuestionAnsweringInferenceOptions variant) => Set(variant, "question_answering");
	public InferenceConfigCreateContainerDescriptor<TDocument> QuestionAnswering(Action<QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
	public InferenceConfigCreateContainerDescriptor<TDocument> Regression(RegressionInferenceOptions variant) => Set(variant, "regression");
	public InferenceConfigCreateContainerDescriptor<TDocument> Regression(Action<RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");
	public InferenceConfigCreateContainerDescriptor<TDocument> TextClassification(TextClassificationInferenceOptions variant) => Set(variant, "text_classification");
	public InferenceConfigCreateContainerDescriptor<TDocument> TextClassification(Action<TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
	public InferenceConfigCreateContainerDescriptor<TDocument> TextEmbedding(TextEmbeddingInferenceOptions variant) => Set(variant, "text_embedding");
	public InferenceConfigCreateContainerDescriptor<TDocument> TextEmbedding(Action<TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
	public InferenceConfigCreateContainerDescriptor<TDocument> ZeroShotClassification(ZeroShotClassificationInferenceOptions variant) => Set(variant, "zero_shot_classification");
	public InferenceConfigCreateContainerDescriptor<TDocument> ZeroShotClassification(Action<ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
		}
		else
		{
			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceConfigCreateContainerDescriptor : SerializableDescriptor<InferenceConfigCreateContainerDescriptor>
{
	internal InferenceConfigCreateContainerDescriptor(Action<InferenceConfigCreateContainerDescriptor> configure) => configure.Invoke(this);
	public InferenceConfigCreateContainerDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private InferenceConfigCreateContainerDescriptor Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private InferenceConfigCreateContainerDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public InferenceConfigCreateContainerDescriptor Classification(ClassificationInferenceOptions variant) => Set(variant, "classification");
	public InferenceConfigCreateContainerDescriptor Classification(Action<ClassificationInferenceOptionsDescriptor> configure) => Set(configure, "classification");
	public InferenceConfigCreateContainerDescriptor FillMask(FillMaskInferenceOptions variant) => Set(variant, "fill_mask");
	public InferenceConfigCreateContainerDescriptor FillMask(Action<FillMaskInferenceOptionsDescriptor> configure) => Set(configure, "fill_mask");
	public InferenceConfigCreateContainerDescriptor Ner(NerInferenceOptions variant) => Set(variant, "ner");
	public InferenceConfigCreateContainerDescriptor Ner(Action<NerInferenceOptionsDescriptor> configure) => Set(configure, "ner");
	public InferenceConfigCreateContainerDescriptor PassThrough(PassThroughInferenceOptions variant) => Set(variant, "pass_through");
	public InferenceConfigCreateContainerDescriptor PassThrough(Action<PassThroughInferenceOptionsDescriptor> configure) => Set(configure, "pass_through");
	public InferenceConfigCreateContainerDescriptor QuestionAnswering(QuestionAnsweringInferenceOptions variant) => Set(variant, "question_answering");
	public InferenceConfigCreateContainerDescriptor QuestionAnswering(Action<QuestionAnsweringInferenceOptionsDescriptor> configure) => Set(configure, "question_answering");
	public InferenceConfigCreateContainerDescriptor Regression(RegressionInferenceOptions variant) => Set(variant, "regression");
	public InferenceConfigCreateContainerDescriptor Regression(Action<RegressionInferenceOptionsDescriptor> configure) => Set(configure, "regression");
	public InferenceConfigCreateContainerDescriptor Regression<TDocument>(Action<RegressionInferenceOptionsDescriptor<TDocument>> configure) => Set(configure, "regression");
	public InferenceConfigCreateContainerDescriptor TextClassification(TextClassificationInferenceOptions variant) => Set(variant, "text_classification");
	public InferenceConfigCreateContainerDescriptor TextClassification(Action<TextClassificationInferenceOptionsDescriptor> configure) => Set(configure, "text_classification");
	public InferenceConfigCreateContainerDescriptor TextEmbedding(TextEmbeddingInferenceOptions variant) => Set(variant, "text_embedding");
	public InferenceConfigCreateContainerDescriptor TextEmbedding(Action<TextEmbeddingInferenceOptionsDescriptor> configure) => Set(configure, "text_embedding");
	public InferenceConfigCreateContainerDescriptor ZeroShotClassification(ZeroShotClassificationInferenceOptions variant) => Set(variant, "zero_shot_classification");
	public InferenceConfigCreateContainerDescriptor ZeroShotClassification(Action<ZeroShotClassificationInferenceOptionsDescriptor> configure) => Set(configure, "zero_shot_classification");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
		}
		else
		{
			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}
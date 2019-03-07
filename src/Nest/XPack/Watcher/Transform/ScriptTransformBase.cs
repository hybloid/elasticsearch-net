﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nest
{
	[JsonObject]
	[JsonConverter(typeof(ScriptTransformJsonConverter))]
	public interface IScriptTransform : ITransform
	{
		[JsonProperty("lang")]
		string Lang { get; set; }

		[JsonProperty("params")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter<string, object>))]
		Dictionary<string, object> Params { get; set; }
	}

	public abstract class ScriptTransformBase : TransformBase, IScriptTransform
	{
		public string Lang { get; set; }
		public Dictionary<string, object> Params { get; set; }

		internal override void WrapInContainer(ITransformContainer container) => container.Script = this;
	}

	public abstract class ScriptTransformDescriptorBase<TDescriptor, TInterface> : DescriptorBase<TDescriptor, TInterface>, IScriptTransform
		where TDescriptor : ScriptTransformDescriptorBase<TDescriptor, TInterface>, TInterface, IScriptTransform
		where TInterface : class, IScriptTransform
	{
		string IScriptTransform.Lang { get; set; }
		Dictionary<string, object> IScriptTransform.Params { get; set; }

		public TDescriptor Params(Dictionary<string, object> scriptParams) => Assign(a => a.Params = scriptParams);

		public TDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> paramsSelector) =>
			Assign(a => a.Params = paramsSelector?.Invoke(new FluentDictionary<string, object>()));

		public TDescriptor Lang(string lang) => Assign(a => a.Lang = lang);
	}

	public class ScriptTransformDescriptor : DescriptorBase<ScriptTransformDescriptor, IDescriptor>
	{
		[Obsolete("Removed in NEST 6.x.")]
		public FileScriptTransformDescriptor File(string file) => new FileScriptTransformDescriptor(file);

		public IndexedScriptTransformDescriptor Indexed(string id) => new IndexedScriptTransformDescriptor(id);

		public InlineScriptTransformDescriptor Inline(string script) => new InlineScriptTransformDescriptor(script);
	}

	internal class ScriptTransformJsonConverter : JsonConverter
	{
		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var o = JObject.Load(reader);
			var dict = o.Properties().ToDictionary(p => p.Name, p => p.Value);
			if (!dict.HasAny()) return null;

			IScriptTransform scriptTransform = null;
			if (dict.TryGetValue("inline", out var inlineToken))
			{
				var inline = inlineToken.ToString();
				scriptTransform = new InlineScriptTransform(inline);
			}
			else if (dict.TryGetValue("file", out var fileToken))
			{
				var file = fileToken.ToString();
				scriptTransform = new FileScriptTransform(file);
			}
			else if (dict.TryGetValue("id", out var idToken))
			{
				var id = idToken.ToString();
				scriptTransform = new IndexedScriptTransform(id);
			}

			if (scriptTransform == null) return null;

			if (dict.TryGetValue("lang", out JToken langToken))
				scriptTransform.Lang = langToken.ToString();
			if (dict.TryGetValue("params", out JToken paramsToken))
				scriptTransform.Params = paramsToken.ToObject<Dictionary<string, object>>();

			return scriptTransform;
		}

		public override bool CanConvert(Type objectType) => true;
	}
}

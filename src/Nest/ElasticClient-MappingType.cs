﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Nest.Resolvers.Writers;

namespace Nest
{
	public partial class ElasticClient
	{
		/// <summary>
		/// Deletes the mapping for the inferred type name of T under the default index
		/// </summary>
		public IndicesResponse DeleteMapping<T>() where T : class
		{
			string type = this.InferTypeName<T>();
			return this.DeleteMapping<T>(this.Settings.DefaultIndex, type);
		}
		/// <summary>
		/// Deletes the mapping for the inferred type name of T under the specified index
		/// </summary>
		public IndicesResponse DeleteMapping<T>(string index) where T : class
		{
			string type = this.InferTypeName<T>();
			return this.DeleteMapping<T>(index, type);
		}
		/// <summary>
		/// Deletes the mapping for the specified type name under the specified index
		/// </summary>
		public IndicesResponse DeleteMapping<T>(string index, string type) where T : class
		{
			string path = this.CreatePath(index, type);
			ConnectionStatus status = this.Connection.DeleteSync(path);

			var response = new IndicesResponse();
			try
			{
				response = JsonConvert.DeserializeObject<IndicesResponse>(status.Result);
			}
			catch
			{
			}

			response.ConnectionStatus = status;
			return response;
		}
		/// <summary>
		/// <para>Automatically map an object based on its attributes, this will also explicitly map strings to strings, datetimes to dates etc even 
		/// if they are not marked with any attributes.</para>
		/// <para>
		/// Type name is the inferred type name for T under the default index
		/// </para>
		/// </summary>
		public IndicesResponse Map<T>() where T : class
		{
			string type = this.InferTypeName<T>();
			return this.Map<T>(this.Settings.DefaultIndex, type);
		}
		/// <summary>
		/// <para>Automatically map an object based on its attributes, this will also explicitly map strings to strings, datetimes to dates etc even 
		/// if they are not marked with any attributes.</para>
		/// <para>
		/// Type name is the inferred type name for T under the specified index
		/// </para>
		/// </summary>
		public IndicesResponse Map<T>(string index) where T : class
		{
			string type = this.InferTypeName<T>();
			return this.Map<T>(index, type);
		}
		/// <summary>
		/// <para>Automatically map an object based on its attributes, this will also explicitly map strings to strings, datetimes to dates etc even 
		/// if they are not marked with any attributes.</para>
		/// <para>
		/// Type name is the specified type name under the specified index
		/// </para>
		/// </summary>
		public IndicesResponse Map<T>(string index, string type) where T : class
		{
			string path = this.CreatePath(index, type) + "_mapping";
			string map = this.CreateMapFor<T>(type);

			ConnectionStatus status = this.Connection.PutSync(path, map);

			var response = new IndicesResponse();
			try
			{
				response = JsonConvert.DeserializeObject<IndicesResponse>(status.Result);
				response.IsValid = true;
			}
			catch
			{
			}

			response.ConnectionStatus = status;
			return response;
		}
		/// <summary>
		/// Verbosely and explicitly map an object using a TypeMapping object, this gives you exact control over the mapping. Index is the inferred default index
		/// </summary>
		public IndicesResponse Map(TypeMapping typeMapping)
		{
			return this.Map(typeMapping, this.Settings.DefaultIndex);
		}
		/// <summary>
		/// Verbosely and explicitly map an object using a TypeMapping object, this gives you exact control over the mapping.
		/// </summary>
		public IndicesResponse Map(TypeMapping typeMapping, string index)
		{
			string path = this.CreatePath(index, typeMapping.Name) + "_mapping";
			var mapping = new Dictionary<string, TypeMapping>();
			mapping.Add(typeMapping.Name, typeMapping);

			string map = JsonConvert.SerializeObject(mapping, Formatting.None, SerializationSettings);

			ConnectionStatus status = this.Connection.PutSync(path, map);

			var r = this.ToParsedResponse<IndicesResponse>(status);
			return r;
		}
		/// <summary>
		/// Get the current mapping for T at the default index
		/// </summary>
		public TypeMapping GetMapping<T>() where T : class
		{
			return this.GetMapping<T>(this.Settings.DefaultIndex);
		}
		/// <summary>
		/// Get the current mapping for T at the specified index
		/// </summary>
		public TypeMapping GetMapping<T>(string index) where T : class
		{
			string type = this.InferTypeName<T>();
			return this.GetMapping(index, type);
		}
		/// <summary>
		/// Get the current mapping for type at the specified index
		/// </summary>
		public TypeMapping GetMapping(string index, string type)
		{
			string path = this.CreatePath(index, type) + "_mapping";

			ConnectionStatus status = this.Connection.GetSync(path);

			var mappings = JsonConvert.DeserializeObject<IDictionary<string, TypeMapping>>(status.Result, SerializationSettings);

			if (status.Success)
			{
				var mapping = mappings.First();
				mapping.Value.Name = mapping.Key;

				return mapping.Value;
			}

			return null;
		}

		private string CreateMapFor<T>(string type) where T : class
		{
			var writer = new TypeMappingWriter<T>(type, PropertyNameResolver);

			return writer.MapFromAttributes();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch.IndexManagement.Analyze
{
	public partial class TextToAnalyze
	{
		// This is temporary
		public TextToAnalyze(IEnumerable<string> toAnalyze) => _stringList.AddRange(toAnalyze);

		public string GetString(ITransportConfiguration settings) => throw new NotImplementedException();
	}
}

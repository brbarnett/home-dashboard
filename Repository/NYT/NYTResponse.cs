using System;
using System.Collections.Generic;

namespace Repository.NYT
{
	public class Multimedia
	{
		public string url { get; set; }
		public string format { get; set; }
		public int height { get; set; }
		public int width { get; set; }
		public string type { get; set; }
		public string subtype { get; set; }
		public string caption { get; set; }
		public string copyright { get; set; }
	}

	public class Result
	{
		public string section { get; set; }
		public string subsection { get; set; }
		public string title { get; set; }
		public string Abstract { get; set; }
		public string url { get; set; }
		public string byline { get; set; }
		public string item_type { get; set; }
		public DateTime updated_date { get; set; }
		public DateTime created_date { get; set; }
		public DateTime published_date { get; set; }
		public string material_type_facet { get; set; }
		public string kicker { get; set; }
		public IList<string> des_facet { get; set; }
		public IList<string> org_facet { get; set; }
		public IList<string> per_facet { get; set; }
		public IList<string> geo_facet { get; set; }
		public IList<Multimedia> multimedia { get; set; }
		public string short_url { get; set; }
	}

	public class NYTResponse
	{
		public string status { get; set; }
		public string copyright { get; set; }
		public string section { get; set; }
		public DateTime last_updated { get; set; }
		public int num_results { get; set; }
		public IList<Result> results { get; set; }
	}
}

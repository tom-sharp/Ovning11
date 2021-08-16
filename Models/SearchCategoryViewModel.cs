using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ovning11.Models
{
	public class SearchCategoryViewModel
	{
		public string CategorySearch { get; set; }
		public List<Category> Categories { get; set; }
		public List<Product> SearchResult { get; set; }
	}
}

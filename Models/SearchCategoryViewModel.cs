using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ovning11.Models
{
	public class SearchCategoryViewModel
	{
		public SearchCategoryViewModel(string category, List<Product> result)
		{
			this.CategorySearch = category;
			this.SearchResult = result;
		}
		public string CategorySearch { get; set; }
		public List<Product> SearchResult { get; set; }
	}
}

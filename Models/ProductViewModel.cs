using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ovning11.Models
{
	public class ProductViewModel
	{
		public ProductViewModel(string name, int price, int count)
		{
			this.Name = name;
			this.Price = price;
			this.Count = count;
			this.InventoryValue = this.Count * this.Price;
		}
		public string Name { get; set; }
		public int Price { get; set; }
		public int Count { get; set; }
		public int InventoryValue { get; set; }

	}
}

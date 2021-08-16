using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ovning11.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Range(0, 1000000)]
		public int Price { get; set; }

		[DataType(DataType.Date)]
		public DateTime Orderdate { get; set; }

		[Required]
		public string Category { get; set; }

		[MinLength(1)]
		public string Shelf { get; set; }
		public int Count { get; set; }
		public string Description { get; set; }
	}
}

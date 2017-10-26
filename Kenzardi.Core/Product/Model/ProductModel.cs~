using System;
using System.ComponentModel.DataAnnotations;

namespace Product.Model
{
	public class ProductModel
	{

		public Guid UniqueID { get; set; }

		[Required]
		public String Name { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime ModifiedDate { get; set; }

		[Range(0, 999)]
		public double Weight { get; set; }

	}
}

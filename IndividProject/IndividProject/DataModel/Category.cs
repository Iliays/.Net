using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.DataModel
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		[Required]
		public string Name { get; set; }
		public string Discription { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}

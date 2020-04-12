using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.DataModel
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }

		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category Category { get; set; }

		[ForeignKey("Client")]
		public int ClientId { get; set; }
		public Client Client { get; set; }

		[Required]
		public string DiscriptionOrder { get; set; }

		[Column(TypeName = "date")]
		public DateTime DateGive { get; set; }

		[Column(TypeName = "date")]
		public DateTime DateTake { get; set; }
		public decimal Summa { get; set; }
		public decimal Comission { get; set; }
	}
}

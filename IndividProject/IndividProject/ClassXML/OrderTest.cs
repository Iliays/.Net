using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.ClassXML
{
	public class OrderTest
	{
		public int CategoryId { get; set; }
		public int ClientId { get; set; }
		public string DiscriptionOrder { get; set; }
		public DateTime DateGive { get; set; }
		public DateTime DateTake { get; set; }
		public decimal Summa { get; set; }
		public decimal Comission { get; set; }

		public OrderTest(int CategoryId, int ClientId, string DiscriptionOrder, DateTime DateGive, DateTime DateTake, decimal Summa, decimal Comission)
		{
			this.CategoryId = CategoryId;
			this.ClientId = ClientId;
			this.DiscriptionOrder = DiscriptionOrder;
			this.DateGive = DateGive;
			this.DateTake = DateTake;
			this.Summa = Summa;
			this.Comission = Comission;
		}
	}
}

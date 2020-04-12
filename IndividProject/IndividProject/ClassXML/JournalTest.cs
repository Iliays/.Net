using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.ClassXML
{
	public class JournalTest
	{
		public int Order { get; set; }
		public decimal Summa { get; set; }
		public string Name { get; set; }
		public int Number { get; set; }
		public int Seria { get; set; }

		public JournalTest(int Order, decimal Summa, string Name, int Number, int Seria)
		{
			this.Order = Order;
			this.Summa = Summa;
			this.Name = Name;
			this.Number = Number;
			this.Seria = Seria;
		}
	}
}

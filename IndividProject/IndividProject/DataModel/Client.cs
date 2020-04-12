using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.DataModel
{
	public class Client
	{
		[Key]
		public int ClientId { get; set; }

		[Required]
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronimic { get; set; }
		public int Number { get; set; }
		public int Seria { get; set; }

		[Column(TypeName = "date")]
		public DateTime DatePas { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
	}
}

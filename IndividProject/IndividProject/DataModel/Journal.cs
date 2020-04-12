using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.DataModel
{
	public class Journal
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int Order { get; set; }
		public decimal Summa { get; set; }
	}
}

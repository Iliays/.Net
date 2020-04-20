﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenLab.Models
{
	public class Position
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int Salary { get; set; }

		public virtual ICollection<History> Histories { get; set; }
	}
}
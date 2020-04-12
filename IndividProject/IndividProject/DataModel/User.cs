﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividProject.DataModel
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Login { get; set; }
		public string Password { get; set; }
	}
}
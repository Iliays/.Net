﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba12.Models
{
	public class LoginModel
	{
		public string login { get; set; }
		public string password { get; set; }
	}

	public class RegisterModel
	{
		public string login { get; set; }
		public string password { get; set; }
		public string surname { get; set; }
		public string name { get; set; }
		public string patronimyc { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba12.Models
{
	public class Message
	{
        public int id { get; set; }

        public int from { get; set; }

        public int to { get; set; }

        public string header { get; set; }

        public string text { get; set; }

        public DateTime date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElevenLab.Models
{
	public class History
	{
        [Key]
        public int Id { get; set; }

        [ForeignKey("Worker")]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        public int WageRate { get; set; }
        public string Status { get; set; }
        public string WhyDismissal { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfEmployment { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfDismissal { get; set; }
        public string OneMonthSalary { get; set; }
        public int YearSalary { get; set; }
    }
}
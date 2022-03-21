using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_CRUD_in_ASP.NET_Entity_Framework_Core.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Minimum amount = 0.01")]
        [Required]
        public double Amount { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Family
    {
        public string FamilyID { get; set; }

        [Required]
        [Display(Name = "Apellido paterno")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Apellido materno")]
        public string MLastName { get; set; }

        ICollection<Person> Person { get; set; }
    }
}
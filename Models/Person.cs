using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Models
{
    public class Person
    {
        [Display(Name ="Id")]
        public string PersonID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Display(Name = "Edad")]
        public int Age { get; set; }
        
        public string FamilyID { get; set; }

        Family Family { get; set; }

        public IEnumerable<SelectListItem> Items { get; set; }
    }
}
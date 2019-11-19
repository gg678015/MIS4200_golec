using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        [Required(ErrorMessage = "Employee First Name Required")]
        [StringLength(20)]
        [Display(Name = "Employee First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Employee Last Name Required")]
        [StringLength(20)]
        [Display(Name = "Employee Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Employee Email Required")]
        [StringLength(30)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Zip Code")]
        public int zipCode { get; set; }


        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [Display(Name = "Full Name")]

        public ICollection<Departments> Departments { get; set; }

    }
}
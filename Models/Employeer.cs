using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Employeer
    {
        public int employeerId { get; set; }

        [Required(ErrorMessage = "Employeer Last Name Required")]
        [StringLength(20)]
        [Display(Name = "Employeer Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Employeer First Name Required")]
        [StringLength(20)]
        [Display(Name = "Employeer First Name")]
        public string firstName  { get; set; }


        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        [Display(Name = "Full Name")]

        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<Departments> Departments { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
    }
}
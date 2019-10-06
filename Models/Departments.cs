using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Departments
    {
        public int departmentsID { get; set; }

        // the next two properties link the orderDetail to the Order
        public int employeerId { get; set; }
        [Display (Name = "Employeer Name")]
        public virtual Employeer Employeer { get; set; }
        // the next two properties link the orderDetail to the Product
        public int employeeId { get; set; }
        [Display(Name = "Employee Name")]
        public virtual Employee Employee { get; set; }

        //ViewBag.ID = new SelectList(db.UserDetails, "ID", "fullName");
    }
}
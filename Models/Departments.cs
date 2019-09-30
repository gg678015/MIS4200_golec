using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Departments
    {
        public int departmentsID { get; set; }

        // the next two properties link the orderDetail to the Order
        public int employeerId { get; set; }
        public virtual Employeer Employeer { get; set; }
        // the next two properties link the orderDetail to the Product
        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
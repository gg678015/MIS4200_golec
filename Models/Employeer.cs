using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Employeer
    {
        public int employeerId { get; set; }
        public string lastName { get; set; }
        public string firstName  { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<Departments> Departments { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int employeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
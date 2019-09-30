using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_golec.Models
{
    public class Employee
    {
        public int employeeId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int zipCode { get; set; }

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }

        public ICollection<Departments> Departments { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage="This Field is Required")]
        public string Name { get; set; }
        public string Position { get; set; }
       
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Only Numeric Value is Required")]
        [DataType(DataType.Currency)]
        public Nullable<int> Salary { get; set; }
        public Nullable<double>Itex { get; set; }
        public Nullable<double>EI { get; set; }
        public Nullable<double>CPP { get; set; }
        public Nullable<int> Additions { get; set; }



    }
}
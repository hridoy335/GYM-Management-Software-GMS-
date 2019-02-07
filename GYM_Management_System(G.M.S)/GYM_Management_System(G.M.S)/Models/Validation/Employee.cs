using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM_Management_System_G.M.S_.Models
{
    [MetadataType(typeof(MetadataEmployee))]
    public partial class Employee
    {

    }

    public class MetadataEmployee
    {
        [Required(ErrorMessage = "Client Name Required")]
        [Display(Name = "Employee Name :")]
        public string EmployeeName { get; set; }

        [Required]
        [Display(Name = "Designation :")]
        public int DesignationId { get; set; }
        [Required]
        [Display(Name = "Employee ID :")]
        public int Employee_ID { get; set; }

        [Display(Name = "Contact :")]
        [Required]
        public string Employee_Contact { get; set; }
        [Required]
        [Display(Name = "E-mail :")]
        public string Employee_Mail { get; set; }
        [Required]
        [Display(Name = "Address :")]
        public string Employee_Address { get; set; }
        [Required]
        [Display(Name = "Employee Username :")]
        public string Employe_UserName { get; set; }
        [Required]
        [Display(Name = "Employee Password :")]
        public string Employee_Password { get; set; }
    }


}
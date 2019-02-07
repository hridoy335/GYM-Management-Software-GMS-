using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM_Management_System_G.M.S_.Models
{
    [MetadataType(typeof(MetadataDesignation))]
    public partial class Designation
    {

    }
    public class MetadataDesignation
    {
        [Required]
        [Display(Name ="Designation")]
        public string DesignationName { get; set; }
    }
}
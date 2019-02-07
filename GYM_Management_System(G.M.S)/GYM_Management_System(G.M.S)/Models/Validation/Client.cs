using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYM_Management_System_G.M.S_.Models 
{
    [MetadataType(typeof(MetadataClient))]
    public partial class Client
    {
    }

    public class MetadataClient
    {
        [Required(ErrorMessage ="Client Name Required")]
        [Display(Name ="Client Name :")]
        public string ClietName { get; set; }

        [Required(ErrorMessage = "Client ID Required")]
        [Display(Name ="Client ID :")]
        public int ClientIdNumber { get; set; }

        [Required(ErrorMessage = "Contact Number Required")]
        [Display(Name ="Contact Number :")]
        public string ClientContact { get; set; }

        [Required(ErrorMessage = "Client Name Required")]
        [Display(Name ="E_mail :")]
        [DataType(DataType.EmailAddress)]
        public string ClientMail { get; set; }

        [Required(ErrorMessage = "Client Address Required")]
        [Display(Name = "Address :")]
        public string ClientAddress { get; set; }

        [Required]
        [Display(Name = "Start Date :")]
        public System.DateTime ClientGymStart { get; set; }

        [Required(ErrorMessage = "UserName Required")]
        [Display(Name = "User Name :")]
        public string ClientUserName { get; set; }

        [Required]
        [Display(Name = "Passwoed :")]
        public string ClientPassword { get; set; }


        [Required(ErrorMessage = "Password Required")]
        [Display(Name = "Admition Fee :")]
        public string ClientAdmitionfee { get; set; }
   
    }
}
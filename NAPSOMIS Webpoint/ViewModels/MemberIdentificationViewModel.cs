using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberIdentificationViewModel
        {
        public string SSNo { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Othername { get; set; }

        }
    }
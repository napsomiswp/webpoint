using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class MemberMasterFileSearchViewModel
        {
        [Display(Name = "S.S. Number")]
        public string fssno { get; set; }

         [Display(Name = "Reference Number")]
        public string fref_no { get; set; }

         [Display(Name = "Surname")]
        public string fsurname { get; set; }

         [Display(Name = "Other Name(s)")]
        public string fothername { get; set; }

         [Display(Name = "First Name")]
        public string firstname { get; set; }

         [Display(Name = "Date of Birth")]
        public DateTime? dateofbirth { get; set; }

         [Display(Name = "Sex")]
        public string sex { get; set; }

         [Display(Name = "Province")]
        public string province { get; set; }

         [Display(Name = "District")]
        public string district { get; set; }

         [Display(Name = "Chiefdom")]
        public string chiefdom { get; set; }

         [Display(Name = "Town")]
        public string town { get; set; }

        }
    }
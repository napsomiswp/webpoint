using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class AddMemberToCPListViewModel
        {
        [Display(Name = "S.S. Number")]
        public string fssno { get; set; }

         [Display(Name = "Surname")]
        public string fsurname { get; set; }

         [Display(Name = "First Name")]
        public string  firstname { get; set; }

         [Display(Name = "Other Name(s)")]
        public string fothername { get; set; }

         [Display(Name = "Sex")]
        public string fsex { get; set; }

         [Display(Name = "Date of Birth")]
        public DateTime? fdateofbirth { get; set; }

         [Display(Name = "Age")]
        public int fage { get; set; }

         [Display(Name = "NASSIT Pay Point")]
        public string fnassitpaypoint { get; set; }

         [Display(Name = "Annual Salary")]
        public decimal? fannualsalary { get; set; }

         [Display(Name = "Number of Years")]
        public int fnoofyears { get; set; }

         [Display(Name = "Factor")]
        public decimal? ffactor { get; set; }

         [Display(Name = "Cost of Validation")]
        public decimal? fcostofvalidation { get; set; }

         [Display(Name = "Edit")]
        public bool fedit { get; set; }

        }
    }
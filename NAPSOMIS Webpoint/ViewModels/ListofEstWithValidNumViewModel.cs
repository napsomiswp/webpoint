using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ListofEstWithValidNumViewModel
        {
        [Display(Name = "Area Office")]
        public string areaoffice { get; set; }

         [Display(Name = "ER. Number")]
        public string ferno { get; set; }

         [Display(Name = "Establishment")]
        public string establishment { get; set; }

         [Display(Name = "LF")]
        public int LF { get; set; }
        }
    }
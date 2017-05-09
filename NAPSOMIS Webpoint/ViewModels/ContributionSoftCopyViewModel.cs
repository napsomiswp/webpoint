using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class ContributionSoftCopyViewModel
        {

        public string ERNO { get; set; }

        public string EstablishmentName { get; set; }
        
        public string CR { get; set; }

         public string ContributionType { get; set; }

        public string CRBeginPeriod { get; set; }

        public string CREndPeriod { get; set; }

         public string ftype { get; set; }

         public string fcat { get; set; }
         
        public string SubmissionType { get; set; }

        public string DebitPeriod { get; set; }

        public string Period { get; set; }

        public int? NoOfRecords { get; set; }

        public decimal? TotalContribution { get; set; }

        public int? NoOfInvalidRecords { get; set; }


        }
    }
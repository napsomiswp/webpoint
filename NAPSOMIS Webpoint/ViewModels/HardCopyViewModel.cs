using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class HardCopyViewModel
        {

        //SUMMARY TAB
        [StringLength(25)]
        [Display(Name = "ERNo")]
        public string ferno { get; set; }

        [Display(Name = "Category")]
        public string fcat { get; set; }

        [Display(Name = "Submission Mode")]
        public string fmodesubmission { get; set; }

        [Display(Name = "No of Workers")]
        public int? fnoofworkers { get; set; }

        [Display(Name = "Total Salary")]
        public decimal? ftotalsalaryorcontribution { get; set; }

        [Display(Name = "ERNo")]
        public string fdisplayerno { get; set; }

        [Display(Name = "Employer")]
        public string fdisplayemp_name { get; set; }





        //ADD NEW MEMBER(s) TAB
        [Display(Name = "Employer")]
        public string femp_name { get; set; }

        [Display(Name = "Worker(s) Expected")]
        public int? fAddworkersexpected { get; set; }

        [Display(Name = "Worker(s) Captured")]
        public int? fAddworkercaptured { get; set; }

        [Display(Name = "Contribution Expected")]
        public decimal? fAddcontributionexpected { get; set; }

        [Display(Name = "Contribution Captured")]
        public decimal? fAddcontributioncaptured { get; set; }




        [Display(Name = "SSNO")]
        public string fAddSSNo { get; set; }

        [Display(Name = "Surname")]
        public string fAddSurname { get; set; }

        [Display(Name = "First Name")]
        public string fAddFirstName { get; set; }

        [Display(Name = "Other Name")]
        public string fAddOtherName { get; set; }

        [Display(Name = "Responsibility Centre")]
        public string fAddResponsibilityCentre { get; set; }

        [Display(Name = "Staff Number")]
        public string fAddStaffNumber { get; set; }

        [Display(Name = "First Contribution Period")]
        public string fAddFirstContributionPeriod { get; set; }

        [Display(Name = "Salary")]
        public decimal fAddContributionorSalary { get; set; }



        //EDIT ALL MEMBERS TAB 

        [Display(Name = "ID")]
        public int? fEditID { get; set; }

        [Display(Name = "SSNo")]
        public string fEditSSNo { get; set; }

        [Display(Name = "Surname")]
        public string fEditSurname { get; set; }

        [Display(Name = "First Name")]
        public string fEditFirstName { get; set; }

        [Display(Name = "Other Name")]
        public string fEditOtherName { get; set; }

        [Display(Name = "Responsility Centre")]
        public string fEditResponsibilityCentre { get; set; }

        [Display(Name = "Staff Number")]
        public string fEditStaffNumber { get; set; }

        [Display(Name = "Period")]
        public string fEditPeriod { get; set; }

        [Display(Name = "Contribution")]
        public decimal? fEditContributionorSalary { get; set; }

        [Display(Name = "Edit Name")]
        public bool? fEditName { get; set; }


        //EDIT ALL MEMBERS

        [Display(Name = "ID")]
        public int? fEditAllID { get; set; }

        [Display(Name = "SSNo")]
        public string fEditAllSSNo { get; set; }

        [Display(Name = "Surname")]
        public string fEditAllSurname { get; set; }

        [Display(Name = "First Name")]
        public string fEditAllFirstName { get; set; }

        [Display(Name = "Other Name")]
        public string fEditAllOtherName { get; set; }

        [Display(Name = "Responsibility Centre")]
        public string fEditAllResponsibilityCentre { get; set; }

        [Display(Name = "Staff Number")]
        public string fEditAllStaffNumber { get; set; }

        [Display(Name = "Period")]
        public string fEditAllPeriod { get; set; }

        [Display(Name = "Contribution")]
        public decimal? fEditAllContributionorSalary { get; set; }

        [Display(Name = "Skip In-Active Staff")]
        public bool? fEditAllSkipInactiveStaff { get; set; }

        [Display(Name = "Record Index")]
        public int? fEditAllRecordIndex { get; set; }


        //MASTER UPDATE
        [Display(Name = "Generate CR")]
        public bool? fMasterUpdateGenerateCR { get; set; }

        [Display(Name = "Select CR")]
        public string fmasterperiod { get; set; }

        [Display(Name = "Period")]
        public string fmasterperiodtext { get; set; }

        [Display(Name = "Total Contribution")]
        public decimal? fmastercontributiontext { get; set; }

        [Display(Name = "Total No of Workers")]
        public int? fmasterperiodnoofworkers { get; set; }

        }
    }
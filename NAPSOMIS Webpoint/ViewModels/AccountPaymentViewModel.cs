using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NAPSOMIS_Webpoint.ViewModels
    {
    public class AccountPaymentViewModel
        {
        //SUMMARY CASH
        [StringLength(25)]
        [Display(Name = "Est No.")]
        public string cashERNO { get; set; }

        [Display(Name = "Establishment")]
        public string cashestablishment { get; set; }

        [Display(Name = "SSNO")]
        public string cashssno { get; set; }

        [Display(Name = "Member Name")]
        public string cashmembername { get; set; }

        [Display(Name = "Scheme")]
        public string cashscheme { get; set; }

        [Display(Name = "Receipt No")]
        public string cashreceiptno { get; set; }

        [Display(Name = "Receipt Date")]
        public DateTime? cashreceiptdate { get; set; }

        [Display(Name = "Received By")]
        public string cashdistcode { get; set; }

        [Display(Name = "Total Amount")]
        public decimal? cashtotalamount { get; set; }

        [Display(Name = "Type")]
        public string cashtype { get; set; }

        [Display(Name = "From")]
        public string cashfrom { get; set; }

        [Display(Name = "To")]
        public string cashto { get; set; }

        [Display(Name = "Cummulated")]
        public decimal? cashcummulated { get; set; }

        [Display(Name = "Amount")]
        public decimal? cashamount { get; set; }

        [Display(Name = "Labour Force")]
        public int? cashlabourforce { get; set; }

        [Display(Name = "Balance")]
        public decimal? cashbalance { get; set; }

        [Display(Name = "Re-Print Receipt")]
        public bool cashreprintreceipt { get; set; }

        [Display(Name = "Lost Card")]
        public bool cashLostCard { get; set; }




        ////ADD NEW CHEQUE TAB
        [StringLength(25)]
        [Display(Name = "Est No")]
        public string chequeERNO { get; set; }

        [Display(Name = "Establishment")]
        public string chequeEstablishment { get; set; }

        [Display(Name = "Scheme")]
        public string chequescheme { get; set; }

        [Display(Name = "Cheque No")]
        public string chequechequeno { get; set; }

        [Display(Name = "Receipt No")]
        public string chequereceiptno { get; set; }

        [Display(Name = "Receipt Date")]
        public DateTime? chequereceiptdate { get; set; }

        [Display(Name = "Received By")]
        public string chequedistcode { get; set; }

        [Display(Name = "Date")]
        public DateTime? chequedate { get; set; }

        [Display(Name = " Amount")]
        public decimal? chequetotalamount { get; set; }

        [Display(Name = "Bank")]
        public string chequebank { get; set; }

        [Display(Name = "Branch")]
        public string chequebranch { get; set; }

        [Display(Name = "Cummulated")]
        public decimal? chequecummulated { get; set; }




        //ADD BANK TRANSFER
        [StringLength(25)]
        [Display(Name = "Est No")]
        public string banktERNO { get; set; }

        [Display(Name = "Establishment")]
        public string banktEstablishment { get; set; }

        [Display(Name = "SSNo")]
        public string banktssno { get; set; }

        [Display(Name = "Member Name")]
        public string banktmembername { get; set; }

        [Display(Name = "Advice No.")]
        public string banktadviceno { get; set; }

        [Display(Name = " Date")]
        public DateTime? banktdate { get; set; }
 
        [Display(Name = "Amount")]
        public decimal? banktamount { get; set; }

        [Display(Name = "Bank ")]
        public string banktbank { get; set; }

        [Display(Name = "Branch")]
        public string banktbranch { get; set; }

        [Display(Name = "Received By")]
        public string banktdistcode { get; set; }

        public int TabIndex { get; set; }

        [Display(Name = "Re-Print Receipt")]
        public bool RePrintReceipt { get; set; }

        }
    }
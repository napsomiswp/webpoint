using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;
using System.Data;
using System.Configuration;

namespace NAPSOMIS_Webpoint
    {
    public class GetUserLogonStatus : Controller
        {
        public string UserName()
            {
            try
                {
                if (Session["UserName"] != null)
                    {
                    return Session["UserName"].ToString();
                    }
                else
                    {
                    return "";
                    }
                }
            catch (Exception)
                {
                return "";
                }

            }
        }
    }
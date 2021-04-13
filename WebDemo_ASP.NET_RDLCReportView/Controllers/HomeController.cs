using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo_ASP.NET_RDLCReportView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Report()
        {

            DataTable dt = getData();

            ReportViewer view = new ReportViewer();
            ReportDataSource dtsource = new ReportDataSource("DataSet1", dt);
            view.LocalReport.DataSources.Clear();
            view.LocalReport.DataSources.Add(dtsource);
            view.LocalReport.ReportPath = @"Reports\Report1.rdlc";

            view.Width = 1000;

            view.LocalReport.Refresh();

            ViewBag.ReportViewer = view;
            return View();
        }


        /// <summary>
        /// Internal Class generate sample users
        /// </summary>
        /// <returns></returns>
        public DataTable getData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("username");
            dt.Columns.Add("name");
            dt.Columns.Add("email");
            dt.Columns.Add("status");
            dt.Columns.Add("tdt");


            for (int i = 1; i <= 10; i++)
            {
                dt.Rows.Add(i.ToString(),
                            "user" + i.ToString(),
                            "User " + i.ToString(),
                            "user" + i.ToString() + "@user.com",
                            "action" + i.ToString(),
                            DateTime.Now.ToString()
                    ) ;
            }
            return dt;
        }
    }
}
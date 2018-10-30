using BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonModels;

namespace HIDIVE.Controllers
{
    public class HomeController : Controller
    {
        BLL_TitleRow _bll_TitleRow = new BLL_TitleRow();
        public ActionResult Index()
        {
            string path = Server.MapPath("~/App_Data/dashboard.json");
            List<TitleRow> titleRows = _bll_TitleRow.GetTitleRows(path);
            return View(titleRows);
        }
        

        //PartialView: Continue Watching titles
        [HttpGet]
        public ActionResult ListTitles()
        {
            string path = Server.MapPath("~/App_Data/dashboard.json");
            List<TitleRow> titleRows = _bll_TitleRow.GetTitleRows(path);
            TitleRow titleRow = titleRows.ToList().Where(x => x.Name == "Continue Watching").FirstOrDefault();
            List<Title> titles = titleRow.Titles.ToList();
          
            ViewData.TemplateInfo.HtmlFieldPrefix = $"Title";
            return PartialView("EditorTemplates/ListTitles", titles);
        }
       
    }
}
using JSONparse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HIDIVE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Titlerow> titleRows = new List<Titlerow>();
            string path = Server.MapPath("~/App_Data/dashboard.json");
            using (StreamReader rd = new StreamReader(path))
            {
                string jsonRaw = rd.ReadToEnd();
                Rootobject rootObjects = JsonConvert.DeserializeObject<Rootobject>(jsonRaw);
                Data data = rootObjects.Data;
                titleRows = data.TitleRows.ToList();
                //foreach (Titlerow tr in data.TitleRows)
                //{
                //    List<Title> titles = tr.Titles.ToList();
                //}
            }
            return View(titleRows);
        }
        

        //PartialView: Continue Watching titles
        [HttpGet]
        public ActionResult ListTitles()
        {
            List<Title> titles = new List<Title>();
            string path = Server.MapPath("~/App_Data/dashboard.json");
            using (StreamReader rd = new StreamReader(path))
            {
                string jsonRaw = rd.ReadToEnd();
                Rootobject rootObjects = JsonConvert.DeserializeObject<Rootobject>(jsonRaw);
                Data data = rootObjects.Data;
                Titlerow titleRow = data.TitleRows.ToList().Where(x=>x.Name=="Continue Watching").FirstOrDefault();
                titles = titleRow.Titles.ToList();
            }
            ViewData.TemplateInfo.HtmlFieldPrefix = $"Title";
            return PartialView("EditorTemplates/ListTitles", titles);
        }
       
    }
}
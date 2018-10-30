using CommonModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TitleRow
    {
        public List<TitleRow> GetTitleRows(string path)
        {
            List<TitleRow> titleRows = new List<TitleRow>();
            try
            {
                using (StreamReader rd = new StreamReader(path))
                {
                    string jsonRaw = rd.ReadToEnd();
                    RootObject rootObjects = JsonConvert.DeserializeObject<RootObject>(jsonRaw);
                    Data data = rootObjects.Data;
                    titleRows = data.TitleRows.ToList();
                }
            }
            catch (Exception e)
            {
                //log e;
                return titleRows;
            }
           
            return titleRows;
        }
    }
}

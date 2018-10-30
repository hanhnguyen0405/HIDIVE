using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels
{
    public class RootObject
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public object Message { get; set; }
        public Messages Messages { get; set; }
        public Data Data { get; set; }
        public string Timestamp { get; set; }
        public string IPAddress { get; set; }
    }
}

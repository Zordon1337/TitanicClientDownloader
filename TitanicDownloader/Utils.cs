using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace TitanicDownloader
{
    internal class Utils
    {
        public static List<Osudata> GetData()
        {
            string jsonString = new WebClient().DownloadString("https://raw.githubusercontent.com/osuTitanic/stern/main/app/static/clients/manifest.json");

            List<Osudata> osuDataList = JsonConvert.DeserializeObject<List<Osudata>>(jsonString);

            return osuDataList;
        }
        public class Hash
        {
            public string file { get; set; }
            public List<string> md5 { get; set; }
        }

        public class Screenshot
        {
            public string src { get; set; }
            public string width { get; set; }
            public string height { get; set; }
        }

        public class Osudata
        {
            public string display_name { get; set; }
            public string build_name { get; set; }
            public string description { get; set; }
            public string known_bugs { get; set; }
            public bool supported { get; set; }
            public bool recommended { get; set; }
            public bool preview { get; set; }
            public List<object> actions { get; set; }
            public List<Hash> hashes { get; set; }
            public List<string> downloads { get; set; }
            public List<Screenshot> screenshots { get; set; }
        }
    }
}

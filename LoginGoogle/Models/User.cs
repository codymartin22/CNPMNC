using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoginGoogle.Models
{
    public class User
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Data
        {
            public int height { get; set; }
            public bool is_silhouette { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }

        public class Picture
        {
            public Data data { get; set; }
        }
            public string id { get; set; }
            public string name { get; set; }
            public Picture picture { get; set; }
            public string link { get; set; }
    }
}

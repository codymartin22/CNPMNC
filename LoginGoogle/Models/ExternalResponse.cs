using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginGoogle.Models
{
    public class ExternalResponse
    {
        public string contentType { get; set; }
        public string serializerSettings { get; set; }
        public string statusCode { get; set; }
        public List<string> value { get; set; }
    }
}

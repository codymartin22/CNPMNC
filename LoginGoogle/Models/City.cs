using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginGoogle.Models
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string state { get; set; }
        public string Country { get; set; }
        public Coord coord { get; set; }

    }
    public class Coord
    {
        public string lon { get; set; }
        public string lat { get; set; }
    }
}

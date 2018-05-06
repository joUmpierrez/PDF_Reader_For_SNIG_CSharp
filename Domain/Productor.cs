using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Productor
    {
        // id Entity Framework
        public string name { get; set; }
        public List<Dicose> dicoses { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Constancia
    {
        // id Entity Framework
        public DateTime date { get; set; }
        public string guia { get; set; }
        public int autorizationNumber { get; set; }
        public bool propertyChange { get; set; }
        public List<Caravana> caravanas { get; set; }
        public Productor seller { get; set; }
        public Productor buyer { get; set; }
        public Productor exitSite { get; set; }
        public Productor arriveSite { get; set; }
    }
}

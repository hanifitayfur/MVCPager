using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSayfalama.Models
{
    public class Bilet
    {
        public string KonserAdi { get; set; }
        public string Sarkici { get; set; }
        public DateTime? DateAdded { get; set; }

        public Bilet(string konser, string sarki,DateTime? dateadded)
        {
            KonserAdi = konser;
            Sarkici = sarki;
            DateAdded = dateadded;
        }
    }
}
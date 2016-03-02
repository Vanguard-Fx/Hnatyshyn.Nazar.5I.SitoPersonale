using Hnatyshyn.Nazar._5I.SitoPersonale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hnatyshyn.Nazar._5I.SitoPersonale.Models
{
    public class Materia
    {
        public string NomeMateria { get; set; }

        public int ID { get; set; }
        public IEnumerable<Progetto> Progetti { get; set; }

        public Materia (XElement progetti)
        {
            NomeMateria = progetti.Attribute("Materia").Value;
            ID = Convert.ToInt32(progetti.Attribute("IDMateria").Value);
            Progetti = from XElement Progetto in progetti.Elements("progetto")
                       select new Progetto(Progetto);
        }
    }
}
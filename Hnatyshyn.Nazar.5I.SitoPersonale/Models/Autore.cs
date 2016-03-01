using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hnatyshyn.Nazar._5I.SitoPersonale.Models
{
    public class Autore
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }

        public string Immagine { get; private set; }

        public IEnumerable<Materia> Materie {get; private set;}

        public Autore (string link)
        {
            XElement ElementProgetti = XElement.Load(link);
            

            Nome = ElementProgetti.Element("autore").Attribute("Nome").Value;
            Cognome = ElementProgetti.Element("autore").Attribute("Cognome").Value;
            Immagine = ElementProgetti.Element("autore").Attribute("Immagine").Value;

            Materie = from XElement Progetti in ElementProgetti.Element("autore").Elements("progetti")
                           select new Materia(Progetti);

        }
    }
}
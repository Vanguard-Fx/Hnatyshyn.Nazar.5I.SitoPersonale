using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Hnatyshyn.Nazar._5I.SitoPersonale.Models
{
    public class Progetto
    {
        /*	
        <progetto>
            <data>__DATA__</data>
            <materia>__MATERIA__</materia>
            <nome>Nazar</nome>
            <cognome>Hnatyshyn</cognome>
            <titolo>__TITOLO__</titolo>
            <desc><![CDATA[__DESC__]]></desc>
            <descrizione><![CDATA[__DESCRIZIONE__]]></descrizione>
            <foto>__FOTO__</foto>
            <link>__LINK__</link>
        </progetto>
        */
        public string Data { get; set; }
        public string Titolo { get; set; }
        public string DescrizioneCorta { get; set; }
        public string DescrizioneLunga { get; set; }
        public string Link { get; set; }
        public IEnumerable<string> Tags { get; set; }

        public Progetto ()
        { }
        public Progetto(XElement progetto)
        {
            Data = progetto.Attribute("Data").Value.TrimEnd().TrimStart();
            Titolo = progetto.Attribute("Titolo").Value.TrimEnd().TrimStart();
            DescrizioneCorta = progetto.Attribute("DescrizioneCorta").Value.TrimEnd().TrimStart();
            DescrizioneLunga = progetto.Attribute("DescrizioneLunga").Value.TrimEnd().TrimStart();
            Link = progetto.Attribute("Link").Value.TrimEnd().TrimStart();

            Tags = from XElement Tags in progetto.Elements("tag")
                   select Tags.ToString();
        }
    }
}
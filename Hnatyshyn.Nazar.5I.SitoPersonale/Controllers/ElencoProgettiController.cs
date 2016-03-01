using Hnatyshyn.Nazar._5I.SitoPersonale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hnatyshyn.Nazar._5I.SitoPersonale.Controllers
{
    public class ElencoProgettiController : Controller
    {
        // GET: ElencoProgetti
        public ActionResult Index()
        {
            Autore autore = new Autore(Server.MapPath("Content/ElencoProgetti.xml"));
            return View(autore);
        }

        public ActionResult Details([Bind(Include = "Materia,Data,Titolo,DescrizioneCorta,DescrizioneLunga,Link,Tags")] Dettagli Dettagli)
        {
            return View(Dettagli);
        }
    }
}
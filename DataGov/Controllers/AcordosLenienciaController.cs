using DataGov.Core.DataAccess;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DataGov.Controllers
{
    public class AcordosLenienciaController : Controller
    {
        // GET: AcordosLeniencia
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            AcordosLeniencia acordosLeniencia = new AcordosLeniencia();

            var ListaAcordos = new List<AcordosLeniencia>();
            ViewBag.ListaAcordos = await acordosLeniencia.AcordosLeniencias(); ;

            return View();
        }
    }
}
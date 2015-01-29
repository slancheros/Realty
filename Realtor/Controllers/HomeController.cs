using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Realtor.Models;
using RealtorData;

namespace Realtor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ici vous pouvez trouver l'information immobiliaire...";

            return View(LoadFeaturedInscriptions());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Voici le site d'Internet Realtor ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public InscriptionsListModel LoadFeaturedInscriptions()
        {
            var model = new InscriptionsListModel
            {
                InscriptionsList = new List<String>()
            };

            RealtorData.DataServices.InscriptionService service = new RealtorData.DataServices.InscriptionService();

            foreach( Entities.Inscriptions ins in service.List() ) {
                ins.PHOTOS.Load();
                if (ins.PHOTOS != null && ins.PHOTOS.Count>0)
                {
                    model.InscriptionsList.Add(ins.PHOTOS.First().PhotoURL);
                }
                }
            return model;
        }
    }
}

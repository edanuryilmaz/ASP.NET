using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkwebistem.Controllers
{
    public class ankara : Controller
    {   //[Contoller]/[Aciton]
        //ankara/nufus
        public String nufus()
        {
            return "Ankaranın nüfusu 6556165";
        }

        public IActionResult ilceler()
        {
            //controller dan view e veri taşıyoruz 
            ViewBag.toplamilceadedi = 25;
            return View();
        }
    }
}

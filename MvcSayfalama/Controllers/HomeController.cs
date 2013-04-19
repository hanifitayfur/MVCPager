using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSayfalama.Models;

namespace MvcSayfalama.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Biletler = BiletGetir();
            return View();
        }
        //ındex içerisinde gelecek olan datayı elde ediyoruz .İndex içinde döngüde   ViewBag.Biletler şeklinde ulaşırız
        public List<Bilet> BiletGetir()
        {
            List<Bilet> list = new List<Bilet>();

            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now)); 
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));
            list.Add(new Bilet("İzmir Konseri", "PSY", DateTime.Now));
            list.Add(new Bilet("Efes Konseri", "İsmail Yk", DateTime.Now));

            return list;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

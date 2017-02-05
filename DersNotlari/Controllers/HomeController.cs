using DersNotlari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DersNotlari.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = OgrenciGetir();
            
            return View(model);
        }

        public List<Ogrenci> OgrenciGetir ()
        {
            List<Ogrenci> Ogrenciler = new List<Ogrenci>();
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Engin";
            ogrenci.Soyad = "Polat";
            ogrenci.No = 1;
            ogrenci.DersAdi = "Tarih";
            ogrenci.Not = 35;
            Ogrenciler.Add(ogrenci);


            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Ad = "Bora";
            ogrenci2.Soyad = "Kasmer";
            ogrenci2.No = 2;
            ogrenci2.DersAdi = "Tarih";
            ogrenci2.Not = 85;
            Ogrenciler.Add(ogrenci2);
            

            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.Ad = "Emre";
            ogrenci3.Soyad = "Solmaz";
            ogrenci3.No = 3;
            ogrenci3.DersAdi = "Matematik";
            ogrenci3.Not = 95;
            Ogrenciler.Add(ogrenci3);
            
            return Ogrenciler;
        }
    }
}
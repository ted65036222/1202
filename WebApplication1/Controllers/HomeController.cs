﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public class AlbumWithCount
        //{
        //    public Models.Album Data { get; set; }
        //    public int ReadCount { get; set; }
        //}


        // GET: Home
        public ActionResult Index()
        {
            //ViewBag.ID = id;
            Service.DataService data = new Service.DataService();
            var list = data.LoadAllAlbum();
            return View(list);
        }

        public ActionResult Detail(string id)
        {
            Models.Album item = null;
            Service.DataService data = new Service.DataService();
            var list = data.LoadAllAlbum();
            item = list.SingleOrDefault(x => x.學號 == id);
            return View(item);
        }
        public ActionResult timetable(string id)
        {
            Models.Album item = null;
            Service.DataService data = new Service.DataService();
            var list = data.LoadAllAlbum();
            item = list.SingleOrDefault(x => x.學號 == id);
            return View(item);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;
using BLL;
using MemoApp.Models;

namespace MemoApp.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        // GET: Home
        public ActionResult Index()
        {
            var records = myModel.GetList();
            return View(records);
        }
    }
}
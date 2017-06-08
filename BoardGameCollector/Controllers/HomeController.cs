using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoardGameCollector.Models;

namespace BoardGameCollector.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var boardGames = BoardGameManager.GetBoardGames();
            return View(boardGames);
        }
    }
}
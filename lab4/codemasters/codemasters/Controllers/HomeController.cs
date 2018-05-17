using codemasters.BusinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codemasters.Controllers
{
    public class HotPlaces
    {
        public int ChampionLeagueGroupStageMin;
        public int ChampionLeagueGroupStageMax;

        public int ChampionLeagueQualificationMin;
        public int ChampionLeagueQualificationMax;

        public int EuropaLeagueGroupStageMin;
        public int EuropaLeagueGroupStageMax;

        public int EuropaLeagueQualificationMin;
        public int EuropaLeagueQualificationMax;

        public int OutOfLeagueAdditionalMatchMin;
        public int OutOfLeagueAdditionalMatchMax;

        public int OutOfLeagueMin;
        public int OutOfLeagueMax;


        public HotPlaces(
            int new_ChampionLeagueGroupStageMin,
            int new_ChampionLeagueGroupStageMax,
            
            int new_ChampionLeagueQualificationMin,
            int new_ChampionLeagueQualificationMax,

            int new_EuropaLeagueGroupStageMin,
            int new_EuropaLeagueGroupStageMax,
            
            int new_EuropaLeagueQualificationMin,
            int new_EuropaLeagueQualificationMax,

            int new_OutOfLeagueAdditionalMatchMin,
            int new_OutOfLeagueAdditionalMatchMax,

            int new_OutOfLeagueMin,
            int new_OutOfLeagueMax)
        {
            ChampionLeagueGroupStageMin = new_ChampionLeagueGroupStageMin;
            ChampionLeagueGroupStageMax = new_ChampionLeagueGroupStageMax;

            ChampionLeagueQualificationMin = new_ChampionLeagueQualificationMin;
            ChampionLeagueQualificationMax = new_ChampionLeagueQualificationMax;

            EuropaLeagueGroupStageMin = new_EuropaLeagueGroupStageMin;
            EuropaLeagueGroupStageMax = new_EuropaLeagueGroupStageMax;

            EuropaLeagueQualificationMin = new_EuropaLeagueGroupStageMin;
            EuropaLeagueQualificationMax = new_EuropaLeagueQualificationMax;

            OutOfLeagueAdditionalMatchMin = new_OutOfLeagueAdditionalMatchMin;
            OutOfLeagueAdditionalMatchMax = new_OutOfLeagueAdditionalMatchMax;

            OutOfLeagueMin = new_OutOfLeagueMin;
            OutOfLeagueMax = new_OutOfLeagueMax;
        }
    }

    public class CLeagueWinner
    {
        public String name;
        public String year;
        public String LeagueOrigin;

        public CLeagueWinner(String new_name, String new_year, String new_LeagueOrigin)
        {
            name = new_name;
            year = new_year;
            LeagueOrigin = new_LeagueOrigin;
        }
    }

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: EPL
        public ActionResult EPL()
        {
            // EPL standings:
            var english = new EPLApi();
            var viewModel = english.GetEPL();
            // Special places in EPL tournament:
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            // Returning value:
            return View(viewModel);
        }
        // GET: Liga BBVA
        public ActionResult Liga_BBVA()
        {
            // BBVA league standings:
            var spanish = new BBVAApi();
            var viewModel = spanish.GetBBVA();
            // Special places in BBVA tournament:
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            // Returning value:
            return View(viewModel);
        }
        // GET: League1
        public ActionResult Ligue1()
        {
            // Ligue1 standings:
            var ligue = new Ligue1Api();
            var viewModel = ligue.GetLigue1();
            // Special places in Ligue1 tournament:
            ViewBag.HOT = new HotPlaces(1, 2, 3, 3, 4, 4, 0, 0, 18, 18, 19, 20);
            // Returning value:
            return View(viewModel);
        }
        // GET: Bundesliga
        public ActionResult Bundesliga()
        {
            // Bundesliga standings:
            var bund = new BundesligaApi();
            var viewModel = bund.GetBundesliga();
            // Special places in Bundesliga tournament:
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 16, 16, 17, 18);
            // Returning value:
            return View(viewModel);
        }
        // GET: Serie A
        public ActionResult Serie_A()
        {
            // Serie_A standings:
            var ser = new SerieAApi();
            var viewModel = ser.GetSerieA();
            // Special places in Serie_A tournament:
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            // Returning value:
            return View(viewModel);
        }
        // GET: Champions League
        public ActionResult ChampionsLeague()
        {
            // UCL statistics:
            var ucl = new UCLApi();
            var viewModel = ucl.GetUCL();
            // Returning value:
            return View(viewModel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codemasters.Controllers
{
    public class Team
    {
        public String name;
        public int wins;
        public int draws;
        public int loses;
        public String gols;
        public int points;
        public int place;
        public Team(string new_name, int new_wins, int new_draws, int new_loses, string new_gols, int new_points, int new_place)
        {
            name = new_name;
            wins = new_wins;
            draws = new_draws;
            loses = new_loses;
            gols = new_gols;
            points = new_points;
            place = new_place;
        }
    }

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
            ViewBag.EPLteams = new List<Team>
            {
                new Team("Manchester City", 26, 3, 1, "85:20", 81, 1),
                new Team("Manchester Utd", 20, 5, 5, "58:23", 65, 2),
                new Team("Liverpool", 18, 9, 4, "73:34", 63, 3),
                new Team("Tottenham", 18, 7, 5, "59:25", 61, 4),
                new Team("Chelsea", 17, 5, 8, "52:27", 56, 5),
                new Team("Arsenal", 14, 6, 10, "55:41", 48, 6),
                new Team("Burnley", 11, 10, 9, "27:26", 43, 7),
                new Team("Leicester", 10, 10, 10, "45:43", 40, 8),
                new Team("Everton", 11, 7, 13, "37:50", 40, 9),
                new Team("Bournemouth", 9, 9, 13, "37:49", 36, 10),
                new Team("Watford", 10, 6, 15, "39:55", 36, 11),
                new Team("Brighton", 8, 10, 12, "28:40", 34, 12),
                new Team("Newcastle", 8, 8, 14, "30:40", 32, 13),
                new Team("Swansea", 8, 7, 15, "25:42", 31, 14),
                new Team("Huddersfield", 8, 7, 16, "25:52", 31, 15),
                new Team("Crystal Palace", 7, 9, 15, "30:48", 30, 16),
                new Team("West Ham", 7, 9, 14, "36:57", 30, 17),
                new Team("Southampton", 5, 13, 12, "29:44", 28, 18),
                new Team("Stoke", 6, 9, 16, "29:58", 27, 19),
                new Team("West Brom", 3, 11, 17, "24:49", 20, 20)
            };
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            return View();
        }
        // GET: Liga BBVA
        public ActionResult Liga_BBVA()
        {
            ViewBag.BBVAteams = new List<Team>
            {
                new Team("Barcelona", 23, 6, 0, "74:13", 75, 1),
                new Team("Atletico Madrid", 19, 7, 3, "49:14", 64, 2),
                new Team("Real Madrid", 18, 6, 5, "73:33", 60, 3),
                new Team("Valencia", 18, 5, 6, "57:31", 59, 4),
                new Team("Villarreal", 14, 5, 10, "40:33", 47, 5),
                new Team("Sevilla", 14, 3, 12, "37:44", 45, 6),
                new Team("Girona", 12, 7, 10, "43:42", 43, 7),
                new Team("Betis", 13, 4, 12, "49:53", 43, 8),
                new Team("Getafe", 10, 9, 10, "35:27", 39, 9),
                new Team("Celta Vigo", 11, 6, 12, "45:42", 39, 10),
                new Team("Eibar", 11, 6, 12, "36:43", 39, 11),
                new Team("Leganes", 10, 6, 13, "25:35", 36, 12),
                new Team("Athletic Bilbao", 8, 11, 10, "29:33", 35, 13),
                new Team("Espanyol", 8, 11, 10, "26:37", 35, 14),
                new Team("Real Sosiedad", 9, 6, 14, "51:52", 33, 15),
                new Team("Alaves", 10, 1, 18, "26:45", 31, 16),
                new Team("Levante", 5, 12, 12, "25:43", 27, 17),
                new Team("Las Palmas", 5, 6, 18, "21:58", 21, 18),
                new Team("Deportivo La Coruna", 4, 8, 17, "26:60", 20, 19),
                new Team("Malaga", 3, 5, 21, "16:45", 14, 20)
            };
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            return View();
        }
        // GET: League1
        public ActionResult Ligue1()
        {
            ViewBag.Ligue1teams = new List<Team>
            {
                new Team("PSG", 27, 2, 2, "95:21", 83, 1),
                new Team("Monaco", 20, 6, 4, "74:32", 66, 2),
                new Team("Marseille", 17, 8, 5, "61:37", 59, 3),
                new Team("Lyon", 16, 9, 5, "62:36", 57, 4),
                new Team("Rennes", 13, 6, 11, "39:36", 45, 5),
                new Team("Nantes", 12, 8, 10, "30:30", 44, 6),
                new Team("Montpellier", 9, 15, 6, "28:25", 42, 7),
                new Team("Nice", 12, 6, 12, "40:43", 42, 8),
                new Team("St.Etienne", 10, 9, 11, "33:44", 39, 9),
                new Team("Dijon", 10, 8, 12, "43:57", 38, 10),
                new Team("Bordeaux", 10, 7, 13, "33:39", 37, 11),
                new Team("Angers", 8, 11, 12, "36:42", 35, 12),
                new Team("Caen", 10, 5, 15, "22:36", 35, 13),
                new Team("Guingamp", 9, 8, 13, "30:45", 35, 14),
                new Team("Strasbourg", 8, 8, 14, "35:54", 32, 15),
                new Team("Amiens", 8, 7, 15, "25:34", 31, 16),
                new Team("Toulouse", 7, 9, 14, "29:41", 30, 17),
                new Team("Troyes", 8, 5, 17, "25:40", 29, 18),
                new Team("Lille", 7, 7, 16, "29:48", 28, 19),
                new Team("Metz", 5, 6, 19, "27:56", 21, 20)
            };
            ViewBag.HOT = new HotPlaces(1, 2, 3, 3, 4, 4, 0, 0, 18, 18, 19, 20);
            return View();
        }
        // GET: Bundesliga
        public ActionResult Bundesliga()
        {
            ViewBag.BUNDESLIGAteams = new List<Team>
            {
                new Team("Bayern Munich", 21, 3, 3, "66:20", 66, 1),
                new Team("Schalke", 14, 7, 6, "41:30", 49, 2),
                new Team("Borussia Dortmund", 13, 9, 5, "54:33", 48, 3),
                new Team("Frankfurt", 13, 6, 8, "38:30", 45, 4),
                new Team("Leverkusen", 12, 8, 7, "47:35", 44, 5),
                new Team("Rb Leipzig", 12, 7, 8, "40:35", 43, 6),
                new Team("Hoffenheim", 10, 9, 8, "46:41", 39, 7),
                new Team("Stuttgart", 11, 4, 12, "25:30", 37, 8),
                new Team("Monchengladbach", 10, 6, 11, "36:42", 36, 9),
                new Team("Augsburg", 9, 8, 10, "37:36", 35, 10),
                new Team("Herta", 8, 11, 8, "32:32", 35, 11),
                new Team("Bremen", 8, 9, 10, "30:32", 33, 12),
                new Team("Hannover", 8, 8, 11, "33:39", 32, 13),
                new Team("Freiburg", 6, 12, 9, "26:44", 30, 14),
                new Team("Wolfsburg", 4, 13, 10, "28:37", 25, 15),
                new Team("Mainz", 6, 7, 14, "29:46", 25, 16),
                new Team("FC Koln", 5, 5, 17, "27:49", 20, 17),
                new Team("Hamburger SV", 4, 6, 17, "19:43", 18, 18)
            };
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 16, 16, 17, 18);
            return View();
        }
        // GET: Serie A
        public ActionResult Serie_A()
        {
            ViewBag.SerieAteams = new List<Team>
            {
                new Team("Juventus", 24, 3, 2, "67:15", 75, 1),
                new Team("Napoli", 23, 4, 2, "63:19", 73, 2),
                new Team("AS Roma", 18, 5, 6, "29:43", 59, 3),
                new Team("Inter", 15, 10, 3, "47:21", 55, 4),
                new Team("Lazio", 16, 6, 7, "67:37", 54, 5),
                new Team("AC Milan", 15, 5, 8, "41:32", 50, 6),
                new Team("Atalanta", 12, 8, 8, "43:31", 44, 7),
                new Team("Sampdoria", 13, 5, 10, "47:43", 44, 8),
                new Team("Fiorentina", 11, 8, 9, "38:33", 41, 9),
                new Team("Torino", 8, 12, 8, "37:37", 36, 10),
                new Team("Bologna", 10, 4, 15, "34:41", 34, 11),
                new Team("Udinese", 10, 3, 15, "38:42", 33, 12),
                new Team("Genoa", 8, 6, 14, "21:29", 30, 13),
                new Team("Cagilari", 8, 5, 15, "18:48", 27, 14),
                new Team("Sassuolo", 7, 6, 15, "25:47", 25, 15),
                new Team("Chievo", 6, 7, 15, "25:47", 25, 16),
                new Team("Spal", 5, 10, 14, "28:50", 25, 17),
                new Team("Crotone", 6, 6, 16, "27:50", 24, 18),
                new Team("Verona", 6, 4, 18, "25:56", 22, 19),
                new Team("Benevento", 3, 1, 24, "19:63", 10, 20)
            };
            ViewBag.HOT = new HotPlaces(1, 4, 0, 0, 5, 5, 6, 6, 0, 0, 18, 20);
            return View();
        }
        // GET: Champions League
        public ActionResult ChampionsLeague()
        {
            ViewBag.ChampionsLeagueWinners = new List<CLeagueWinner>
            {
                new CLeagueWinner("Real Madrid", "2016-2017", "La Liga"),
                new CLeagueWinner("Real Madrid", "2015-2016", "La Liga"),
                new CLeagueWinner("Barcelona", "2014-2015", "La Liga"),
                new CLeagueWinner("Real Madrid", "2013-2014", "La Liga"),
                new CLeagueWinner("Bayern Munich", "2012-2013", "Bundesliga"),
                new CLeagueWinner("Chelsea", "2011-2012", "EPL"),
                new CLeagueWinner("Barcelona", "2010-2011", "La Liga"),
                new CLeagueWinner("Internazionale", "2009-2010", "Serie A"),
                new CLeagueWinner("Barcelona", "2008-2009", "La Liga"),
                new CLeagueWinner("Manchester United", "2007-2008", "EPL"),
                new CLeagueWinner("Milan", "2006-2007", "Serie A"),
                new CLeagueWinner("Barcelona", "2005-2006", "La Liga"),
                new CLeagueWinner("Liverpool", "2004-2005", "EPL"),
                new CLeagueWinner("Porto", "2003-2004", "Other"),
                new CLeagueWinner("Milan", "2002-203", "Serie A"),
                new CLeagueWinner("Real Madrid", "2001-2002", "La Liga"),
                new CLeagueWinner("Bayern Munich", "2000-2001", "Bundesliga")
            };
            return View();
        }
    }
}
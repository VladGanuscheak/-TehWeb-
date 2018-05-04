using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codemasters.Controllers
{
    public class PlayerStats
    {
        public int TotalGols;
        public int TotalMatches;
        public List<int> gols;
        public List<int> matches;
        public PlayerStats(int new_TotalGols, int new_TotalMatches, int EPL_gols, int EPL_matches, int BBVA_gols, int BBVA_matches, 
            int Bundesliga_gols, int Bundesliga_matches, int SerieA_gols, int SerieA_mathces, int Ligue1_gols, int Ligue1_matches)
        {
            TotalGols = new_TotalGols;
            TotalMatches = new_TotalMatches;
            gols = new List<int>
            {
                EPL_gols,
                BBVA_gols,
                Bundesliga_gols,
                SerieA_gols,
                Ligue1_gols
            };
            matches = new List<int>
            {
                EPL_matches,
                BBVA_matches,
                Bundesliga_matches,
                SerieA_mathces,
                Ligue1_matches
            };
        }
    }
    public class Player
    {
        public String name;
        public String currentClub;
        public String currentLeague;
        public String url;
        public PlayerStats stats;
        public Player(String new_name, String new_currentClub, String new_currentLeague,
            int new_TotalGols, int new_TotalMatches, int EPL_gols, int EPL_matches, int BBVA_gols, int BBVA_matches,
            int Bundesliga_gols, int Bundesliga_matches, int SerieA_gols, int SerieA_mathces, int Ligue1_gols, int Ligue1_matches,
             String new_url)
        {
            name = new_name;
            currentClub = new_currentClub;
            currentLeague = new_currentLeague;
            url = new_url;
            stats = new PlayerStats(new_TotalGols, new_TotalMatches, EPL_gols, EPL_matches, BBVA_gols, BBVA_matches,
            Bundesliga_gols, Bundesliga_matches, SerieA_gols, SerieA_mathces, Ligue1_gols, Ligue1_matches);
        }
    }
    public class playersController : Controller
    {
        // GET: players
        public ActionResult TopPlayers()
        {
            ViewBag.Player = new List<Player>
            {
                new Player("Lionel Messi", "Barcelona", "La Liga", 542, 626,  0, 0, 542, 626, 0, 0, 0, 0, 0, 0, "http://cdn.caughtoffside.com/wp-content/uploads/2017/10/lionel-messi-640x400.jpg"),
                new Player("Kevin De Bruyne", "Manchester City", "EPL", 81, 358, 34, 139, 0, 0, 20, 72, 0, 0, 0, 0, "https://static.independent.co.uk/s3fs-public/styles/article_small/public/thumbnails/image/2017/02/20/13/kevin-de-bruyne.jpg"),
                new Player("Cristiano Ronaldo", "Real Madrid", "La Liga", 566, 754, 118, 292, 443, 429, 0, 0, 0, 0, 0, 0, "https://images.performgroup.com/di/library/GOAL/6c/cd/cristiano-ronaldo-real-madrid_145ircb9ekb101eap6zinkqydq.jpg?t=-252129379&quality=90&w=1280"),
                new Player("Neymar", "PSG", "Ligue1", 269, 439, 0, 0, 105, 186, 0, 0, 0, 0, 28, 30, "http://givemesport.azureedge.net/images/18/02/15/354363bb32cf7dc0430dbfd9a8bf2ba7/960.jpg"),
                new Player("Paolo Dybala", "Juventus", "Serie A", 101, 262, 0, 0, 0, 0, 0, 0, 101, 262, 0, 0, "https://images.performgroup.com/di/library/group_content_la/dd/1c/paulo-dybala-juventus-v-spal-serie-a-25102017_6do6lp2s5n2o1f3t36il3st1r.jpg?t=1974125968&quality=90&h=300"),
                new Player("James Rodríguez", "Bayern Munich", "Bundesliga", 100, 361, 0, 0, 36, 110, 4, 27, 0, 0, 10, 38, "https://cdn.images.express.co.uk/img/dynamic/67/590x/James-Rodriguez-Bayern-Munich-Real-Madrid-892933.jpg")
            };
            return View();
        }
    }
}
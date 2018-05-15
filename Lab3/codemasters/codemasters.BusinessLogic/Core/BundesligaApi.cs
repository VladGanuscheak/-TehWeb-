using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codemasters.BusinessLogic.DBModel;
using codemasters.Domain.Entities.Stats;

namespace codemasters.BusinessLogic.Core
{
    public class BundesligaApi
    {
        public List<Bundesliga> GetBundesliga()
        {
            List<Bundesliga> result = new List<Bundesliga>();

            using (var db = new BundesligaContext())
            { // Get all campgrounds from db
                Database.SetInitializer<BundesligaContext>(null); // < -  -   -    -     -      W H Y ?
                foreach (var bund in db.BundesligaApi)
                {
                    result.Add(new Bundesliga {
                        Id = bund.Id,
                        Team = bund.Team,
                        Wins = bund.Wins,
                        Draws = bund.Draws,
                        Loses = bund.Loses,
                        Gols_scored = bund.Gols_scored,
                        Gols_received = bund.Gols_received,
                        Points = bund.Points
                    });
                }
            };
            return result;
        }
     }
}
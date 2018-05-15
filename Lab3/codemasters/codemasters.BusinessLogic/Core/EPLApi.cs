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
    public class EPLApi
    {
        public List<EPL> GetEPL()
        {
            List<EPL> result = new List<EPL>();

            using (var db = new EPLContext())
            { // Get all campgrounds from db
                Database.SetInitializer<EPLContext>(null); // < -  -   -    -     -      W H Y ?
                foreach (var e in db.EPLApi)
                {
                    result.Add(new EPL
                    {
                        Id = e.Id,
                        Team = e.Team,
                        Wins = e.Wins,
                        Draws = e.Draws,
                        Loses = e.Loses,
                        Gols_scored = e.Gols_scored,
                        Gols_received = e.Gols_received,
                        Points = e.Points
                    });
                }
            };
            return result;
        }
    }
}
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
    public class BBVAApi
    {
        public List<BBVA> GetBBVA()
        {
            List<BBVA> result = new List<BBVA>();

            using (var db = new BBVAContext())
            { // Get all campgrounds from db
                Database.SetInitializer<BBVAContext>(null);
                foreach (var b in db.BBVAApi)
                {
                    result.Add(new BBVA
                    {
                        Id = b.Id,
                        Team = b.Team,
                        Wins = b.Wins,
                        Draws = b.Draws,
                        Loses = b.Loses,
                        Gols_scored = b.Gols_scored,
                        Gols_received = b.Gols_received,
                        Points = b.Points
                    });
                }
            };
            return result;
        }
    }
}
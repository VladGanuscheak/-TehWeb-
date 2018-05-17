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
    public class Ligue1Api
    {
        public List<Ligue1> GetLigue1()
        {
            List<Ligue1> result = new List<Ligue1>();

            using (var db = new Ligue1Context())
            { // Get all campgrounds from db
                Database.SetInitializer<Ligue1Context>(null); 
                foreach (var ligue in db.Ligue1Api)
                {
                    result.Add(new Ligue1
                    {
                        Id = ligue.Id,
                        Team = ligue.Team,
                        Wins = ligue.Wins,
                        Draws = ligue.Draws,
                        Loses = ligue.Loses,
                        Gols_scored = ligue.Gols_scored,
                        Gols_received = ligue.Gols_received,
                        Points = ligue.Points
                    });
                }
            };
            return result;
        }
    }
}
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
    public class SerieAApi
    {
        public List<SerieA> GetSerieA()
        {
            List<SerieA> result = new List<SerieA>();

            using (var db = new SerieAContext())
            { // Get all campgrounds from db
                Database.SetInitializer<SerieAContext>(null); // < -  -   -    -     -      W H Y ?
                foreach (var ser in db.SerieAApi)
                {
                    result.Add(new SerieA
                    {
                        Id = ser.Id,
                        Team = ser.Team,
                        Wins = ser.Wins,
                        Draws = ser.Draws,
                        Loses = ser.Loses,
                        Gols_scored = ser.Gols_scored,
                        Gols_received = ser.Gols_received,
                        Points = ser.Points
                    });
                }
            };
            return result;
        }
    }
}
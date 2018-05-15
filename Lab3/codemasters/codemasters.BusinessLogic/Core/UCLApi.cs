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
    public class UCLApi
    {
        public List<UCL> GetUCL()
        {
            List<UCL> result = new List<UCL>();

            using (var db = new UCLContext())
            { // Get all campgrounds from db
                Database.SetInitializer<UCLContext>(null); // < -  -   -    -     -      W H Y ?
                foreach (var ucl in db.UCLApi)
                {
                    result.Add(new UCL
                    {
                        Id = ucl.Id,
                        Team = ucl.Team,
                        Year = ucl.Year,
                        League = ucl.League
                    });
                }
            };
            return result;
        }
    }
}
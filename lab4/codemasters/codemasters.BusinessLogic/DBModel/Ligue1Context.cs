using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using codemasters.Domain.Entities.Stats;

namespace codemasters.BusinessLogic.DBModel
{
    public class Ligue1Context : DbContext
    {
        public Ligue1Context() : base("name=codemasters")
        {
        }

        public virtual DbSet<Ligue1_Table> Ligue1Api { get; set; }
    }
}

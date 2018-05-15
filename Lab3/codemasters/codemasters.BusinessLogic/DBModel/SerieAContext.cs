using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using codemasters.Domain.Entities.Stats;

namespace codemasters.BusinessLogic.DBModel
{
    public class SerieAContext : DbContext
    {
        public SerieAContext() : base("name=codemasters")
        {
        }

        public virtual DbSet<SerieA_Table> SerieAApi { get; set; }
    }
}

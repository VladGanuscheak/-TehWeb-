using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using codemasters.Domain.Entities.Stats;

namespace codemasters.BusinessLogic.DBModel
{
    public class BBVAContext : DbContext
    {
        public BBVAContext() : base("name=codemasters")
        {
        }

        public virtual DbSet<BBVA_Table> BBVAApi { get; set; }
    }
}

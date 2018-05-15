using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using codemasters.Domain.Entities.Stats;

namespace codemasters.BusinessLogic.DBModel
{
    public class UCLContext : DbContext
    {
        public UCLContext() : base("name=codemasters")
        {
        }

        public virtual DbSet<UCL_Table> UCLApi { get; set; }
    }
}

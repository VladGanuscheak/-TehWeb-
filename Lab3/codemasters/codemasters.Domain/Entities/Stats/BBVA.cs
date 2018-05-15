using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemasters.Domain.Entities.Stats
{
    public class BBVA
    {
        public int Id { get; set; }
        public String Team { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Gols_scored { get; set; }
        public int Gols_received { get; set; }
        public int Points { get; set; }
    }
}

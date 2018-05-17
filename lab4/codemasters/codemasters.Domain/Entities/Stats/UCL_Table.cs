using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codemasters.Domain.Entities.Stats
{
    public class UCL_Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String Team { get; set; }

        [Required]
        [StringLength(50)]
        public String Year { get; set; }

        [Required]
        [StringLength(50)]
        public String League { get; set; }
    }
}

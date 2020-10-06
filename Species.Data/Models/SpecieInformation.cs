using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Species.Data.Models
{
    public class SpecieInformation
    {
        [Key]
        [MaxLength(2)]
        public int Id { get; set; }
        public int LocationId { get; set; }

        public int SpecieId { get; set; }
        public Specie Species { get; set; }
        public Location Location { get; set; }
    }
}

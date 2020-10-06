using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Species.Data.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MapFile { get; set; }

        [Required]
        public int SubCountyId { get; set; }
        public virtual SubCounty SubCounty { get; set; }

        public virtual ICollection<Specie> Species { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Species.Data.Models
{
    public class SubCounty
    {
        public int Id { get; set; }

        public string Name { get; set; }


        [Required]
        public int CountyId { get; set; }
        public virtual County County { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}

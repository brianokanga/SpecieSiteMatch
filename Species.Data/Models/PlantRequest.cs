using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Species.Data.Models
{
    public class PlantRequest
    {
        public int Id { get; set; }

        public int CountyId { get; set; }
        public County County { get; set; }
        
        public SubCounty SubCounty { get; set; }
        public Location Location { get; set; }
        public Specie Specie { get; set; }
    }
}

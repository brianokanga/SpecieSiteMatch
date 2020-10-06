using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Species.Data.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<SubCounty> SubCounties { get; set; }
    }
}

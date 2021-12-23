using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSystem.Models
{
    public class SubCatagorey
    {
        [Key]
        public int Id { get; set; }
        public int CategId { get; set; }
        public string SubCatName { get; set; }
    }
}

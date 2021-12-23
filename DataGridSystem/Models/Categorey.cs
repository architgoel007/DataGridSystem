using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataGridSystem.Models
{
    public class Categorey
    {
        [Key]
        public int Id { get; set; }
        public string CatName { get; set; }
    }
}

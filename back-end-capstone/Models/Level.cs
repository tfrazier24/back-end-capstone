using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_capstone.Models
{
    public class Level
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string LevelName { get; set; }

    }
}

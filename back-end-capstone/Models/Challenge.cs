using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_capstone.Models
{
    public class Challenge
    {
        public int Id { get; set; }

        
        public int LevelId { get; set; }


        [MaxLength(255)]
        public string Name { get; set; }
        public int Attempts { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string UrlLink { get; set; }
    }
}

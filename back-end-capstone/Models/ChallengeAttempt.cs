using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace back_end_capstone.Models
{
    public class ChallengeAttempt
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChallengeId { get; set; }
        public int Attempts { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

    }
}


﻿using System.ComponentModel.DataAnnotations;

namespace Between.Server.App.Models.Candidates.CandidateIncomes
{
    public class CandidateIncome
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Source { get; set; }

        public decimal Amount { get; set; }

        public string? UserId { get; set; } = null;
    }
}

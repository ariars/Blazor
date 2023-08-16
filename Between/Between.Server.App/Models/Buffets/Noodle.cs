﻿using System.ComponentModel.DataAnnotations;

namespace Between.Server.App.Models.Buffets
{
    public class Noodle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string? Name { get; set; }

        [Required]
        public int? BrothId { get; set; }

        public Broth? Broth { get; set; }
    }
}

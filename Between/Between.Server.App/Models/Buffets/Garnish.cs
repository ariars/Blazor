using System.ComponentModel.DataAnnotations;

namespace Between.Server.App.Models.Buffets
{
    public class Garnish
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string? Name { get; set; }

        public int? NoodleId { get; set; }

        public Noodle? Noodle { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ADO.NET_PW_5.Models {
    public class Studio {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public ICollection<Game>? Games { get; set; } = new List<Game>();

        public override string ToString() {
            var str = Games!.Aggregate("", (current, game) => current + ('\n' + game.Title));

            return $"{Name} {str}";
        }
    }
}
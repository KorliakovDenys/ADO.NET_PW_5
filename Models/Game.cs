using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO.NET_PW_5.Models {
    public class Game {
        [Key] public int Id { get; set; }

        [Required] public string? Title { get; set; }

        public int StudioId { get; set; }

        public int StyleId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int GameModeId { get; set; }

        public int CopiesSold { get; set; }

        [ForeignKey("GameModeId")] public GameMode? GameMode { get; set; }

        [ForeignKey("StudioId")] public Studio? Studio { get; set; }

        [ForeignKey("StyleId")] public Style? Style { get; set; }

        public override string ToString() {
            return $"{Id} {Title} {StudioId} {StyleId} {ReleaseDate} {Studio?.Name} {Style?.Name}";
        }
    }
}
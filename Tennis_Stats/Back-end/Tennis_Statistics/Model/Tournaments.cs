using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Tournaments
    {
        [Key]
        public int TournamentID { get; set; }
        public string? TournamentName { get; set; }
        public string? Country { get; set; }
        public int Rounds { get; set; }
        public int? SurfaceID { get; set; }
        public int? LevelID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Surface? Surface { get; set; }
        public virtual Level? Level { get; set; }
    }
}

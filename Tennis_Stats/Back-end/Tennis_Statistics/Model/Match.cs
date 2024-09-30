using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Match
    {
        [Key]
        public int MatchID { get; set; }
        public string? Player1 { get; set; }
        public string? Player2 { get; set; }
        public int ScorePlayer1 { get; set; }
        public int ScorePlayer2 { get; set; }
        public int? TournamentID { get; set; }
        public int? SeasonID { get; set; }
        public int? WeekID { get; set; }
        public TimeOnly MatchTime { get; set; }
        public int? ResultID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Season? Season { get; set; }
        public virtual Week? Week { get; set; }
        public virtual Result? Result { get; set; }
        public virtual ICollection<MatchDetail> MatchDetails { get; set; } = new List<MatchDetail>();
    }
}

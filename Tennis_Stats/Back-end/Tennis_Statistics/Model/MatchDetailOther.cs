using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class MatchDetailOther
    {
        [Key]
        public int MatchDetailOtherID { get; set; }
        public int AcesPlayer1 { get; set; }
        public int AcesPlayer2 { get; set; }
        public int DoubleFaultsPlayer1 { get; set; }
        public int DoubleFaultsPlayer2 { get; set; }
        public float FirstServePlayer1 { get; set; }
        public float FirstServePlayer2 { get; set; }
        public float FirstServeWonPlayer1 { get; set; }
        public float FirstServeWonPlayer2 { get; set; }
        public float SecondServeWonPlayer1 { get; set; }
        public float SecondServeWonPlayer2 { get; set; }
        public int WinnersPlayer1 { get; set; }
        public int WinnersPlayer2 { get; set; }
        public int UnforcedErrorsPlayer1 { get; set; }
        public int UnforcedErrorsPlayer2 { get; set; }
        public string? BreakPointsWonPlayer1 { get; set; }
        public string? BreakPointsWonPlayer2 { get; set; }
        public float FastestServePlayer1 { get; set; }
        public float FastestServePlayer2 { get; set; }
        public int AvgFirstServeSpeedPlayer1 { get; set; }
        public int AvgFirstServeSpeedPlayer2 { get; set; }
        public int AvgSecondServeSpeedPlayer1 { get; set; }
        public int AvgSecondServeSpeedPlayer2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<MatchDetail> MatchDetails { get; set; } = new List<MatchDetail>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class MatchDetail
    {
        [Key]
        public int MatchDetailID { get; set; }
        public int? MatchID { get; set; }
        public int ScoreSet1Player1 { get; set; }
        public int ScoreSet1Player2 { get; set; }
        public int ScoreSet2Player1 { get; set; }
        public int ScoreSet2Player2 { get; set; }
        public int? ScoreSet3Player1 { get; set; }
        public int? ScoreSet3Player2 { get; set; }
        public int? ScoreSet4Player1 { get; set; }
        public int? ScoreSet4Player2 { get; set; }
        public int? ScoreSet5Player1 { get; set; }
        public int? ScoreSet5Player2 { get; set; }
        public int? MatchDetailOtherID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Match? Match { get; set; }
        public virtual MatchDetailOther? MatchDetailOther { get; set; }
    }
}

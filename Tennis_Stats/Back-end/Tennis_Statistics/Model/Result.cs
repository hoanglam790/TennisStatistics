using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Result
    {
        [Key]
        public int ResultID { get; set; }
        public string? ResultName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<Match> Matches { get; set; } = new List<Match>();

    }
}

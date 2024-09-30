using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }
        public string? SeasonName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}

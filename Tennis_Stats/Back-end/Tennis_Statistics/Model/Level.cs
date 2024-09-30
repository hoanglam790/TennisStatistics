using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Level
    {
        [Key]
        public int LevelID { get; set; }
        public string? LevelName { get; set; }
        public string? LevelStars { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<Tournaments> Tournaments { get; set; } = new List<Tournaments>();

    }
}

using System.ComponentModel.DataAnnotations;

namespace Tennis_Statistics.Model
{
    public class Surface
    {
        [Key]
        public int SurfaceID { get; set; }
        public string? SurfaceName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<Tournaments> Tournaments { get; set; } = new List<Tournaments>();

    }
}

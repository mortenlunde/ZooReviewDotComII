using System.ComponentModel.DataAnnotations;

namespace ZooReviewDotComII.Models
{
    public class Zoo
    {
        [Key]
        public Guid ZooId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Town { get; set; } = string.Empty;

        public double AvgRating { get; set; }
        public byte[]? Image { get; set; }

        public virtual List<Review> Reviews { get; set; } = new();
        public double CalculateAvgRating() => Reviews.Any() ? Reviews.Average(r => r.Rating) : 0;
    }
}

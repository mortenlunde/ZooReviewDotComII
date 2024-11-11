using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ZooReviewDotComII.Models
{
    public class Review
    {
        [Key]
        public Guid ReviewId { get; set; }

        public string Username { get; set; } = string.Empty;

        [Required, ForeignKey("ZooId")]
        public Guid ZooId { get; set; }

        [Required, Range(1, 5)]
        public double Rating { get; set; }

        [StringLength(500)]
        public string? Content { get; set; } = string.Empty;

        public DateTime DateReviewed { get; set; }

        public virtual Zoo? Zoo { get; init; }

        [StringLength(50)]
        [NotMapped]
        public string ZooName => Zoo?.Name ?? "Unknown Zoo";
    }
}

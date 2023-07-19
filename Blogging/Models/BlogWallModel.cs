using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWallMicroService.Models
{
    public class BlogWallModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public byte[]? DescImage { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set;}

    }
}

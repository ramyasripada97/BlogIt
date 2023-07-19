namespace BlogWallMicroService.ViewModels
{
    public class BlogWallViewModel
    {
        public Guid? Id { get; set; }
        public string? Description { get; set; }
        public byte[]? DescImage { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public IFormFile? Image { get; set; }
    }
}

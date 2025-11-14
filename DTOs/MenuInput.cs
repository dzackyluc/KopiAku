namespace KopiAku.DTOs
{
    public class MenuInput
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
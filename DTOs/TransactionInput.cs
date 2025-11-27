namespace KopiAku.DTOs
{
    public class TransactionInput
    {
        public string UserId { get; set; } = null!;
        public List<TransactionMenuItemInput> MenuItems { get; set; } = new();
        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = null!;

        public DateTime TransactionDate { get; set; }
    }
    public class TransactionMenuItemInput
    {
        public string MenuId { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
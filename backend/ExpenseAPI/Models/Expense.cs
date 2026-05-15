namespace ExpenseAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string Category { get; set; } = string.Empty;
        // Categories: Food, Travel, Shopping, Bills, Other

        public DateTime Date { get; set; }

        public string Notes { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
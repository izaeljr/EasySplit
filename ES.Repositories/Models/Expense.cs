namespace EasySplit.ES.Repositories.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public decimal Value { get; set; }
    }
}

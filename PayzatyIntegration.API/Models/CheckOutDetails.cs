namespace PayzatyIntegration.API.Models
{
    public class CheckOutDetails
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}

namespace PayzatyIntegration.API.Models
{
    public class CheckOutDetailsDTO
    {
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Language { get; set; }
        public string Reference { get; set; }
        public Customer Customer { get; set; }
        public string Response_url { get; set; }
        public string Cancel_url { get; set; }
    }
}

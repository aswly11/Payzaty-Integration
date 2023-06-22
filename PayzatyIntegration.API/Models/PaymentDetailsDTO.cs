namespace PayzatyIntegration.API.Models
{
    public class PaymentDetailsDTO
    {    
        /// <summary>
        /// checkout details amount of money
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// checkout details currency
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// checkout details language
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// checkout details reference
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// checkout customer information
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// checkout response url
        /// </summary>
        public string Response_url { get; set; }
        /// <summary>
        /// checkout cancellation url
        /// </summary>
        public string Cancel_url { get; set; }
    }
}

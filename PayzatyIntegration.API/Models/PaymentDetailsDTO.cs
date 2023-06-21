namespace PayzatyIntegration.API.Models
{
    public class PaymentDetailsDTO
    {    
        /// <summary>
        /// checkout details amount of money
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// checkout details currency
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// checkout details language
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// checkout details reference
        /// </summary>
        public string reference { get; set; }
        /// <summary>
        /// checkout customer information
        /// </summary>
        public Customer customer { get; set; }
        /// <summary>
        /// checkout response url
        /// </summary>
        public string response_url { get; set; }
        /// <summary>
        /// checkout cancellation url
        /// </summary>
        public string cancel_url { get; set; }
    }
}

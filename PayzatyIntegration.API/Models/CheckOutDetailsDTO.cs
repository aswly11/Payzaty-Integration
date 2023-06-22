namespace PayzatyIntegration.API.Models
{
    public class CheckOutDetailsDTO
    {
        /// <summary>
        /// checkout details id
        /// </summary>
        public string Id { get; set; }
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
        /// checkout paid or not
        /// </summary>
        public bool Paid { get; set; }
        /// <summary>
        /// checkout status
        /// </summary>
        public string Status { get; set; }
    }
}
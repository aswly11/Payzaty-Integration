namespace PayzatyIntegration.API.Models
{
    /// <summary>
    /// Represents the payment details.
    /// </summary>
    public class CardPaymentDetailsDTO
    {
        /// <summary>
        /// Gets or sets the amount of money.
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        public string payment_method { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        public string reference { get; set; }

        /// <summary>
        /// Gets or sets the customer information.
        /// </summary>
        public Customer customer { get; set; }

        /// <summary>
        /// Gets or sets the card information.
        /// </summary>
        public Card card { get; set; }

        /// <summary>
        /// Gets or sets the response URL.
        /// </summary>
        public string response_url { get; set; }
    }
}

namespace PayzatyIntegration.API.Models
{
    /// <summary>
    /// Represents the response for a card payment.
    /// </summary>
    public class CardPaymentResponse
    {
        /// <summary>
        /// Gets or sets the checkout ID.
        /// </summary>
        public string checkout_id { get; set; }

        /// <summary>
        /// Gets or sets the authentication URL.
        /// </summary>
        public string authentication_url { get; set; }
    }
}

namespace PayzatyIntegration.API.Models
{
    /// <summary>
    /// Represents a payment card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Gets or sets the name associated with the card.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the card's expiry date.
        /// </summary>
        public Expiry expiry { get; set; }

        /// <summary>
        /// Gets or sets the Card Verification Value (CVV) code.
        /// </summary>
        public string cvv { get; set; }
    }
}

namespace PayzatyIntegration.API.Models
{
    /// <summary>
    /// Represents the expiry date of a card.
    /// </summary>
    public class Expiry
    {
        /// <summary>
        /// Gets or sets the month of the expiry date.
        /// </summary>
        public string month { get; set; }

        /// <summary>
        /// Gets or sets the year of the expiry date.
        /// </summary>
        public string year { get; set; }
    }
}

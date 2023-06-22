namespace PayzatyIntegration.API.Models
{
    public class RecurringPaymentDTO
    {
        /// <summary>
        /// Recurring Payment details amount of money
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Recurring Payment details currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Recurring Payment details reference
        /// </summary>
        public string Reference { get; set; }
    }
}

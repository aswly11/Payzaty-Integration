namespace PayzatyIntegration.API.Models
{
    public class RecurringPaymentResultDTO
    {
        /// <summary>
        /// Recurring Payment details Id of money
        /// </summary>
        public int Id { get; set; }
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

        public Customer Customer { get; set; }
        /// <summary>
        /// Recurring Payment paid
        /// </summary>
        public bool Paid { get; set; }
        /// <summary>
        /// Recurring Payment details currency
        /// </summary>
        public PaymentStatusEnum status { get; set; }

    }
}

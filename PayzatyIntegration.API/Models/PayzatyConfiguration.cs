namespace PayzatyIntegration.API.Models
{
    public class PayzatyConfiguration
    {
        public string PayzatyUrl { get; set; }
        public string payzatyAccountNo { get; set; }
        public string payzatySecretKey { get; set; }

        public static readonly string X_AccountNo = "X-AccountNo";
        public static readonly string X_SecretKey = "X-SecretKey";
    }
}

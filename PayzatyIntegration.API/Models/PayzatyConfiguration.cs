using PayzatyIntegration.API.Services;

namespace PayzatyIntegration.API.Models
{
    public class PayzatyConfiguration
    {
        public string PayzatyUrl { get; set; }

        public string PayzatyAccountNo { get; set; }
        public string PayzatySecretKey { get; set; }


        public static readonly string X_AccountNo = "X-AccountNo";
        public static readonly string X_SecretKey = "X-SecretKey";
    }
}

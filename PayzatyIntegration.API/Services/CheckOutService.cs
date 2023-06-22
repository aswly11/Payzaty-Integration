using Microsoft.Extensions.Options;
using PayzatyIntegration.API.Models;
using System.Text;
using System.Text.Json;

namespace PayzatyIntegration.API.Services
{
    public class CheckOutService : ICheckOutService
    {

        private HttpClient httpClient;
        private readonly PayzatyConfiguration _payzatyConfiguration;

        public CheckOutService(IOptions<PayzatyConfiguration> payzatyConfiguration)
        {
            _payzatyConfiguration = payzatyConfiguration.Value;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_AccountNo, _payzatyConfiguration.PayzatyAccountNo);
            httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_SecretKey, _payzatyConfiguration.PayzatySecretKey);

        }
        public async Task<SecuredPageResponse> RequestSecuredPaymentPage(PaymentDetailsDTO checkOutDetailsDTO)
        {
            var checkOutDetailsJson = JsonSerializer.Serialize(checkOutDetailsDTO); ;
            var content = new StringContent(checkOutDetailsJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(_payzatyConfiguration.PayzatyUrl + "checkout", content);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<SecuredPageResponse>(responseBody);
            }

            return null;
        }

        public async Task<CheckOutDetailsDTO> GetCheckOutDetailsById(string checkOutDetailsId)
        {
            var response = await httpClient.GetAsync($"{_payzatyConfiguration.PayzatyUrl}checkout/{checkOutDetailsId}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<CheckOutDetailsDTO>(responseBody);
            }

            return null;
        }

        public async Task<RecurringPaymentDTO> ApplyRecurringPayments(string subscriptionId, RecurringPaymentDTO recurringPayment)
        {
            var recurringPaymentJson = JsonSerializer.Serialize(recurringPayment); ;
            var payment = new StringContent(recurringPaymentJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync($"{_payzatyConfiguration.PayzatyUrl}subscription/{subscriptionId}/pay", payment);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<RecurringPaymentDTO>(responseBody);
            }

            return null;
        }
    }
}

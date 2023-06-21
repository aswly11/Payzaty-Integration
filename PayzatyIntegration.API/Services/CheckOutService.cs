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
            httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_AccountNo, _payzatyConfiguration.payzatyAccountNo);
            httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_SecretKey, _payzatyConfiguration.payzatySecretKey);

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

        public async Task<CheckOutDetailsDTO> GetCheckOutDetailsById(string CheckOutDetailsId)
        {
            var response = await httpClient.GetAsync($"{_payzatyConfiguration.PayzatyUrl}checkout/{CheckOutDetailsId}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<CheckOutDetailsDTO>(responseBody);
            }

            return null;
        }
    }
}

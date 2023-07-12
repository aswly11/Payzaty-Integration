using Microsoft.Extensions.Options;
using PayzatyIntegration.API.Interfaces;
using PayzatyIntegration.API.Models;
using System.Text.Json;

namespace PayzatyIntegration.API.Services
{
	public class CardService : ICardService
	{
		private HttpClient httpClient;
		private readonly PayzatyConfiguration _payzatyConfiguration;

		public CardService(IOptions<PayzatyConfiguration> payzatyConfiguration)
		{
			_payzatyConfiguration = payzatyConfiguration.Value;
			httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_AccountNo, _payzatyConfiguration.payzatyAccountNo);
			httpClient.DefaultRequestHeaders.Add(PayzatyConfiguration.X_SecretKey, _payzatyConfiguration.payzatySecretKey);

		}
		public async Task<CardDetails> CheckCardDetails(string cardBin)
		{
			var response = await httpClient.PostAsync(_payzatyConfiguration.PayzatyUrl + $"card/check/{cardBin}",null);
			if (response.IsSuccessStatusCode)
			{
				string responseBody = await response.Content.ReadAsStringAsync();

				return JsonSerializer.Deserialize<CardDetails>(responseBody);
			}

			return null;
		}
	}
}

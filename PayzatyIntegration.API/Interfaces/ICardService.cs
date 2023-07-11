using PayzatyIntegration.API.Models;

namespace PayzatyIntegration.API.Interfaces
{
	public interface ICardService
	{
		Task<CardDetails> CheckCardDetails(string cardBin);
	}
}

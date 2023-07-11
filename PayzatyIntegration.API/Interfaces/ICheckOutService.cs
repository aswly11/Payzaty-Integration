using PayzatyIntegration.API.Models;

namespace PayzatyIntegration.API.Interfaces
{
	public interface ICheckOutService
	{
		Task<SecuredPageResponse> RequestSecuredPaymentPage(PaymentDetailsDTO checkOutDetails);
		Task<CheckOutDetailsDTO> GetCheckOutDetailsById(string CheckOutDetailsId);
	}
}

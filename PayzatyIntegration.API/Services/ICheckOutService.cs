using PayzatyIntegration.API.Models;

namespace PayzatyIntegration.API.Services
{
    public interface ICheckOutService
    {
        Task<SecuredPageResponse> RequestSecuredPaymentPage(CheckOutDetailsDTO checkOutDetails);
        CheckOutDetails GetCheckOutDetailsById(string CheckOutDetailsId);
    }
}

using PayzatyIntegration.API.Models;

namespace PayzatyIntegration.API.Services
{
    public interface ICheckOutService
    {
        Task<SecuredPageResponse> RequestSecuredPaymentPage(PaymentDetailsDTO checkOutDetails);
        Task<CheckOutDetailsDTO> GetCheckOutDetailsById(string CheckOutDetailsId);
        Task<RecurringPaymentDTO> ApplyRecurringPayments(string CheckOutDetailsId);
    }
}

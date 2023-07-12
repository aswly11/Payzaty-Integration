using PayzatyIntegration.API.Models;

namespace PayzatyIntegration.API.Interfaces
{
    public interface ICheckOutService
    {
        Task<SecuredPageResponse> RequestSecuredPaymentPage(PaymentDetailsDTO checkOutDetails);
        Task<CheckOutDetailsDTO> GetCheckOutDetailsById(string CheckOutDetailsId);

        /// <summary>
        /// Sends a payment request using the provided card payment details.
        /// </summary>
        Task<CardPaymentResponse> RequestCardPayment(CardPaymentDetailsDTO cardPaymentDetailsDTO);
    }
}

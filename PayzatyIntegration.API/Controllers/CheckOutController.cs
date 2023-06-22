using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayzatyIntegration.API.Models;
using PayzatyIntegration.API.Services;

namespace PayzatyIntegration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]        
    public class CheckOutController : ControllerBase
    {
        private readonly ICheckOutService _checkOutService;
        public CheckOutController(ICheckOutService checkOutService)
        { 
            _checkOutService = checkOutService;
        }

        [HttpPost("RequestSecuredPaymentPage")]
        public async Task<IActionResult> RequestSecuredPaymentPage([FromBody] PaymentDetailsDTO checkOutDetailsDTO)
        {
            var SecurePage= await _checkOutService.RequestSecuredPaymentPage(checkOutDetailsDTO);
            if(SecurePage != null)
            {
                return Ok(SecurePage);
            } 
            return BadRequest("Something Went Wrong!");
        }

        [HttpGet("CheckoutDetails")]
        public async Task<IActionResult> GetCheckoutDetails([FromQuery] string checkOutId)
        {
            var securePage = await _checkOutService.GetCheckOutDetailsById(checkOutId);
            if (securePage != null)
            {
                return Ok(securePage);
            }
            return BadRequest("Something Went Wrong!");
        }

        [HttpGet("RecurringPayments")]
        public async Task<IActionResult> RecurringPayments([FromQuery] string subscription_id)
        {
            var SecurePage = await _checkOutService.ApplyRecurringPayments(subscription_id);
            if (SecurePage != null)
            {
                return Ok(SecurePage);
            }
            return BadRequest("Something Went Wrong!");
        }
    }
}
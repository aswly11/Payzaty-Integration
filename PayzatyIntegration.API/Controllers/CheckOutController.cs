﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayzatyIntegration.API.Models;
using PayzatyIntegration.API.Services;
using PayzatyIntegration.API.Interfaces;

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
        public async Task<IActionResult> GetCheckoutDetails([FromQuery] string CheckOutId)
        {
            var SecurePage = await _checkOutService.GetCheckOutDetailsById(CheckOutId);
            if (SecurePage != null)
            {
                return Ok(SecurePage);
            }
            return BadRequest("Something Went Wrong!");
        }
	}
}

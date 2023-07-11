using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayzatyIntegration.API.Interfaces;

namespace PayzatyIntegration.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CardController : ControllerBase
	{ 
		private readonly ICardService _cardService;
		public CardController (ICardService cardService)
		{
			_cardService = cardService; 
		}

		[HttpPost("check")]
		public async Task<IActionResult> CheckCardDetails([FromQuery] string CardBin)
		{
			var CardDetails = await _cardService.CheckCardDetails(CardBin);
			if (CardDetails != null)
			{
				return Ok(CardDetails);
			}
			return BadRequest("Something Went Wrong!");
		}
	}
}

using FactoryPatternSample.Core.Enum;
using FactoryPatternSample.Core.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatternSample.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PaymentsController : ControllerBase
	{

		private readonly PaymentChannelFactory _paymentFactory;

		public PaymentsController(PaymentChannelFactory paymentFactory)
		{
			this._paymentFactory = paymentFactory;
		}
		[HttpGet("payments")]
		public IActionResult GetPayments([FromQuery] PaymentChannels channel)
		{
			return Ok(_paymentFactory.GetPaymentService(channel).RetrievePayments());
		}
		[HttpGet("communication-channel")]
		public IActionResult GetCommunicationChannel([FromQuery] PaymentChannels channel)
		{
			return Ok(_paymentFactory.GetPaymentService(channel).CommunicationChannel());
		}
	}
}

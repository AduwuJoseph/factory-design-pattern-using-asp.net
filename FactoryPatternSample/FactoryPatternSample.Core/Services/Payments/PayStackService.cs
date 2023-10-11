using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Payments
{
	public class PayStackService : IPaymentChannel
	{
		public string CommunicationChannel()
		{
			return "paystack communication channel not implemented";
		}

		public string RetrievePayments()
		{
			return "paystack all payments";
		}
	}
}

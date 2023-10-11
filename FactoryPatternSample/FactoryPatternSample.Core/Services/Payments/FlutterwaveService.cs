using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Payments
{
	public class FlutterwaveService : IPaymentChannel
	{
		public string CommunicationChannel()
		{
			return "Flutterwave communication channel not implemented";
		}

		public string RetrievePayments()
		{
			return "Flutterwave all payments";
		}
	}
}

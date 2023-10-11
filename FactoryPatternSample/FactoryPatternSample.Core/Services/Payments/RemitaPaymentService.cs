using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Payments
{
	public class RemitaPaymentService : IPaymentChannel
	{
		public string CommunicationChannel()
		{
			return "not implemented";
		}

		public string RetrievePayments()
		{
			return "Remita all payments";
		}
	}
}

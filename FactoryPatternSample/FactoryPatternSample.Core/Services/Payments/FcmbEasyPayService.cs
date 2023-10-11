using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Payments
{
	public class FcmbEasyPayService : IPaymentChannel
	{
		private readonly IFcmbEasyPayHelper _helper;
        public FcmbEasyPayService(IFcmbEasyPayHelper helper) => _helper = helper;
        public string CommunicationChannel()
		{
			return _helper.getCommunicationChannel();
		}

		public string RetrievePayments()
		{
			return _helper.getPayments();
		}
	}
}

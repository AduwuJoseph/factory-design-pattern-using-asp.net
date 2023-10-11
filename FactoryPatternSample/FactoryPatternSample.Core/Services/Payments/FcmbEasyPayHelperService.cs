using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Payments
{
	public class FcmbEasyPayHelperService : IFcmbEasyPayHelper
	{
		public string getCommunicationChannel()
		{
			return "TCP";
		}

		public string getPayments()
		{
			return "All FCMB Easy Pay payments";
		}
	}
}

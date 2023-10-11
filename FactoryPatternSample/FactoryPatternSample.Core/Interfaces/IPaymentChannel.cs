using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Interfaces
{
	public interface IPaymentChannel
	{
		string RetrievePayments();
		string CommunicationChannel();
	}
}

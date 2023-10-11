using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Enum
{
	public enum PaymentChannels
	{
		[Description("FcmbEasyPay")]
		FcmbEasyPay,
		[Description("Paystack")]
		Paystack,
		[Description("Flutterwave")]
		Flutterwave,
		[Description("Remita")]
		Remita
	}
}

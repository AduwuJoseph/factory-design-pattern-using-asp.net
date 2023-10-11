using FactoryPatternSample.Core.Enum;
using FactoryPatternSample.Core.Interfaces;
using FactoryPatternSample.Core.Services.Movies;
using FactoryPatternSample.Core.Services.Payments;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Factory
{
	public class PaymentChannelFactory
	{
		private readonly IServiceProvider serviceProvider;

		public PaymentChannelFactory(IServiceProvider serviceProvider)
		{
			this.serviceProvider = serviceProvider;
		}

		public IPaymentChannel GetPaymentService(PaymentChannels channels)
		{
			switch (channels)
			{
				case PaymentChannels.FcmbEasyPay:
					return (IPaymentChannel)serviceProvider.GetService(typeof(FcmbEasyPayService));
				case PaymentChannels.Paystack:
					return (IPaymentChannel)serviceProvider.GetService(typeof(PayStackService));
				case PaymentChannels.Remita:
					return (IPaymentChannel)serviceProvider.GetService(typeof(RemitaPaymentService));
				case PaymentChannels.Flutterwave:
					return (IPaymentChannel)serviceProvider.GetService(typeof(RemitaPaymentService));
				default:
					throw new ArgumentException("Invalid payment type.");
			}
		}
	}
}

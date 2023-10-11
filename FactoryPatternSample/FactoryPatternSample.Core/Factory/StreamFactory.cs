using FactoryPatternSample.Core.Enum;
using FactoryPatternSample.Core.Interfaces;
using FactoryPatternSample.Core.Services.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Factory
{
	public class StreamFactory
	{
		public IStreamService GetStreamService(StreamingType type)
		{
			if (StreamingType.Netflix == type)
			{
				return new NetflixStreamService();
			}
			else
			{
				return new AmazonStreamService();
			}
		}
	}
}

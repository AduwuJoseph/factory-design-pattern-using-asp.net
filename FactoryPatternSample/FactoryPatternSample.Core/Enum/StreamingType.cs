using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Enum
{
	public enum StreamingType
	{
		[Description("Netflix")]
		Netflix,
		[Description("Amazon")]
		Amazon
	}
}

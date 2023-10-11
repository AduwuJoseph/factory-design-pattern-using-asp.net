using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Movies
{
	public class AmazonStreamService : IStreamService
	{
		public string[] ShowMovies()
		{
			return new string[]
			{
			"Amazon Movie A",
			"Amazon Movie B",
			"Amazon Movie C"
			};
		}
	}
}

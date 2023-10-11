using FactoryPatternSample.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample.Core.Services.Movies
{
    public class NetflixStreamService : IStreamService
    {
        public string[] ShowMovies()
        {
            return new string[]
            {
            "Netflix Movie 1",
            "Netflix Movie 2",
            "Netflix Movie 3"
            };
        }
    }
}

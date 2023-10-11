using FactoryPatternSample.Core.Enum;
using FactoryPatternSample.Core.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatternSample.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StreamsController : ControllerBase
	{

		private readonly StreamFactory _streamFactory;

		public StreamsController(StreamFactory streamFactory)
		{
			this._streamFactory = streamFactory;
		}
		[HttpGet("movies")]
		public IEnumerable<string> GetMovies([FromQuery] StreamingType streamChannel)
		{
			return _streamFactory.GetStreamService(streamChannel).ShowMovies();
		}
	}
}

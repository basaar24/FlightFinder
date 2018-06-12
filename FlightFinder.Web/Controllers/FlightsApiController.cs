using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlightFinder.Web.Controllers
{
    using BusinessInterfaces;
    using System.Threading.Tasks;
    using Types.Exceptions;

    public class FlightsApiController : ApiController
    {
        private readonly IFlightsProcessor _flightsProcessor;
        public FlightsApiController(IFlightsProcessor flightsProcessor)
        {
            _flightsProcessor = flightsProcessor;
        }

        // GET api/<controller>
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var result = await _flightsProcessor.GetAll();
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (BusinessLayerException ex)
            {
                var errors = default(string);
                foreach (var item in ex.Errors)
                {
                    errors += item;
                }
                return BadRequest(errors);
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
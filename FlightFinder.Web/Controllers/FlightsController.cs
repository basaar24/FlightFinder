using System;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace FlightFinder.Web.Controllers
{
    using BusinessInterfaces;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using Types;

    public class FlightsController : Controller
    {
        private readonly IFlightsProcessor _flightsProcessor;

        public FlightsController(IFlightsProcessor flightsProcessor)
        {
            _flightsProcessor = flightsProcessor;
        }

        // GET: Flights
        public async Task<ViewResult> Index()
        {
            var flights = await _flightsProcessor.GetAll();

            return View(flights);
        }

        public ActionResult ApiIndex()
        {
            IEnumerable<FlightDto> flights = null;

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:2394/api");
                var responseTask = httpClient.GetAsync("api/flightsapi");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<FlightDto>>();
                    readTask.Wait();

                    flights = readTask.Result;
                }
                else
                {
                    flights = Enumerable.Empty<FlightDto>();

                    ModelState.AddModelError(string.Empty, "There was an error while retrieving the flights.");
                }

            }
            return View(flights);
        }
    }
}
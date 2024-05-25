using ABPD5.DTO.Requests;
using ABPD5.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ABPD5.Controllers
{

    [ApiController]
    [Route("api/trips")]
    public class TripsController : ControllerBase
    {
        private readonly ITripsHandler _tripsHandler;

        public TripsController(ITripsHandler tripsHandler)
        {
            _tripsHandler = tripsHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetTripsFromDbAsync()
        {
            var res = await _tripsHandler.GetTripsAsync();

            return Ok(res);
        }

        [HttpPost("{idTrip}/clients")]
        public async Task<IActionResult> UpdateClients(ClientDTO clients)
        {
            var result = await _tripsHandler.UpdateClients(clients);
            if (result)
            {
                return Ok("Client added");
            }

            return BadRequest("Client exists in database");
        }
    }
}

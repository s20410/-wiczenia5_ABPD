using ABPD5.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ABPD5.Controllers
{
    [ApiController]
    [Route("api/clients/")]

    public class ClientController(IClientHandler clientHandler) : ControllerBase
    {
        [HttpDelete("{idClient}")]
        public async Task<IActionResult> DeleteClient(int idClient)
        {
            var res = await clientHandler.DeleteClient(idClient);
            if (res)
            {
                return Ok("Client deleted");
            }

            return BadRequest("Client has trips or doesn't exists");
        }
    }
}
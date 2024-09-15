using Microsoft.AspNetCore.Mvc;
using MultiChannelAPI.Model;
using MultiChannelAPI.Services.Interfaces;

namespace MultiChannelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        internal async Task<IActionResult> CriarCliente([FromBody] Cliente cliente)
        {
            try
            {
                var novoCliente = await _clienteService.CriarClienteAsync(cliente);
                return Ok(novoCliente);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

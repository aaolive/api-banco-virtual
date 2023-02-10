using api_banco_virtual.Context;
using api_banco_virtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_banco_virtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BancoVirtualContext _context;

        public ClienteController(BancoVirtualContext context)
        {
            _context = context;
        }

        // Cadastra clientes
        [HttpPost("CadastrarCliente")]
        public IActionResult CadastrarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}

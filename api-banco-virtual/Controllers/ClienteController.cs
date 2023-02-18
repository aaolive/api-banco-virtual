using api_banco_virtual.Context;
using api_banco_virtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // Obtém um cliente
        [HttpGet("ObterCliente")]
        public IActionResult ObterCliente(int idCliente)
        {
            // procura o cliente e verifica se achou
            //var cliente = _context.Clientes
            //    .Include(c => c.ContaPoupanca)
            //    .FirstOrDefault(c => c.Id == idCliente);

            var cliente = _context.Clientes.Find(idCliente);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            return Ok(cliente);
        }
    }
}

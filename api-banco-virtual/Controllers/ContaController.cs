using api_banco_virtual.Context;
using api_banco_virtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_banco_virtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly BancoVirtualContext _context;

        public ContaController(BancoVirtualContext context)
        {
            _context=context;
        }


        // Ação para criar conta
        [HttpPost("CriarConta")]
        public IActionResult CriarConta(Conta conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();

            return Ok($"Conta criada {conta}");
        }

    }
}

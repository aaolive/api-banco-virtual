using api_banco_virtual.Context;
using api_banco_virtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_banco_virtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPoupancaController : ControllerBase
    {
        private readonly BancoVirtualContext _context;

        public ContaPoupancaController(BancoVirtualContext context)
        {
            _context = context;
        }

        // metodo do controller para listar contas poupança
        [HttpGet("ListarContasPoupanca")]
        public ActionResult<IEnumerable<ContaPoupanca>> ListarContasPoupanca()
        {
            var contasPoupanca = _context.ContasPoupanca.ToList();

            return contasPoupanca;
        }

        // metodo do controller para criar conta poupança
        [HttpPost("CriarContaPoupanca")]
        public IActionResult CriarContaPoupanca(ContaPoupanca contaPoupanca)
        {
            _context.ContasPoupanca.Add(contaPoupanca);
            _context.SaveChanges();

            return Ok("Conta criada.");
        }
    }
}

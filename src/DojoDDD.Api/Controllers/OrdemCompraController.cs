using DojoDDD.Api.DojoDDD.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DojoDDD.Api.Controllers
{
    [ApiController]
    [Route("ordemcompra")]
    public class OrdemCompraController : Controller
    {
        private readonly IOrdemCompraServico _ordemCompraServico;

        //private readonly IOrdemCompraRepositorio _ordemCompraRepositorio;
        // linha  Não é uma boa pratica colocar o repositório no controlador.

        public OrdemCompraController(IOrdemCompraServico ordemCompraServico, IOrdemCompraRepositorio ordemCompraRepositorio)
        {
            _ordemCompraServico = ordemCompraServico;
           // _ordemCompraRepositorio = ordemCompraRepositorio;
        }

        [HttpGet]
        [Route("{idOrdemCompra}")]//Alterando o padrão de nome GetById
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById([FromRoute] string idOrdemCompra)
        {
            try
            {
               // var result = await _ordemCompraRepositorio.ConsultarPorId(idOrdemCompra);
                var result = await _ordemCompraServico.ConsultarPorId(idOrdemCompra);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.ToString() });
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] OrdemCompra ordemCompra)
        {
            try
            {
                var result = await _ordemCompraServico.RegistrarOrdemCompra(ordemCompra.ClienteId, ordemCompra.ProdutoId, ordemCompra.QuantidadeSolicitada);
                return Created(string.Empty, result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.ToString() });
            }
        }
    }
}

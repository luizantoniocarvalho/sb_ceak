using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class OperacaoController : Controller
    {
        private readonly IOperacaoRepositorio _operacaoRepositorio;
        public OperacaoController(IOperacaoRepositorio operacaoRepositorio)
        {
            _operacaoRepositorio = operacaoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_operacaoRepositorio.ObterTodos());
                //if (condicao == false)
                //{
                //   return BadRequest("");
                //}
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Operacoes operacao)
        {
            try
            {
                _operacaoRepositorio.Adicionar(operacao);

                return Created("api/operacao", operacao);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

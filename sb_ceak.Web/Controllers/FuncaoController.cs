using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class FuncaoController : Controller
    {
        private readonly IFuncaoRepositorio _funcaoRepositorio;
        public FuncaoController(IFuncaoRepositorio funcaoRepositorio)
        {
            _funcaoRepositorio = funcaoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_funcaoRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Funcoes funcao)
        {
            try
            {
                _funcaoRepositorio.Adicionar(funcao);

                return Created("api/funcao", funcao);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

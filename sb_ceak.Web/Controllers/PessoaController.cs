using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_pessoaRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Pessoas pessoa)
        {
            try
            {
                _pessoaRepositorio.Adicionar(pessoa);

                return Created("api/pessoa", pessoa);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

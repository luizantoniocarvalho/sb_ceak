using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class TelefoneController : Controller
    {
        private readonly ITelefoneRepositorio _telefoneRepositorio;
        public TelefoneController(ITelefoneRepositorio telefoneRepositorio)
        {
            _telefoneRepositorio = telefoneRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_telefoneRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Telefones telefone)
        {
            try
            {
                _telefoneRepositorio.Adicionar(telefone);

                return Created("api/telefone", telefone);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

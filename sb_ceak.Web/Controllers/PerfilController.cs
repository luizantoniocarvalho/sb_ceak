using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class PerfilController : Controller
    {
        private readonly IPerfilRepositorio _perfilRepositorio;
        public PerfilController(IPerfilRepositorio perfilRepositorio)
        {
            _perfilRepositorio = perfilRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_perfilRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Perfis perfil)
        {
            try
            {
                _perfilRepositorio.Adicionar(perfil);

                return Created("api/perfil", perfil);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

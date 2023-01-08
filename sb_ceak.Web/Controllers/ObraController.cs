using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class ObraController : Controller
    {
        private readonly IObraRepositorio _obraRepositorio;
        public ObraController(IObraRepositorio obraRepositorio)
        {
            _obraRepositorio = obraRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_obraRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Obras obra)
        {
            try
            {
                _obraRepositorio.Adicionar(obra);

                return Created("api/obra", obra);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

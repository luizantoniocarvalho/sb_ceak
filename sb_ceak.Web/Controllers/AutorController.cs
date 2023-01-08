using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class AutorController : Controller
    {
        private readonly IAutorRepositorio _autorRepositorio;
        public AutorController(IAutorRepositorio autorRepositorio)
        {
            _autorRepositorio = autorRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_autorRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Autores autor)
        {
            try
            {
                _autorRepositorio.Adicionar(autor);

                return Created("api/autor", autor);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

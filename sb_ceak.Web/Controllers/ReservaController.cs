using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class ReservaController : Controller
    {
        private readonly IReservaRepositorio _reservaRepositorio;
        public ReservaController(IReservaRepositorio reservaRepositorio)
        {
            _reservaRepositorio = reservaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_reservaRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Reservas reserva)
        {
            try
            {
                _reservaRepositorio.Adicionar(reserva);

                return Created("api/reserva", reserva);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

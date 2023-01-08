using Microsoft.AspNetCore.Mvc;
using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using System;

namespace sb_ceak.Web.Controllers
{
    [Route("api/[controller]")]
    public class EmprestimoDevolucaoController : Controller
    {
        private readonly IEmprestimoDevolucaoRepositorio _emprestimoDevolucaoRepositorio;
        public EmprestimoDevolucaoController(IEmprestimoDevolucaoRepositorio emprestimoDevolucaoRepositorio)
        {
            _emprestimoDevolucaoRepositorio = emprestimoDevolucaoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_emprestimoDevolucaoRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]EmprestimoDevolucoes emprestimodevolucao)
        {
            try
            {
                _emprestimoDevolucaoRepositorio.Adicionar(emprestimodevolucao);

                return Created("api/emprestimodevolucao", emprestimodevolucao);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}

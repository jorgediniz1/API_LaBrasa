using LaBrasaAPI.Business;
using LaBrasaAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Controllers
{
    [Route("api/[controller]/")]
    public class FuncionarioController : Controller
    {
        private IFuncionarioBusiness _funcionarioBusinesss;

        public FuncionarioController(IFuncionarioBusiness funcionarioBusiness)
        {
            _funcionarioBusinesss = funcionarioBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_funcionarioBusinesss.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var funcionario = _funcionarioBusinesss.FindByID(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return BadRequest();
            }
            return Ok(_funcionarioBusinesss.Create(funcionario));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return BadRequest();
            }
            return Ok(_funcionarioBusinesss.Update(funcionario));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioBusinesss.Delete(id);
            return NoContent();
        }

    }
}

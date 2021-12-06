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
    public class ComandaController : Controller
    {
        private IComandaBusiness _comandaBusiness;

        public ComandaController(IComandaBusiness comandaBusiness)
        {
            _comandaBusiness = comandaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_comandaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var comanda = _comandaBusiness.FindByID(id);
            if (comanda == null)
            {
                return NotFound();
            }
            return Ok(comanda);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Comanda comanda)
        {
            if (comanda == null)
            {
                return BadRequest();
            }
            return Ok(_comandaBusiness.Create(comanda));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Comanda comanda)
        {
            if (comanda == null)
            {
                return BadRequest();
            }
            return Ok(_comandaBusiness.Update(comanda));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _comandaBusiness.Delete(id);
            return NoContent();
        }

    }
}

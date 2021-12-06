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
    public class MesaController : Controller
    {
        private IMesaBusiness _mesaBusiness;

        public MesaController(IMesaBusiness mesaBusiness)
        {
            _mesaBusiness = mesaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mesaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var mesa = _mesaBusiness.FindByID(id);
            if (mesa == null)
            {
                return NotFound();
            }
            return Ok(mesa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mesa mesa)
        {
            if (mesa == null)
            {
                return BadRequest();
            }
            return Ok(_mesaBusiness.Create(mesa));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Mesa mesa)
        {
            if (mesa == null)
            {
                return BadRequest();
            }
            return Ok(_mesaBusiness.Update(mesa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _mesaBusiness.Delete(id);
            return NoContent();
        }

    }
}

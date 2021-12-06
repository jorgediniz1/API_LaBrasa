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
    public class PedidoController : Controller
    {
        private IPedidoBusiness _pedidoBusiness;

        public PedidoController(IPedidoBusiness pedidoBusiness)
        {
            _pedidoBusiness = pedidoBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pedidoBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pedido = _pedidoBusiness.FindByID(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            if (pedido == null)
            {
                return BadRequest();
            }
            return Ok(_pedidoBusiness.Create(pedido));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Pedido pedido)
        {
            if (pedido == null)
            {
                return BadRequest();
            }
            return Ok(_pedidoBusiness.Update(pedido));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pedidoBusiness.Delete(id);
            return NoContent();
        }

    }
}

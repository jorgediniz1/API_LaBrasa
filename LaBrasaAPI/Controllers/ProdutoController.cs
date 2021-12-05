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
    public class ProdutoController : Controller
    {
        private IProdutoBusiness _ProdutoBusinesss;

        public ProdutoController(IProdutoBusiness produtoBusiness)
        {
            _ProdutoBusinesss = produtoBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ProdutoBusinesss.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _ProdutoBusinesss.FindByID(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }
            return Ok(_ProdutoBusinesss.Create(produto));
        }

        [HttpPut]

        public IActionResult Put([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }
            return Ok(_ProdutoBusinesss.Update(produto));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ProdutoBusinesss.Delete(id);
            return NoContent();
        }

    }
}

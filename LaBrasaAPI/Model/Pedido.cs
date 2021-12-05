using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public double ValorPedido { get; set; }
        public int ComandaPedidoId { get; set; }
        public Comanda ComandaPedido { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}

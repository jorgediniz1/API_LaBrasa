using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Repository
{
    public interface IPedidoRepository
    {
        List<Pedido> FindAll();
        Pedido FindByID(int idPedido);
        Pedido Create(Pedido pedido);
        Pedido Update(Pedido pedido);
        void Delete(int idPedido);
    }
}
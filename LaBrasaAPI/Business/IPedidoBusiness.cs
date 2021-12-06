using LaBrasaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Business
{
    public interface IPedidoBusiness
    {
        Pedido Create(Pedido pedido);
        Pedido FindByID(int idPedido);
        Pedido Update(Pedido pedido);
        void Delete(int idPedido);
        List<Pedido> FindAll();

        

        

    }
}

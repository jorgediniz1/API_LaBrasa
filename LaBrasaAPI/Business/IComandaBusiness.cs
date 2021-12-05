using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Business
{
    public interface IComandaBusiness
    {
        Comanda Create(Produto comanda);
        Comanda FindByID(int idComanda);
        Comanda Update(Produto comanda);
        void Delete(int idComanda);
        List<Comanda> FindAll();

        Pedido AddPedido(Pedido pedido);

    }
}
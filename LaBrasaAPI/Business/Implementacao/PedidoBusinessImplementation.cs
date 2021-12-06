using System.Collections.Generic;
using LaBrasaAPI.Model;
using LaBrasaAPI.Repository;

namespace LaBrasaAPI.Business.Implementacao
{
    public class PedidoBusinessImplementation : IPedidoBusiness
    {
        private readonly IPedidoRepository _repository;

        public PedidoBusinessImplementation(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public Pedido Create(Pedido pedido)
        {
            return _repository.Create(pedido);
        }

        public void Delete(int idPedido)
        {
            _repository.Delete(idPedido);
        }

        public List<Pedido> FindAll()
        {
            return _repository.FindAll();
        }

        public Pedido FindByID(int idPedido)
        {
            return _repository.FindByID(idPedido);
        }

        public Pedido Update(Pedido pedido)
        {
            return _repository.Update(pedido);
        }
    }
}


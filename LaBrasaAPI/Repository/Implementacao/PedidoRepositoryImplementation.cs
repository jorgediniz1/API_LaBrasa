using LaBrasaAPI.Model;
using LaBrasaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository.Implementacao
{
    public class PedidoRepositoryImplementation : IPedidoRepository
    {
        private SQLServerContext _context;

        public PedidoRepositoryImplementation(SQLServerContext context)
        {
            _context = context;
        }
  

        public Pedido Create(Pedido pedido)
        {
            try
            {
                _context.Add(pedido);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pedido;
        }

        public void Delete(int idPedido)
        {
            if (!Exists(idPedido))
            {
                var retorno = true;
            }

            var resultado = _context.Pedidos.SingleOrDefault(p => p.Id.Equals(idPedido));
            
            if(resultado != null)
            {
                try
                {
                    _context.Pedidos.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
           
        }

        public List<Pedido> FindAll()
        {
            return _context.Pedidos.ToList();
        }

        public Pedido FindByID(int idMesa)
        {
            return _context.Pedidos.SingleOrDefault(c => c.Id.Equals(idMesa));
        }

        public Pedido Update(Pedido pedido)
        {
            if (!Exists(pedido.Id))
            {
                return new Pedido();
            }
            var resultado = _context.Pedidos.SingleOrDefault(p => p.Id.Equals(pedido.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(pedido);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return pedido;
        }
        private bool Exists(int idPedido)
        {
            return _context.Pedidos.Any(c => c.Id.Equals(idPedido));
        }
    }
}

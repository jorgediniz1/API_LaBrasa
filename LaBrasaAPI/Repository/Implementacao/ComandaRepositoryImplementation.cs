using LaBrasaAPI.Model;
using LaBrasaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository.Implementacao
{
    public class ComandaRepositoryImplementation : IComandaRepository
    {
        private SQLServerContext _context;

        public ComandaRepositoryImplementation(SQLServerContext context)
        {
            _context = context;
        }
  

        public Comanda Create(Comanda comanda)
        {
            try
            {
                _context.Add(comanda);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return comanda;
        }

        public void Delete(int idComanda)
        {
            if (!Exists(idComanda))
            {
                var retorno = true;
            }

            var resultado = _context.Comandas.SingleOrDefault(p => p.Id.Equals(idComanda));
            
            if(resultado != null)
            {
                try
                {
                    _context.Comandas.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
           
        }

        public List<Comanda> FindAll()
        {
            return _context.Comandas.ToList();
        }

        public Comanda FindByID(int idComanda)
        {
            return _context.Comandas.SingleOrDefault(c => c.Id.Equals(idComanda));
        }

        public Comanda Update(Comanda comanda)
        {
            if (!Exists(comanda.Id))
            {
                return new Comanda();
            }
            var resultado = _context.Comandas.SingleOrDefault(p => p.Id.Equals(comanda.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(comanda);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return comanda;
        }
        private bool Exists(int idComanda)
        {
            return _context.Comandas.Any(c => c.Id.Equals(idComanda));
        }
    }
}

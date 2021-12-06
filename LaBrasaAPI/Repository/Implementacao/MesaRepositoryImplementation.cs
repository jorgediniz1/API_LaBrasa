using LaBrasaAPI.Model;
using LaBrasaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository.Implementacao
{
    public class MesaRepositoryImplementation : IMesaRepository
    {
        private SQLServerContext _context;

        public MesaRepositoryImplementation(SQLServerContext context)
        {
            _context = context;
        }
  

        public Mesa Create(Mesa mesa)
        {
            try
            {
                _context.Add(mesa);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mesa;
        }

        public void Delete(int idMesa)
        {
            if (!Exists(idMesa))
            {
                var retorno = true;
            }

            var resultado = _context.Mesas.SingleOrDefault(p => p.Id.Equals(idMesa));
            
            if(resultado != null)
            {
                try
                {
                    _context.Mesas.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
           
        }

        public List<Mesa> FindAll()
        {
            return _context.Mesas.ToList();
        }

        public Mesa FindByID(int idMesa)
        {
            return _context.Mesas.SingleOrDefault(c => c.Id.Equals(idMesa));
        }

        public Mesa Update(Mesa mesa)
        {
            if (!Exists(mesa.Id))
            {
                return new Mesa();
            }
            var resultado = _context.Mesas.SingleOrDefault(p => p.Id.Equals(mesa.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(mesa);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return mesa;
        }
        private bool Exists(int idMesa)
        {
            return _context.Mesas.Any(c => c.Id.Equals(idMesa));
        }
    }
}

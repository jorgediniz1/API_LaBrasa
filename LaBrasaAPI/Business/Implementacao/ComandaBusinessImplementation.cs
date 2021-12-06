using LaBrasaAPI.Model;
using LaBrasaAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Business.Implementacao
{
    public class ComandaBusinessImplementation : IComandaBusiness
    {

        private readonly IComandaRepository _repository;

        public ComandaBusinessImplementation(IComandaRepository repository)
        {
            _repository = repository;  
        }
     
        public Comanda Create(Comanda idComanda)
        {
           return _repository.Create(idComanda);
        }

        public void Delete(int idComanda)
        {
           _repository.Delete(idComanda);
        }

        public List<Comanda> FindAll()
        {
            return _repository.FindAll();
        }

        public Comanda FindByID(int idComanda)
        {
            return _repository.FindByID(idComanda);
        }

        public Comanda Update(Comanda comanda)
        {
            return _repository.Update(comanda);
        }
    }
}

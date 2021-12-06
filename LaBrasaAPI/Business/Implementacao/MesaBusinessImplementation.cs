using LaBrasaAPI.Model;
using LaBrasaAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Business.Implementacao
{
    public class MesaBusinessImplementation : IMesaBusiness
    {

        private readonly IMesaRepository _repository;

        public MesaBusinessImplementation(IMesaRepository repository)
        {
            _repository = repository;  
        }
     
        public Mesa Create(Mesa mesa)
        {
           return _repository.Create(mesa);
        }

        public void Delete(int idMesa)
        {
           _repository.Delete(idMesa);
        }

        public List<Mesa> FindAll()
        {
            return _repository.FindAll();
        }

        public Mesa FindByID(int idMesa)
        {
            return _repository.FindByID(idMesa);
        }

        public Mesa Update(Mesa mesa)
        {
            return _repository.Update(mesa);
        }
    }
}

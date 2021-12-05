using System.Collections.Generic;
using LaBrasaAPI.Model;
using LaBrasaAPI.Repository;

namespace LaBrasaAPI.Business.Implementacao
{
    public class FuncionarioBusinessImplementation : IFuncionarioBusiness
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioBusinessImplementation(IFuncionarioRepository repository)
        {
            _repository = repository;
        }

        public Funcionario Create(Funcionario funcionario)
        {
            return _repository.Create(funcionario);
        }

        public void Delete(int idFuncionario)
        {
            _repository.Delete(idFuncionario);
        }

        public List<Funcionario> FindAll()
        {
            return _repository.FindAll();
        }

        public Funcionario FindByID(int idFuncionario)
        {
            return _repository.FindByID(idFuncionario);
        }

        public Funcionario Update(Funcionario funcionario)
        {
            return _repository.Update(funcionario);
        }
    }
}


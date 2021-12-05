using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Business
{
    public interface IFuncionarioBusiness
    {
        Funcionario Create(Funcionario funcionario);
        Funcionario FindByID(int idFuncionario);
        Funcionario Update(Funcionario funcionario);
        void Delete(int idFuncionario);
        List<Funcionario> FindAll();
    }
}
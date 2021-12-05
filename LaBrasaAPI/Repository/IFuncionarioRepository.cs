using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Repository
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> FindAll();
        Funcionario FindByID(int idFuncionario);
        Funcionario Create(Funcionario funcionario);

        Funcionario Update(Funcionario funcionario);
        void Delete(int idFuncionario);
    }
}
using LaBrasaAPI.Model;
using LaBrasaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository.Implementacao
{
    public class FuncionarioRepositoryImplementation : IFuncionarioRepository
    {
        private SQLServerContext _context;

        public FuncionarioRepositoryImplementation(SQLServerContext context)
        {
            _context = context;
        }

        public Funcionario Create(Funcionario funcionario)
        {
            try
            {
                _context.Add(funcionario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return funcionario;
        }

        public void Delete(int idFuncionario)
        {
            if (!Exists(idFuncionario))
            {
                var retorno = true;
            }
            var resultado = _context.Funcionarios.SingleOrDefault(p => p.Id.Equals(idFuncionario));

            if (resultado != null)
            {
                try
                {
                    _context.Funcionarios.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<Funcionario> FindAll()
        {
            return _context.Funcionarios.ToList();

        }

        public Funcionario FindByID(int idFuncionario)
        {
            return _context.Funcionarios.SingleOrDefault(c => c.Id.Equals(idFuncionario));
        }

        public Funcionario Update(Funcionario funcionario)
        {
            if (!Exists(funcionario.Id))
            {
                return new Funcionario();
            }
            var resultado = _context.Funcionarios.SingleOrDefault(p => p.Id.Equals(funcionario.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(funcionario);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return funcionario;
        }

        private bool Exists(int idCliente)
        {
            return _context.Funcionarios.Any(c => c.Id.Equals(idCliente));
        }
    }
}

using LaBrasaAPI.Model;
using LaBrasaAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository.Implementacao
{
    public class ProdutoRepositoryImplementation : IProdutoRepository
    {
        private SQLServerContext _context;

        public ProdutoRepositoryImplementation(SQLServerContext context)
        {
            _context = context;
        }

        public Produto Create(Produto produto)
        {
            try
            {
                _context.Add(produto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return produto;
        }

        public void Delete(int idProduto)
        {
            if (!Exists(idProduto))
            {
                var retorno = true;
            }
            var resultado = _context.Produtos.SingleOrDefault(p => p.Id.Equals(idProduto));

            if (resultado != null)
            {
                try
                {
                    _context.Produtos.Remove(resultado);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<Produto> FindAll()
        {
            return _context.Produtos.ToList();

        }

        public Produto FindByID(int idProduto)
        {
            return _context.Produtos.SingleOrDefault(c => c.Id.Equals(idProduto));
        }

        public Produto Update(Produto produto)
        {
            if (!Exists(produto.Id))
            {
                return new Produto();
            }
            var resultado = _context.Produtos.SingleOrDefault(p => p.Id.Equals(produto.Id));

            if (resultado != null)
            {
                try
                {
                    _context.Entry(resultado).CurrentValues.SetValues(produto);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return produto;
        }

        private bool Exists(int idProduto)
        {
            return _context.Funcionarios.Any(c => c.Id.Equals(idProduto));
        }
    }
}

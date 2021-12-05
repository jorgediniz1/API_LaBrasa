using System.Collections.Generic;
using LaBrasaAPI.Model;
using LaBrasaAPI.Repository;

namespace LaBrasaAPI.Business.Implementacao
{
    public class ProdutoBusinessImplementation : IProdutoBusiness
    {
        private readonly IProdutoRepository _repository;

        public ProdutoBusinessImplementation(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public Produto Create(Produto produto)
        {
            return _repository.Create(produto);
        }

        public void Delete(int idProduto)
        {
            _repository.Delete(idProduto);
        }

        public List<Produto> FindAll()
        {
            return _repository.FindAll();
        }

        public Produto FindByID(int idProduto)
        {
            return _repository.FindByID(idProduto);
        }

        public Produto Update(Produto produto)
        {
            return _repository.Update(produto);
        }
    }
}


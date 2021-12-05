using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> FindAll();
        Produto FindByID(int idProduto);
        Produto Create(Produto produto);

        Produto Update(Produto produto);
        void Delete(int idProduto);
    }
}
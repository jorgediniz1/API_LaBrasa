using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Business
{
    public interface IProdutoBusiness
    {
      
        Produto Create(Produto produto);
        Produto FindByID(int idProduto);
        Produto Update(Produto produto);
        void Delete(int idProduto);
        List<Produto> FindAll();
    }
}
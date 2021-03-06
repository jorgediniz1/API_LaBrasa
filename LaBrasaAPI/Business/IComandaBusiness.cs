using LaBrasaAPI.Model;
using System.Collections.Generic;

namespace LaBrasaAPI.Business
{
    public interface IComandaBusiness
    {
        Comanda Create(Comanda comanda);
        Comanda FindByID(int idComanda);
        Comanda Update(Comanda comanda);
        void Delete(int idComanda);
        List<Comanda> FindAll();

        

    }
}
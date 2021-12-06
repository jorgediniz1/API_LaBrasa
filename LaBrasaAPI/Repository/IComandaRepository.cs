using LaBrasaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Repository
{
    public interface IComandaRepository
    {
        Comanda Create(Comanda comanda);
        Comanda FindByID(int idComanda);
        Comanda Update(Comanda comanda);
        void Delete(int idComanda);
        List<Comanda> FindAll();     
    }
}

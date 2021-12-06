using LaBrasaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Business
{
    public interface IMesaBusiness
    {
        Mesa Create(Mesa mesa);
        Mesa FindByID(int idMesa);
        Mesa Update(Mesa mesa);
        void Delete(int idMesa);
        List<Mesa> FindAll();

        



    }
}

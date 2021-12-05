using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaBrasaAPI.Model
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public int ComandasAbertas { get; set; }
        public int ComandasFechadas { get; set; }
        public List<Comanda> ComandaMesa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public Pessoa Pesssoa { get; set; }

        public Cliente()
        {
            Pesssoa = new Pessoa();
        }
    }
}

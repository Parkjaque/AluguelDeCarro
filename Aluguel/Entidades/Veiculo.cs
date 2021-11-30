using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel_de_Carros.Entidades
{
    class Veiculo
    {
        public string Model { get; set; }
        public Veiculo(string model)
        {
            Model = model;
        }
    }
}

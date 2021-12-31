using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Peca
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public decimal Valor { get; set; }

        public Peca()
        {
            Id = new Random().Next(0, 100);
        }
    }
}

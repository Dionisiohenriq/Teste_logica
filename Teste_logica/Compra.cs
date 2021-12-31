using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Compra
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int QtdPecas { get; set; }
        public decimal Total { get; set; }
        public Peca Peca { get; set; }

        public Compra()
        {
            Id = new Random().Next(2000, 10000);
            Codigo = new Random().Next(0, 1000);
            Peca = new Peca();
        }
    }

}

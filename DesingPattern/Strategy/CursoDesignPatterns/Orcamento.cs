using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}

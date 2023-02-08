using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    /// <summary>
    /// uma intidade que contem detalhes sobre cada item adicionado ao carrinho
    /// </summary>
    public class ItemCarrinho
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preço { get; set; }

        public override string ToString()
        {
            return $"Item: {Quantidade}X {Nome},  R${SubTotal(Preço, Quantidade).ToString("F2" + CultureInfo.InvariantCulture)}";
        }
        public double SubTotal(double preço,int quantidade)
        {
            return preço * quantidade;
        }
    }
}

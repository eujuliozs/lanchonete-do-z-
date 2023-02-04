using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    public class Owner
    {
        public static string Nome { get; } = "Senhor José";
        public static int Empregados { get; } = 3;
        public static double Lucro { get; set; } = 15000;

        public Owner()
        {
            
        }
        public override string ToString()
        {
            return $"O {Owner.Nome} em 1900 e guaraná de rolha criou uma lanchonete chamada {Restaurant.Name} Localizada na cidadezinha de Radiator Springs no local {Restaurant.Adress}E hoje me dia lucra {Owner.Lucro} todos os meses do ano e divide igualmente entre seus {Owner.Empregados} filhos";
        }
    }
}

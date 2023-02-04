using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    public class Validations
    {
        public static bool Produtos_Disponiveis(string opção)
        {
            foreach (var pd in PdList.Products.Keys)
            {
                if (pd == opção)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

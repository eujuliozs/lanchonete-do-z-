using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    public class PdList
    {
        public static Dictionary<string, double> Products { get; } = new Dictionary<string, double>();
        public PdList()
        {
            Products["cheeseburguer"] = 4.50;
            Products["cheesebacon"] = 6;
            Products["coca"] = 4;
            Products["dolly"] = 4;
        }
        static double SubTotal(string key)
        {
            return Products[key];
        }
        static void AddItem()
        {
            
        }

    }
}

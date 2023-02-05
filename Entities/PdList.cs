using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    public class PdList
    {
        public static List<string> Carrinho { get; set; } = new List<string>();
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
        public static void RemoveItem()
        {

        }
        public static void AddItem(string Item)
        {
            Carrinho.Add(Item);
        }
        public void ShowCarrinho()
        {
            Console.WriteLine("");
            for (int i = 0; i < Carrinho.Count; i++)
            {
                Console.WriteLine(Products[Carrinho[i]]);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_fastfood.Entities
{
    public class PdList
    {
        public static Dictionary<string, double> Carrinho { get; set; } = new Dictionary<string, double>();
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
        public static void AddItem(string key, double valor)
        {
            Carrinho[key] = valor;
        }
        public static void ShowCarrinho()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var c in Carrinho.Keys)
            {
                sb.AppendLine($"{c} {Carrinho[c].ToString("F2" + CultureInfo.InvariantCulture)}");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(sb);
            Console.ResetColor();
            
        }
        public static void ShowProdutos()
        {
            StringBuilder sb = new StringBuilder();


            foreach (var c in PdList.Products.Keys)
            {
                sb.AppendLine($"{c} R${PdList.Products[c].ToString("F2", CultureInfo.InvariantCulture)}");

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb);
            Console.ResetColor();
        }

    }
}

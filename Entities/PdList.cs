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
        static double Total()
        {
            double total = 0;
            foreach(var item in Carrinho.Values)
            {
                total += item;
            }
            return total;
            
        }
        public static bool TryRemoveItem(string escolha, int quantos)
        {
            try
            {
                for (int i = 0; i < quantos; i++)
                {
                    PdList.Carrinho.Remove(escolha);
                }
                return true;
            }
            catch
            {
                return false;
            }
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

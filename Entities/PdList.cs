﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Restaurante_fastfood.Entities
{
    public class PdList
    {
        public static double total { get; set; }
        public static Dictionary<string, double> Products { get; } = new Dictionary<string, double>();
        public static List<ItemCarrinho> Carrinho { get; set; } = new List<ItemCarrinho>();
        public PdList()
        {
            Products["cheeseburguer"] = 4.50;
            Products["cheesebacon"] = 6;
            Products["coca"] = 4;
            Products["dolly"] = 4;
        }
        public static void AddItem(string key, double valor, int quantidade)
        {
            ItemCarrinho itemCarrinho = new ItemCarrinho { Nome=key, Preço=valor,Quantidade=quantidade };
            total += itemCarrinho.SubTotal(valor, quantidade);
            Carrinho.Add(itemCarrinho);
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
        public static void ShowCarrinho()
        {
            foreach(var c in Carrinho)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(c);
                Console.WriteLine($"Total: R${PdList.total}");
                Console.ResetColor();

            }
        }
    }
}

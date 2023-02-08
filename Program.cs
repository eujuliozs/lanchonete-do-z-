using System.Globalization;
using System.Text;
using Restaurante_fastfood.Entities;


namespace Restaurante_fastfood
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            PdList começo_do_programa = new PdList();
            Console.WriteLine("Delivery App "); 
            Console.WriteLine("temos: ");
            PdList.ShowProdutos();
            while (true)
            {
                string item = Validations.Escolha_Produtos();
                if (item == "0")
                {
                     break;
                }
                int quantidade = Validations.Numero_inteiro("quantos? ");
                PdList.AddItem(item, PdList.Products[item], quantidade);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Carrinho: ");
            Console.ResetColor();

            PdList.ShowCarrinho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("pagamento: ");
            Console.ResetColor();
            var lista_pagamentos = new List<string>() {"cartão","pix"};
            for(int i = 0; i < lista_pagamentos.Count; i++)
            {
                Console.WriteLine($"{lista_pagamentos[i]}");
            }
            Validations.pagamento();
            Console.WriteLine("Processando...");
            Thread.Sleep(900);
            Console.WriteLine("Finalizado!!! entrega em até 30 minutos");
            Console.WriteLine();
        }
    }

}
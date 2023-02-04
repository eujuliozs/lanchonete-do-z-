using System.Globalization;
using System.Text;
using Restaurante_fastfood.Entities;


namespace Restaurante_fastfood
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delivery App ");
            Console.WriteLine("temos: ");
            StringBuilder sb = new StringBuilder();


            foreach(var c in PdList.Products.Keys )
            {
                sb.AppendLine($"{c} R${PdList.Products[c].ToString("F2", CultureInfo.InvariantCulture)}");
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb);
            Console.ResetColor();
            Console.WriteLine("Qual Produto Gostaria? (0 para parar) ");
            string escolha="";
            while (true)
            { 
                while(true)
                {
                    escolha = Console.ReadLine().ToLower().Trim();
                    if (Validations.Produtos_Disponiveis(escolha)) { break; }
                }
                if (escolha == "0") { break; }
            }



        }
    }

}
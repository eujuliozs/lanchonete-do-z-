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
            string escolha="";
            while (true)
            { 
                while(true)
                {
                    Console.WriteLine("Qual Produto Gostaria? (0 para parar) ");
                    escolha = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("Quantos? ");
                    int quantidade = int.Parse(Console.ReadLine());
                    if (Validations.Produtos_Disponiveis(escolha)) 
                    { 
                        PdList.AddItem(escolha, PdList.Products[escolha], quantidade); 
                        break;
                    }
                    else if(!Validations.Produtos_Disponiveis(escolha) & escolha != "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Produto inexistente");
                        Console.ResetColor();
                    }
                    else if (escolha == "0") { break; }
                    
                }
                if (escolha == "0") 
                { 
                    break; 
                }

            }
            Console.WriteLine("Carrinho: ");
            foreach(var item in PdList.Carrinho)
            {
                Console.WriteLine(item);
            }
            
            Owner owner = new Owner();
            Console.WriteLine(owner);



        }
    }

}
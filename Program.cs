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
                    if (Validations.Produtos_Disponiveis(escolha)) 
                    { 
                        PdList.AddItem(escolha, PdList.Products[escolha]); 
                        break;
                    }
                    else if(!Validations.Produtos_Disponiveis(escolha) & escolha != "0")
                    {
                        Console.WriteLine("Produto inexistente");
                    }
                    else if (escolha == "0") { break; }
                    
                }
                if (escolha == "0") 
                { 
                    break; 
                }

            }
            Console.WriteLine("Carrinho: ");
            PdList.ShowCarrinho();
            Owner owner = new Owner();
            Console.WriteLine(owner);



        }
    }

}
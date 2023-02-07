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
            PdList.ShowCarrinho();
            while (true)
            {
                Console.WriteLine("Deseja remover itens[S/N] ");
                escolha = Console.ReadLine();
                if (!Validations.Sim_Não(escolha))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida! ");
                    Console.ResetColor();
                }
                else if(Validations.Sim_Não(escolha)) 
                {
                    break;
                }
            }
            if (escolha[0] == 's')
            {
                string remover = "";
                while(true)
                {
                    Console.WriteLine("Qual item gostaria de remover? ");
                    escolha = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("Quantas unidades?");
                    int quantos = int.Parse(Console.ReadLine());
                    if(PdList.TryRemoveItem(escolha, quantos))
                    {

                        Console.WriteLine($"{quantos}x {escolha} Removido com sucesso");

                        while (true)
                        {
                            Console.WriteLine("Deseja Remover mais itens?[S/N] ");
                            remover = Console.ReadLine().ToLower().Trim();
                        
                            if (Validations.Sim_Não(remover)) { break; }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("opção invalida! ");
                                Console.ResetColor();
                            }
                        }

                        if (remover[0] == 'n') { break; }
                    
                    }
                    else if(!PdList.TryRemoveItem(escolha, quantos))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Ops! Verifique se o nome do Item e a quantidade estão certas");
                        Console.ResetColor();
                        
                    }
                    PdList.ShowCarrinho();

                    
                }
            }
            
            Owner owner = new Owner();
            Console.WriteLine(owner);



        }
    }

}
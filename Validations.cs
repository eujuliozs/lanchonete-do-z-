using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante_fastfood.Entities;
using Restaurante_fastfood.Entities.Enum;

namespace Restaurante_fastfood
{
    /// <summary>
    /// todos os metodos pegam um input e confirmam dados do usuario e retornam valores boleanos
    /// </summary>
    public class ValidationsBool
    {

        public static bool Produtos_Disponiveis(string opção)
        {
            foreach (var pd in PdList.Products.Keys)
            {
                if (pd == opção)
                {
                    return true;
                }

            }
            return false;
        }
        public static bool Sim_Não(string escolha)
        {
            escolha = escolha.ToLower().Trim();

            if (escolha[0] == 's' | escolha[0] == 'n')
            {
                return true;
            }
            return false;
        }
        public static bool pagamento(string input)
        {
            try
            {
                Forma_de_Pagamento enumerador = Enum.Parse<Forma_de_Pagamento>(input);
                return true;
            }
            catch
            {
                return false;
            }

        }

    }



    /// <summary>
    /// esses usam os métodos de retorno de valor booleano acima e aplica um looping de insistencia até receber o input de dados correto
    /// </summary>
    public class Validations
    {
        public static string Escolha_Produtos()
        {
            string escolha = "";
            while (true)
            {
                Console.WriteLine("Qual Produto Gostaria? (0 para parar) ");
                escolha = Console.ReadLine().ToLower().Trim();
                if (ValidationsBool.Produtos_Disponiveis(escolha))
                {

                    return escolha;
                }
                else if (!ValidationsBool.Produtos_Disponiveis(escolha) & escolha != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Produto inexistente");
                    Console.ResetColor();
                }
                else if (escolha == "0") { return "0"; }
            }

        }

        public static int Numero_inteiro(string msg)
        {
            while(true)
            {
                Console.WriteLine(msg);
                int num;
                bool deu_certo = int.TryParse(Console.ReadLine(), out num);
                if (deu_certo)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Produto adicionado ao carrinho com sucesso");
                    Console.ResetColor();
                    return num;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero invalido, Tente novamente");
                    Console.ResetColor();
                }
            }
        }
        public static char Sim_Não(string msg)
        {
            string escolha = "";
            while (true)
            {
                Console.WriteLine(msg);
                escolha = Console.ReadLine();
                if(ValidationsBool.Sim_Não(escolha))
                {
                    return escolha[0];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("opção invalida");
                    Console.ResetColor();
                }
            }
            
        }
        public static void pagamento()
        {
            string input = "";
            while (true)
            {
                Console.WriteLine("qual seria a forma de pagamento? ");
                input = Console.ReadLine().ToLower().Trim();
                if (ValidationsBool.pagamento(input))
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("opção de pagamento invalida, tente novamente");
                    Console.ResetColor();
                }
            }
        }

    }
}

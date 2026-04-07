using System;
using Cadastro.Telas;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5)
            {

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("(1 = Cadastrar cliente, 2 = Listar cliente, 3 = Cadastrar funcionário, 4 = Lista funcionário, 5 = Sair do programa)");
                opcao = int.Parse(Console.ReadLine());
                
                ManterCliente manterCliente = new ManterCliente();
                ManterFuncionario manterFuncionario = new ManterFuncionario();

                
                {
                    

                    switch (opcao)
                    {
                        case 1:
                            manterCliente.CadastrarCliente();
                            break;

                        case 2:
                            manterCliente.ListarCliente();
                            break;

                        case 3:
                            manterFuncionario.CadastrarFuncionario();
                            break;

                        case 4:
                            manterFuncionario.ListarFuncionarios();
                            break;

                        case 5:
                            Console.WriteLine("Saindo do programa...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}
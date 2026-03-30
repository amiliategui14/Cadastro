using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Telas;
namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            ManterCliente telaCliente = new ManterCliente();
            ManterFuncionario telaFuncionario = new ManterFuncionario();

            while (opcao != 5)
            {
                Console.WriteLine("O que deseja fazer ? \n(1 = Cadastrar cliente, 2 = Listar cliente, 3 = Cadastrar funcionário, 4 = Lista funcionário, 5 = Sair do programa )");
                opcao = int.Parse(Console.ReadLine());
            }
            switch (opcao)
            {
                case 1:
                    telaCliente.CadastrarCliente();
                    break;
                case 2:
                    telaCliente.ListarCliente();
                    break;
                case 3:
                    telaFuncionario.CadastrarFuncionario();
                    break;
                case 4:
                    telaFuncionario.ListarFuncionarios();
                    break;
                case 5:
                    //opcao 5
                default:
                    Console.WriteLine("Comando não encontrado!");
                    break;
            }
        }
    }
}

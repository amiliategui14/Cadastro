using System;
using Biblioteca.Model;
using Cadastro.Conversores;
using Biblioteca.Arquivo;
namespace Cadastro.Telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Cliente funcionario = new Cliente();
            Console.Clear();

            Console.WriteLine("CADASTRAR FUNCIONÁRIO");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/MM/yyyy): ");
            funcionario.DataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP (digitar apenas números): ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            funcionario.Endereco = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salario: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("DataContratacao: ");
            funcionario.DataContratacao = DateTime.Parse((Console.ReadLine()));



            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE FUNCIONÁRIOS");

            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");

            foreach (string linha in linhas)
            {
                Cliente funcionario = Conversores.FuncionarioTexto.ConverterParaCliente(linha);
                Console.WriteLine("NOME: " + funcionario.Nome +  "CARGO: " + funcionario.Cargo);
            }
        }
    }
}

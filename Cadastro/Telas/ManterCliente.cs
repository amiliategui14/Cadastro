using System;
using Biblioteca.Model;
using Cadastro.Conversores;
using Biblioteca.Arquivo;

namespace Cadastro.Telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Clear();

            Console.WriteLine("CADASTRAR CLIENTE");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/MM/yyyy): ");
            cliente.DataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP (digitar apenas números): ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            cliente.Endereco = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
        }

        public void ListarCliente()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE CLIENTES");

            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");

            foreach (string linha in linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);
                Console.WriteLine("NOME: " + cliente.Nome);
            }
        }
    }
}
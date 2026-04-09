using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Cadastro.Conversores
{
    public class ClienteTexto
    {
        public static string ConverterParaTexto (Cliente cliente)
        {
            String Texto = String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",
                cliente.Nome,
                cliente.DataNascimento,
                cliente.Telefone,
                cliente.CPF,
                cliente.RG,
                cliente.CEP,
                cliente.Estado,
                cliente.Cidade,
                cliente.Endereco
                );
            return Texto;
        }

        public static Cliente ConverterParaCliente(String Linha)
        {
            string [] elementos = Linha.Split(',');
            Cliente funcionario = new Cliente();

            funcionario.Nome = elementos[0];
            funcionario.DataNascimento = DateTime.Parse(elementos[1]);
            funcionario.Telefone = elementos[2];
            funcionario.CPF = elementos[3];
            funcionario.RG = elementos[4];
            funcionario.CEP = int.Parse(elementos[5]);
            funcionario.Estado = elementos[6];
            funcionario.Cidade = elementos[7];
            funcionario.Endereco = elementos[8];

            return funcionario;
        }
    }
}

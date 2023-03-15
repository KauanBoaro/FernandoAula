using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Kauan Boaro", "16997322417");
            Endereco e1 = new Endereco(1, "15990365", "Rua dos Albertos", 987, "Bairro das vó", "Cidade do Zorró");

            Console.WriteLine("\t---------- Cadastro ----------");
            Console.WriteLine("ID: " + c1.getId() + "\nNome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()));
            Console.WriteLine("CEP: " + e1.getCep() + "\nRua: " + e1.getRua() + "\nNúmero: " + e1.getNumero() + "\nBairro: " + e1.getBairro() + "\nCidade: " + e1.getCidade() + "\n");

            c1.setName("Moreira");
            c1.setTelefone("1699872915");

            Console.WriteLine("Nome: " + (c1.getName()) + "\nTelefone: " + (c1.getTelefone()) + "\n");

        }
    }
}

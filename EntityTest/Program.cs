using AcessoADados;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade");
            var sobrenome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade");
            var idade = Console.ReadLine();

            var pessoa = new Pessoa() {
                Nome = nome,
                Idade = idade,
                Sobrenome = sobrenome
                 
            };

            var pessoaDAO = new PessoaDAO();
            pessoaDAO.InserirPessoa(pessoa);

            List<Pessoa> todasAsPessoas = pessoaDAO.ObterTodasAsPessoas();
            foreach (var p in todasAsPessoas)
                Console.WriteLine(p.ToString());

            Console.ReadKey();
        }
    }
}

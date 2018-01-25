using AcessoADados.ctx;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoADados
{
    public class PessoaDAO
    {
        public void InserirPessoa(Pessoa p)
        {
            using (var ctx = new TestePessoaDbContext())
            {
                ctx.Pessoas.Add(p);
                ctx.SaveChanges();
            }
        }

        public List<Pessoa> ObterTodasAsPessoas()
        {
            using (var ctx = new TestePessoaDbContext())
            {
                return ctx.Pessoas.AsEnumerable().ToList();
            }
        }
    }
}

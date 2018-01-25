using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoADados.ctx
{
    public class TestePessoaDbContext : DbContext
    {
        public TestePessoaDbContext()
            :base(@"Data Source=.\sqlexpress;Initial Catalog=testepessoadb;User ID=diego;Password=diego123; MultipleActiveResultSets=true")
        {
        }


        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }
}

using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using NC.Data.Mapping;
using NC.Domain.Entities;

namespace NC.Data.Context
{
    public class NCContext : DbContext
    {
        public NCContext(DbContextOptions<NCContext> options)
           : base(options)
        {
        }

        //DbSet é um conjunto de dados
        //O que ele faz é: pega uma tabela no sql server chamada NcPessoaGrupo e mapeia para uma entidade chamada NcPessoaGrupo
        //è nesse ponto que faz a ligação do sql com as entidades
        
        public virtual DbSet<NcPessoaExterna> NcPessoaExterna { get; set; } = default!;       
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
       

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NcPessoaExterna>(new PessoaExternaMap().Configure);
         
           
        }
    }
}

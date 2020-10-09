using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using NexcodeControls.Data.Mapping;
using NexcodeControls.Data.Mapping.Entidade;
using NexcodeControls.Data.Mapping.UsuarioAbordagem;
using NexcodeControls.Domain.Entities;using NexcodeControls.Domain.Entities.UsuarioAbordagem;

namespace NexcodeControls.Data.Context
{
    public class NexcodeControlsContext : DbContext
    {
        public NexcodeControlsContext(DbContextOptions<NexcodeControlsContext> options)
           : base(options)
        {
        }

        //DbSet é um conjunto de dados
        //O que ele faz é: pega uma tabela no sql server chamada NcPessoaGrupo e mapeia para uma entidade chamada NcPessoaGrupo
        //è nesse ponto que faz a ligação do sql com as entidades
        
        public virtual DbSet<NcPessoaExterna> NcPessoaExterna { get; set; } = default!;       
        public virtual DbSet<NcEmpresa> NcEmpresa { get; set; } = default!;      
        public virtual DbSet<NcUsuarioAbordagem> NcUsuarioAbordagem { get; set; } = default!;
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
       

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NcPessoaExterna>(new PessoaExternaMap().Configure);
         
                       
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NcEmpresa>(new EmpresaMap().Configure);

          
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NcUsuarioAbordagem>(new UsuarioAbordagemMap().Configure);

        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using NC.Data.Repositories;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Handlers;
using NC.Domain.Repositories;

namespace NC.Api.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection services)
        {
           
            //Repository
        
            services.AddScoped<IPessoaExternaRepository, PessoaExternaRepository>();       


            //Command

            #region PessoaExterna
            
            services.AddScoped<InserirPessoaExternaCommand, InserirPessoaExternaCommand>();
            services.AddScoped<AlterarPessoaExternaCommand, AlterarPessoaExternaCommand>();
            services.AddScoped<ExcluirPessoaExternaCommand, ExcluirPessoaExternaCommand>();
            #endregion
                   

            //Handler     
            services.AddScoped<PessoaExternaHandler, PessoaExternaHandler>();

            //services.AddDbContext<NCContext>(
            //   options => options.UseSqlServer(@"Password=nexcode;Persist Security Info=True;User ID=sa;Initial Catalog=NexcodeControls2020;Data Source=LOCALHOST\SQLEXPRESS01")
            //);

        }
    }
}

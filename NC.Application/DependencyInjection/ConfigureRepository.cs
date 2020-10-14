using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NC.Data.Context;
using NC.Data.Repositories;
using NC.Data.Repositories.Entidade;
using NC.Domain.Commands.Entidade;
using NC.Domain.Commands.PessoaExterna;
using NC.Domain.Handlers;
using NC.Domain.Repositories;
using NC.Domain.Repositories.Entidade;
using NC.Domain.Commands.UsuarioAbordagem;
using NC.Data.Repositories.UsuarioAbordagem;
using NC.Domain.Repositories.UsuarioAbordagem;
using NC.Domain.Entities;

namespace NC.Api.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection services)
        {
           
            //Repository
         
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();          
            services.AddScoped<IPessoaExternaRepository, PessoaExternaRepository>();       
            services.AddScoped<IUsuarioAbordagemRepository, UsuarioAbordagemRepository>();

            //Command

            #region PessoaExterna
            
            services.AddScoped<InserirPessoaExternaCommand, InserirPessoaExternaCommand>();
            services.AddScoped<AlterarPessoaExternaCommand, AlterarPessoaExternaCommand>();
            services.AddScoped<ExcluirPessoaExternaCommand, ExcluirPessoaExternaCommand>();
            #endregion
                   
            #region Empresa
            services.AddScoped<InserirEmpresaCommand, InserirEmpresaCommand>();
            services.AddScoped<AlterarEmpresaCommand, AlterarEmpresaCommand>();
            services.AddScoped<ExcluirEmpresaCommand, ExcluirEmpresaCommand>();
            #endregion

            #region UsuarioAbordagem
            services.AddScoped<InserirUsuarioAbordagemCommand, InserirUsuarioAbordagemCommand>();
            services.AddScoped<AlterarUsuarioAbordagemCommand, AlterarUsuarioAbordagemCommand>();
            services.AddScoped<ExcluirUsuarioAbordagemCommand, ExcluirUsuarioAbordagemCommand>();
            #endregion


            //Handler     
            services.AddScoped<PessoaExternaHandler, PessoaExternaHandler>();

            //services.AddDbContext<NCContext>(
            //   options => options.UseSqlServer(@"Password=nexcode;Persist Security Info=True;User ID=sa;Initial Catalog=NexcodeControls2020;Data Source=LOCALHOST\SQLEXPRESS01")
            //);

        }
    }
}

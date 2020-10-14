using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NexcodeControls.Data.Context;
using NexcodeControls.Data.Repositories;
using NexcodeControls.Data.Repositories.Entidade;
using NexcodeControls.Domain.Commands.Entidade;
using NexcodeControls.Domain.Commands.PessoaExterna;
using NexcodeControls.Domain.Handlers;
using NexcodeControls.Domain.Repositories;
using NexcodeControls.Domain.Repositories.Entidade;
using NexcodeControls.Domain.Commands.UsuarioAbordagem;
using NexcodeControls.Data.Repositories.UsuarioAbordagem;
using NexcodeControls.Domain.Repositories.UsuarioAbordagem;
using NexcodeControls.Domain.Entities;

namespace NexcodeControls.Api.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection services)
        {
            //AddScoped: A nivel de aplicação e não servidor porque se trata de conexão de banco
            //services.AddScoped(typeof(IRepositoryBase<>), typeof(BaseRepository<>));           //typeof vai devolver o tipo exato
             //Siginifica que quando usar o repositorio "IOperadorRepository" voce faz a instancia da classe "OperadorImplementation"

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

            services.AddDbContext<NexcodeControlsContext>(
               options => options.UseSqlServer(@"Password=nexcode;Persist Security Info=True;User ID=sa;Initial Catalog=NexcodeControls2020;Data Source=LOCALHOST\SQLEXPRESS01")
            );

        }
    }
}

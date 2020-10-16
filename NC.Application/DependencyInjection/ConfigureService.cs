using Microsoft.Extensions.DependencyInjection;
using NC.Domain.Handlers;

namespace NC.Api.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependecyService(IServiceCollection services)
        {
            //AddTransient: Para cada operação que tiver uma injeção de depedencia ele vai criar uma instancia de PessoaGrupoService
            //AddTransient: Para metodo ele cria uma nova instancia
            //AddScope: significa que entrou na aplicação e em 10 metodos ele precisa usar a interface por ex IPessoaGrupoService, ele irá usar a mesma instancia
            //AddSingleton: problematico, Startou a aplicação no servidor, jamais ele vai mudar. É uma vez so. Quase não se usa essa opção. se for rodar no servidor apenas uma unica vez.

                        
            services.AddTransient<PessoaExternaHandler, PessoaExternaHandler>();
        

        }
    }
}

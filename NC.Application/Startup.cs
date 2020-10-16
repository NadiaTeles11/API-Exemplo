using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NC.Api.DependencyInjection;
using NC.Api.GraphQL.Mutations;
using NC.Api.GraphQL.Query;
using NC.Api.GraphQL.Types;
using NC.Data.Context;
using System.Text;

namespace NC.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Usar o DBContextpooling nos permite emitir uma DBContext instância para cada campo que precisa de uma. Mas em vez de criar uma DBContextinstância para cada campo e jogá-la fora depois de usá-la, estamos alugando para que os campos e solicitações possam reutilizá-la.
            //Por padrão, o DBContextpool manterá 128 DBContextinstâncias em seu pool.
            services.AddDbContextPool<NCContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            });

            //AddScoped: Garante que tenha apenas um Datacontext por requisição. Ele abre a conexão, processa a requisção, retorna e fecha a conexão automaticamente.
            services.AddScoped<NCContext, NCContext>();

            //Converte em bytes a chave secreta
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            //Curso 7196 do balta.io ensina autenticação com o google
            #region Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidAudience = "audience",
                    ValidIssuer = "issuer",
                    RequireSignedTokens = false,
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretsecretsecret"))
                };

                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
            });

            #endregion

            services.AddDbContext<NCContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            });
                 
            ConfigureService.ConfigureDependecyService(services);               //adicionado essa linha
            ConfigureRepository.ConfigureDependeciesRepository(services);

            #region GraphQL

            //Para usar DataLoader com Hot Chocolate
            services.AddDataLoaderRegistry();

            services.AddGraphQL(s => SchemaBuilder.New()
            .AddServices(s)

            .AddType<PessoaExternaType>()

            .AddQueryType(d => d.Name("Query"))    
             .AddType<PessoaExternaQuery>()             
            
             .AddMutationType(d => d.Name("Mutation"))            
             .AddType<UsuarioPessoaExternaMutation>()         

             .Create());


            #endregion
                       
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())        //Em tempo de desenvolvimento. Somente exibe os detalhes do erro em desenvolvimento, em produção não pode
            {
                app.UsePlayground();
                app.UseDeveloperExceptionPage();
            }
               
            app.UseHttpsRedirection();      //Força a API responder em HTTPS
                                            //Recomendação usar certificado pago e não gratuito

            app.UseRouting();               //padrão de rotas do MVC
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();        
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>           //mapeamentos da URL's
            {
                endpoints.MapControllers();
            });

            //GraphQL
            app
                .UseGraphQL()
                .UsePlayground();       //O método UseGraphQL()configura o middleware GraphQL e define o caminho para a API GraphQL /graphql

        }
    }
}

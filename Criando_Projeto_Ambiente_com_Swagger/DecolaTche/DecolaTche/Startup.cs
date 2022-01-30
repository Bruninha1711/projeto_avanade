usando Localiza.Frotas.Domínio ;
usando Localiza.Frotas.Infra.EF ;
usando Localiza.Frotas.Infra.Fachada ;
usando Localiza.Frotas.Infra.Repositório ;
usando Localiza.Frotas.Infra.Singleton ;
usando Microsoft.AspNetCore.Construtor ;
usando Microsoft.AspNetCore.Hospedagem ;
usando Microsoft.EntityFrameworkCore ;
usando Microsoft.Extensões.Configuração ;
usando Microsoft.Extensões.Injeção de Dependência ;
usando Microsoft.Extensões.Hospedagem ;
usando Microsoft.OpenApi.Modelos ;
usando Sistema;
usando Sistema.OI ;

namespace Localiza.Frotas
{
    inicialização de classe pública
    {
        Inicialização pública ( configuração IConfiguration  )
        {
            Configuração = configuração;
        }

        public IConfiguration Configuration { get; }

    // Este método é chamado pelo tempo de execução. Use este método para adicionar serviços ao contêiner.
    public void ConfigureServices(serviços IServiceCollection)
    {
        serviços.AddControllers();
        serviços.AddSwaggerGen(c =>
        {
            c.SwaggerDoc(" v1 ", new OpenApiInfo
            {
                Title = " Localiza.Frotas ",
                Descrição = " API - Frotas ",
                Versão = " v1 "
            });

            var apiPath = Caminho.Combine(AppContext.BaseDirectory, " Localiza.Frotas.xml "); _
                c.IncludeXmlComments(apiPath);
        });

        serviços.AddTransient<IVeiculoRepository, FrotaRepository>();
        serviços.AddTransient<IVeiculoDetran, VeiculoDetranFacade>();

        serviços.AddSingleton<SingletonContainer>();
        serviços.AddDbContext<FrotaContext>(opt =>
                                     opt.UseInMemoryDatabase(" Frota "));

        serviços.AddHttpClient();

        serviços.Configure<DetranOptions>(Configuration.GetSection(" DetranOptions "));
    }

    // Este método é chamado pelo tempo de execução. Use este método para configurar o pipeline de solicitação HTTP.
    Public void Configure(aplicativo IApplicationBuilder, IWebHostEnvironment env)
    {
        if (env.IsDevelop())
        {
            aplicativo.UseDeveloperExceptionPage();
        }


        aplicativo.UseSwagger();
        aplicativo.Use SwaggerUI(c  =>
            {
            c.SwaggerEndpoint(" /swagger/v1/swagger.json ", " API Localiza.Frotas ");
        });

        aplicativo.UseHttpsRedirection();

        aplicativo.UseRoteamento();

        aplicativo.Autorização de Uso();

        aplicativo.UseEndpoints(endpoints =>
        {
            pontos finais . MapControllers();
        });

    }
}
}
using LanchesMac.Context;
using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Este método é chamado pelo runtime. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            //aqui eu registro o serviço de banco de dados registrando meu contexto
            //aqui o serviço é criado com tempo de vida Scoped ou seja para cada request eu vou ter uma nova instancia de serviço criada
            //para atendender AppDbContext e eu vou poder usar essa instância e injetar em qualquer lugar do meu projeto,
            //por isso eu registrei isso como um serviço
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<ICategoriaRepository, CategoriaRepository>(); //registrando serviço do repositório LancheRepository
            services.AddTransient<ILancheRepository, LancheRepository>(); //registrando serviço do repositório LancheRepository
            //services.AddTransient<ICategoriaMolhoRepository, CategoriaMolhoRepository>(); //registrando serviço do repositório CategoriaMolhoRepository
            services.AddTransient<IMolhoRepository, MolhoRepository>(); //registrando serviço do repositório MolhoRepository
            services.AddTransient<ICategoriaMulhoRepository, CategoriaMulhoRepository>(); //registrando serviço do repositório CategoriaMolhoRepository
            services.AddTransient<IMulhoRepository, MulhoRepository>(); //registrando serviço do repositório MolhoRepository

            //Definir serviço para acessar os recursos do httpcontext. Assim através de um serviço eu consigo recurar uma instancia de HttpContextAccessor
            //e usar os recursos da classe httpcontext e obter informações do request e do response, sobre autenticação, e outras informações da requisição
            //atual (### gerenciamento de estado ###)
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // AddSingleton vale por todo tempo de vida da minha aplicação

            services.AddControllersWithViews(); //Serviço dos controladores com views

            //Para acessar os recursos do HttpContex em um serviço e registrar a interface IHhttpContextAcessor() para injeção de 
            //dependência no método ConfiguraServices()
            //Para pode trabalhar com gerenciamento de estado da sessão, gravar dados nos cookies, compartilhas dados entre views
            //Aqui eu estou registrando os middwares
            services.AddMemoryCache(); //Habilitar o Cache (### gerenciamento de estado ###)
            services.AddSession(); // habilitar o session (### gerenciamento de estado ###)

            //Definir serviço para acessar os recursos do httpcontext
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Este método é chamado pelo runtime. Use este método para configurar o pipeline de solicitação HTTP.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                // O valor padrão do HSTS é 30 dias. Você pode querer mudar isso para cenários de produção, veja https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession(); //No caso do session tem que ativar ele aqui, em cima habilita e aqui  ativa (### gerenciamento de estado ###)

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

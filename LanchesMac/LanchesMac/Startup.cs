using LanchesMac.Context;
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

            services.AddControllersWithViews(); //Serviço dos controladores com views
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

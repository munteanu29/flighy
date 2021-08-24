using itec_backend.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


namespace flightBackend
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "server=localhost;port=3306;database=flight;uid=root;password=parola01";
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
                    });
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "flight_backend", Version = "v1" });
            });
            services.AddDbContext<ApplicationDbContext>(op => op.UseMySQL(connectionString,
                x => x.MigrationsAssembly("flight-backend")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = ("");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "itec_backend API");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            
            app.UseCors();


            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
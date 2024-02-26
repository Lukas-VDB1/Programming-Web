using Microsoft.AspNetCore.Builder;
using WebApplication3.Data;

namespace WebApplication3
{
    public class Startup
    {

        //CHATGPT COPY PASTA:
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add the service registration here based on the desired lifetime

            // Option 1: AddScoped
            services.AddScoped<IAnonymousEurosongDataContext, AnonymousEurosongDataList>();

            // Option 2: AddTransient
            // services.AddTransient<IAnonymousEurosongDataContext, AnonymousEurosongDataList>();

            // Option 3: AddSingleton
            // services.AddSingleton<IAnonymousEurosongDataContext, AnonymousEurosongDataList>();

            // Other services configuration can be added here
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        //TOT HIER GE COPY PASTAd
    }
}


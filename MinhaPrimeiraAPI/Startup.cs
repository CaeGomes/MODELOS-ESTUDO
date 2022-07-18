using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MinhaPrimeiraAPI.Model;
using Microsoft.EntityFrameworkCore;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]
namespace MinhaPrimeiraAPI;

public class Startup
{
   public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    //Aqui add os middlewares
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApiDbContext>(optionsAction: options =>
        options.UseSqlServer(Configuration.GetConnectionString(name:"DefaultConnection")));
        
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        //services.AddMvc(options => options.EnableEndpointRouting = false);
    }


    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        if (env.IsDevelopment()) //Se for ambiente de desenvolvimento:
        {
            app.UseDeveloperExceptionPage();//Retorne uma página, quando existir um erro
        }
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();


        //Aqui utilizamos os midleares
        //app.UseMvc();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

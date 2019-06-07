using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloMVC
{
    public class Startup
    {
       /* private IConfiguration Configuration;
        public Startup(IConfiguration configuation)
        {
            Configuration = configuration;
        }*/
        // Add dependency -> 
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //Add Middle wares
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            /*if (env.IsDevelopment())
            {
                //This is executed when an error is thrown
                app.UseDeveloperExceptionPage(); //middlewear
            }*/
            /*app.Use(async (context, next) => //next is fuction delegate, generic delegate
            {
                logger.LogInformation("Middle ware 1: incoming request");
                //await context.Response.WriteAsync("Hello from Middle ware 1");
                await next(); //pass requrest to app.Run
                logger.LogInformation("Middle ware 1: outgoing response");
            });
            app.Use(async (context, next) => //next is fuction delegate, generic delegate
            {
                logger.LogInformation("Middle ware 2: incoming request");
                //await context.Response.WriteAsync("Hello from Middle ware 2");
                await next(); //pass requrest to app.Run
                logger.LogInformation("Middle ware 2: outgoing response");
            });*/
            //app.UseStaticFiles(); //middleware to connect your wwwroot files (loads JS files, CSS, ...)
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("home.html");

            //app.UseDefaultFiles(defaultFilesOptions); //looks for index.html/index.htm/default.html/default.htm
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "default", 
                    template: "{controller=Home}/{action=index}/{id?}");
            });
            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync("Hello World!");
                //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                //await context.Response.WriteAsync(env.EnvironmentName);
                //await context.Response.WriteAsync(configuration["MyOwnKey"]);
                //await context.Response.WriteAsync("Hello from Middle ware 3");
                //logger.LogInformation("Middle ware 3: request has been processed");
                await context.Response.WriteAsync("hello world");
            });
        }
    }
}

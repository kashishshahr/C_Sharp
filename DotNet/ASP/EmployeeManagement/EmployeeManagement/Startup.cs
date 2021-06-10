using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration _config { get; set; }
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //services.AddMvcCore(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IEmployeeRepository,MockEmployeeRepositary>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
            //,ILogger<Startup> logger)
            )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            //app.Run(async (context) =>
            //{
            //    //throw new Exception("Some Error processing request"); 
            //    await context.Response.WriteAsync("Hey World!");
            //});
            //else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment(""))
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World from 1st middleware");
            //});
            //app.Use(async (context,next) =>
            //{
            //    //await context.Response.WriteAsync("Hello World from 1st middleware");
            //    logger.LogInformation("MW1: Incoming request");
            //    await next();
            //    logger.LogInformation("MW1: Outgoing Response");

            //});
            //app.Use(async (context,next) =>
            //{
            //    //await context.Response.WriteAsync("Hello World from 2nd middleware");
            //    logger.LogInformation("MW2: Incoming request");
            //    await next();
            //    logger.LogInformation("MW2: Outgoing Response");

            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World from 3rd middleware");
            //    logger.LogInformation("MW2: Request handled and response are produced");

            //});

            //--------------------STATIC FILES MIDDLEWARE FOR JPG etc in wwwroot
            //DefaultFilesOptions defaultFilesOption = new DefaultFilesOptions();
            //defaultFilesOption.DefaultFileNames.Clear();
            //defaultFilesOption.DefaultFileNames.Add("foo.html");
            //FileServerOptions fileServerOptions= new FileServerOptions();

            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear() ;
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            //app.UseFileServer(fileServerOptions);
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World ");
            //});
            //--------------------------------------------------
            //app.UseFileServer();
            //app.Run(async (context) =>
            //{
            //    //throw new Exception("Some Error processing request"); 
            //    await context.Response.WriteAsync("Hey World!");
            //});

        }
    }
}

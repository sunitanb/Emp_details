using EmployeeAPI.Context;
using EmployeeAPI.Extension;
using EmployeeAPI.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI
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
            

            services.AddDbContext<CompanyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CompanyConnStr")));
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", 
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                    Title = "Employees",
                    Description = "List of Employees",
                    Version ="v1"
                    }
                    );
            });
        }

        // This method gets 90called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, CompanyContext context)
        {

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //    app.UseGlobalExceptionHandler(logger);
            //}
            //else
            //{
            //    app.UseGlobalExceptionHandler(logger);
            //    app.UseHsts();
            //}            
            app.UseMiddleware<ExceptionHandlerMiddleware>();
            context.Seed();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseRequestLogger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json","Employee");
                options.RoutePrefix = "";
            });

            
        }
    }
}

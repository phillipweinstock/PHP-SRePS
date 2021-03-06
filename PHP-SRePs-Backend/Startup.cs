﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PHP_SRePS_Backend
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // TODO: Add future services here
                endpoints.MapGrpcService<ItemService>();
                endpoints.MapGrpcService<SaleService>();
                endpoints.MapGrpcService<CategoryService>();
                endpoints.MapGrpcService<StockService>();
                endpoints.MapGrpcService<ReportService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Nice Try, if you want a webapp, you should write that in the requirements");
                });
            });
        }
    }
}

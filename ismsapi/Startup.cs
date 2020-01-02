using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ismsapi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ismsapi.Models;
using ismsapi.Reponsitory;
using ismsapi.Options;
using AutoMapper;

namespace ismsapi
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
            
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultString")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.Configure<PaginOption>(Configuration.GetSection("PaginOption"));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            // IReponsitory
            services.AddScoped<IDataReponsitory<Event>, DataReponsitory<Event>>();
            services.AddScoped<IDataReponsitory<Post>, DataReponsitory<Post>>();
            services.AddScoped<IDataReponsitory<Student>, DataReponsitory<Student>>();

            // Reponsitory
            services.AddScoped<EventDataReponsitory, EventDataReponsitory>();
            services.AddScoped<PostDataReponsitory, PostDataReponsitory>();
            services.AddScoped<StudentDataReponsitory, StudentDataReponsitory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(x => x.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            }
            else
            {
                app.UseCors(x => x.AllowAnyOrigin()
                                    //.WithOrigins("http://localhost:4200")
                                    .AllowAnyHeader()
                                    .AllowAnyMethod());
                //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            //app.UseHttpsRedirection();
            
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}

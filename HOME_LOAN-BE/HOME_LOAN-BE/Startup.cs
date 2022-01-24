using HOME_LOAN_BE.Data;
using HOME_LOAN_BE.Models;
using HOME_LOAN_BE.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace HOME_LOAN_BE
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



            services.AddControllers().AddNewtonsoftJson();
            services.AddDbContextPool<loanDB>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddScoped<IDataRepository<Customer_Details>, CustomerRepository>();
            services.AddScoped<ILoanRepository<Loan>, LoanRepository>();
            services.AddScoped <ILoanTrack<Customer_Details>, LoanTrackerRepository>();
            services.AddScoped<IForgot<Customer_Details>, ForgotRepository>();
            services.AddScoped<IDataRepository<Status_details>, StatusRepository>();
                services.AddScoped<IUserLogin<Customer_Details>, UserLoginRepository>();
            services.AddScoped<IDataRepository<Property_Details>, PropertyRepository>();
            services.AddScoped<IDataRepository<Employee_Details>, Employee1Repository>();
            
            services.AddScoped<IDataAdmin<Admin_Details>, AdminRepository>();
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Home Loan", Version = "v1" });
            });
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Home_Loan v1"));
            }
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.

            // Enable Cors
            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseDeveloperExceptionPage();
            app.UseRouting();



            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
using AutoMapper;
using HospitalSurvey.Application.Implementation;
using HospitalSurvey.Application.Interfaces;
using HospitalSurvey.Application.System.Users;
using HospitalSurvey.Data.EF;
using HospitalSurvey.Data.Entities;
using HospitalSurvey.Infrastructure.Interfaces;
using HospitalSurvey.Utilities.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace HospitalSurvey.Services
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
            services.AddControllersWithViews();
            services.AddSession();

           
            services.AddDbContext<HospitalSurveyDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));


            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<HospitalSurveyDbContext>()
                .AddDefaultTokenProviders();

            services.AddMemoryCache();
            // Declare DI

            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
           

            services.AddAutoMapper();

            services.AddSingleton(Mapper.Configuration);

            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MamEdu API", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 0xxxxxx'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },

                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
            });


            services.AddAuthentication("Bearer")
                   .AddJwtBearer("Bearer", options =>
                   {
                       options.Authority = "https://localhost:5000";
                       options.RequireHttpsMetadata = true;

                       options.Audience = "thanhoangAPI";
                   });

            services.AddCors(options =>
            {
                // this defines a CORS policy called "default"
                options.AddPolicy("default", policy =>
                {
                    policy.WithOrigins("https://localhost:5003")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });


            services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddTransient(typeof(IRepository<,>), typeof(EFRepository<,>));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IHospitalDepartmentService, HospitalDepartmentService>();

          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();



            app.UseCors("default");
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MamEdu API V1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

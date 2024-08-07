﻿using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WebApi.Contracts;
using WebApi.CustomTokenProviders;
using WebApi.Entities.ConfigurationModels;
using WebApi.Formaters;
using WebApi.Repository;
using WebApi.Service.Contracts;
using WebApi.Services;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            { 
            
            });

        public static void ConfigureCors(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) => 
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) => 
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) 
        {
            string mySqlConnectionStr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["ApiDatabase"];

            services.AddDbContext<RepositoryContext>(options =>
                {
                    options.UseMySql(mySqlConnectionStr, new MySqlServerVersion(new Version(8,0,22)));
                });
        }

        public static IMvcBuilder AddCustomCSVFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config => config.OutputFormatters.Add(new CsvOutputFormatter()));

        //public static void ConfigureDataShaperService(this IServiceCollection services) =>
        //    services.AddScoped<IDataShaper<CategoryDto>, IDataShaper<CategoryDto>>();

        public static void ConfigureRedisCache(this IServiceCollection services) =>
            services.AddStackExchangeRedisCache(options => options.Configuration = "localhost:6379");

        public static void ConfigureRateLimitingOptions(this IServiceCollection services) 
        { 
            var rateLimitRules = new List<RateLimitRule> 
            { 
                new RateLimitRule 
                { 
                    Endpoint = "*", 
                    Limit = 3000, 
                    Period = "5m" 
                } 
            }; 
            
            services.Configure<IpRateLimitOptions>(opt => { opt.GeneralRules = rateLimitRules; }); 
            
            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>(); 
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>(); 
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>(); 
            services.AddSingleton<IProcessingStrategy, AsyncKeyLockProcessingStrategy>();
        }

        public static void ConfigureIdentity(this IServiceCollection services) 
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;

                o.SignIn.RequireConfirmedEmail = true;
                o.Tokens.EmailConfirmationTokenProvider = "emailconfirmation";
            }).AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders()
            .AddTokenProvider<EmailConfirmationTokenProvider<User>>("emailconfirmation");

            services.Configure<DataProtectionTokenProviderOptions>(options =>
                options.TokenLifespan = TimeSpan.FromHours(2));

            services.Configure<EmailConfirmationTokenProviderOptions>(options =>
                options.TokenLifespan = TimeSpan.FromDays(3));
        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration) 
        {
            var jwtConfiguration = new JwtConfiguration();
            configuration.Bind(jwtConfiguration.Section, jwtConfiguration);

            var secretKey = Environment.GetEnvironmentVariable("SECRET");
            if (secretKey is null)
                throw new Exception();

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = jwtConfiguration.ValidIssuer,
                        ValidAudience = jwtConfiguration.ValidAudience,

                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                    };
                });
        }

        public static void AddEmailSettings(this IServiceCollection services, IConfiguration configuration) 
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSenderService, EmailSenderService>();
        }
            
        public static void AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration) =>
            services.Configure<JwtConfiguration>(configuration.GetSection("JwtSettings"));

        public static void ConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(s => 
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo 
                { 
                    Title="E-Commerce WebAPI", 
                    Version="v1",
                    Description = "Products Categories API by oleitao",
                    TermsOfService = new Uri(""),
                    Contact = new OpenApiContact 
                    { 
                        Name="Oliveira Leitão",
                        Email= "olivleitao@gmail.com",
                        Url= new Uri("https://github.com/oleitao/")
                    }
                });

                s.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo 
                { 
                    Title = "E-Commerce WebAPI", 
                    Version = "v2",
                    Description = "Products Categories API by oleitao",
                    TermsOfService = new Uri(""),
                    Contact = new OpenApiContact
                    {
                        Name = "Oliveira Leitão",
                        Email = "olivleitao@gmail.com",
                        Url = new Uri("https://github.com/oleitao/")
                    }
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement() 
                { 
                    { 
                        new OpenApiSecurityScheme 
                        { 
                            Reference = new OpenApiReference 
                            { 
                                Type = ReferenceType.SecurityScheme, 
                                Id = "Bearer"
                            }, 
                            Name = "Bearer", 
                        }, 
                        new List<string>() 
                    } 
                });
            });
        }

        public static void UseForwardedHeaders(this IMvcBuilder builder)
        {
            string myPorxyServer = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ProxyConfiguration")["ProxyServer"];

            builder.Services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto;

                options.KnownProxies.Add(IPAddress.Parse(myPorxyServer));
            });
        }
    }
}

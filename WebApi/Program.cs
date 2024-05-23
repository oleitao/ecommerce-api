using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.Json.Serialization;
using WebApi.Helpers;
using WebApi.Services;
using WebApi.Extensions;
using NLog;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// add services to DI container
{
    var services = builder.Services;
    var env = builder.Environment;
 
    services.AddDbContext<DataContext>();
    services.AddCors();

    LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "\\nlog.config"));

    services.ConfigureCors();
    services.ConfigureIISIntegration();
    services.ConfigureLoggerService();

    services.AddControllers().AddJsonOptions(x =>
    {
        // serialize enums as strings in api responses (e.g. Role)
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

        // ignore omitted parameters on models to enable optional params (e.g. User update)
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    // configure DI for application services
    services.AddScoped<ICategoryService, CategoryService>();
    services.AddScoped<IImageUrlService, ImageUrlService>();
    services.AddScoped<IProductService, ProductService>();
    services.AddScoped<IReviewService, ReviewService>();
    services.AddScoped<IShopAvatarService, ShopAvatarService>();
    services.AddScoped<IShopService, ShopService>();
    services.AddScoped<IUserService, UserService>();

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

var app = builder.Build();

// configure HTTP request pipeline
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        // global cors policy
        app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

        app.UseDeveloperExceptionPage();
    }
    else
    {
        // global cors policy
        app.UseCors(x => x
            .WithOrigins("https://example.com")
            .AllowAnyMethod()
            .AllowAnyHeader());

        app.UseHsts();
    }

    // global error handler
    app.UseMiddleware<ErrorHandlerMiddleware>();

    app.UseHttpsRedirection();

    app.UseStaticFiles();
    app.UseForwardedHeaders(new ForwardedHeadersOptions 
    { 
        ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All
    });
    app.UseCors("CorsPolicy");

    app.UseAuthorization();

    app.MapControllers();
}

app.Run();
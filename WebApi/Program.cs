using AspNetCoreRateLimit;
using AutoMapper.Internal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog;
using System.IO;
using System.Text.Json.Serialization;
using WebApi.ActionFilters;
using WebApi.Extensions;
using WebApi.Helpers;

var builder = WebApplication.CreateBuilder(args);

// add services to DI container
{
    var services = builder.Services;
    var env = builder.Environment;

    //services.AddDbContext<RepositoryContext>();
    services.AddCors(options => { 
        options.AddPolicy("CorsPolicy", builder => 
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithExposedHeaders("X-Pagination"));
    });

    LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "\\nlog.config"));

    services.ConfigureCors();
    services.ConfigureIISIntegration();
    services.ConfigureLoggerService();
    services.ConfigureRepositoryManager();
    services.ConfigureServiceManager();
    services.ConfigureSqlContext(builder.Configuration);

    services.AddScoped<ValidationFilterAttribute>();

    services.AddMemoryCache();
    services.ConfigureRateLimitingOptions();
    services.AddHttpContextAccessor();

    services.AddAuthentication();
    services.ConfigureIdentity();
    services.ConfigureJWT(builder.Configuration);

    services.Configure<ApiBehaviorOptions>(options => 
    { 
        options.SuppressModelStateInvalidFilter = true;
    });
    /*
    services.AddControllers().AddApplicationPart(typeof(WebApi.AssemblyReference).Assembly);
    services.AddControllers(config =>
    {
        config.RespectBrowserAcceptHeader = true;
        config.ReturnHttpNotAcceptable = true;
        config.InputFormatters.Insert(0, JsonPatch.GetJsonPatchInputFormatter());
    }).AddXmlDataContractSerializerFormatters();
    */
    
    services.AddControllers().AddJsonOptions(x =>
    {
        // serialize enums as strings in api responses (e.g. Role)
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

        // ignore omitted parameters on models to enable optional params (e.g. User update)
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    }).AddXmlDataContractSerializerFormatters()
      .AddCustomCSVFormatter();
    

    services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(MappingProfile).Assembly);

    services.AddApiVersioning(opt => {
        opt.ReportApiVersions = true;
        opt.AssumeDefaultVersionWhenUnspecified= true;
        opt.DefaultApiVersion = new ApiVersion(1, 0);
    });

    services.AddMvc(options =>
    {
        options.SuppressAsyncSuffixInActionNames = false;
    });

    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}

var app = builder.Build();

//var logger = app.Services.GetRequiredService<ILoggerManager>();
//app.ConfigureExceptionHandler(logger);

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

    app.UseIpRateLimiting();
    app.UseCors("CorsPolicy");

    app.UseAuthentication();
    app.UseAuthorization();

    /*
    app.Use(async (context, next) => 
    { 
        Console.WriteLine($"Logic before executing the next delegate in the Use method"); 
        await next.Invoke(); Console.WriteLine($"Logic after executing the next delegate in the Use method"); 
    });
    app.Map("/usingmapbranch", builder => 
    { 
        builder.Use(async (context, next) => { 
            Console.WriteLine("Map branch logic in the Use method before the next delegate"); 
            await next.Invoke(); 
            Console.WriteLine("Map branch logic in the Use method after the next delegate"); }); 
        builder.Run(async context => { 
            Console.WriteLine($"Map branch response to the client in the Run method"); 
            await context.Response.WriteAsync("Hello from the map branch."); 
        }); 
    });
    app.MapWhen(context => context.Request.Query.ContainsKey("testquerystring"), builder => {
        builder.Run(async context => {
            await context.Response.WriteAsync("Hello from the MapWhen branch.");
        }); 
    });
    app.Run(async context => 
    {
        Console.WriteLine($"Writing the response to the client in the Run method"); 
        context.Response.StatusCode = 200; 
        await context.Response.WriteAsync("Hello from the middleware component.");
    });
    */

    app.MapControllers();
}

app.Run();
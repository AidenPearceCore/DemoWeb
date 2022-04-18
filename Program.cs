using DemoWeb.Models;
using DemoWeb.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ListService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0",
        Title = "DemoWeb API",
        Description = "Simple ASP.NET Core WebApi",
        TermsOfService = new Uri("https://github.com/yuchenmvc/demoweb"),
        Contact = new OpenApiContact
        {
            Name = "YuChenMVC",
            Url = new Uri("https://github.com/yuchenmvc")
        },
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://choosealicense.com/licenses/mit/")
        }
    });
    //options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    //{
    //    Name = "Authorization",
    //    In = ParameterLocation.Header,
    //    Type = SecuritySchemeType.ApiKey,
    //    Scheme = "Bearer",
    //    BearerFormat = "JWT",
    //    Description = "JWT Authorization"
    //});
    //options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    //{
    //    { new OpenApiSecurityScheme(){ }, new List<string>() }
    //});
    //options.AddSecurityRequirement(new OpenApiSecurityRequirement
    //{
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference
    //            {
    //                Type = ReferenceType.SecurityScheme,
    //                Id = "Bearer"
    //            }
    //        },
    //        new string[]{ }
    //    }
    //});
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
// Register EntityFrameworkCore Service
builder.Services.AddDbContext<DemoDatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DemoDatabase"));
});
//Add Cookie
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie();
//Add Authorize Filter
builder.Services.AddMvc(options =>
{
    options.Filters.Add(new AuthorizeFilter());
});
// CSRF
builder.Services.AddAntiforgery();
//builder.Services.AddAntiforgery(options =>
//{
//    options.FormFieldName = "AntiforgeryFieldname";
//    options.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
//    options.SuppressXFrameOptionsHeader = false;
//});
//Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
//Add WebHostEnvironment
IWebHostEnvironment env = app.Environment;
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();
// CSRF
//var antiforgery = app.Services.GetRequiredService<IAntiforgery>();
//app.Use((context, next) =>
//{
//    var requestPath = context.Request.Path.Value;

//    if (string.Equals(requestPath, "/", StringComparison.OrdinalIgnoreCase)
//        || string.Equals(requestPath, "/index.html", StringComparison.OrdinalIgnoreCase))
//    {
//        var tokenSet = antiforgery.GetAndStoreTokens(context);
//        context.Response.Cookies.Append("XSRF-TOKEN", tokenSet.RequestToken!,
//            new CookieOptions { HttpOnly = false });
//    }

//    return next(context);
//});
app.MapDefaultControllerRoute();

app.Run();

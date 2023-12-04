using API.Valorant.Dodle.Infra.Contextos;
using API.Valorant.Dodle.Utilitario;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.Json;

var cultureInfo = new CultureInfo("pt-BR");

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient();
builder.Services.AddControllers()
                .AddJsonOptions(op =>
                {
                    op.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    op.JsonSerializerOptions.Converters.Add(new JsonTimeSpanConverter());
                });
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("CorsPolicy", c =>
{
    c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

var connectionString = ConfiguracaoDoAppSettings.ObterStringDeConexaoSql();
Console.WriteLine(connectionString);
builder.Services.AddDbContext<Contexto>(x => x.UseSqlServer(connectionString));

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.ClearProviders();
    builder.AddConsole();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
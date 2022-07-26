using JSONtoXMLDeserializer.API.Services.Abstract;
using JSONtoXMLDeserializer.API.Services.Concrete;
using ILogger = JSONtoXMLDeserializer.API.Services.Abstract.ILogger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IJsonToXmlConverter, JsonToXmlConverter>();
builder.Services.AddSingleton<ILogger, TxtLogger>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
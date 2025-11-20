using HomeMiddleWare.MiddleWares;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://localhost:5000", "https://localhost:7000");


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMiddleware<MiddleWare1>();
}

app.MapControllers();
app.Run();
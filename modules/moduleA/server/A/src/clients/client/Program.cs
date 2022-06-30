var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o => 
{
    o.AddPolicy("cors", p => {
        p.AllowAnyOrigin();
        p.AllowAnyMethod();
        p.AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("cors");

app.UseAuthorization();

app.MapControllers();

app.Run();
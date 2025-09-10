using FutebolApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=futebol.db"));

// Adicionar serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilitar Swagger no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET all
app.MapGet("/times", async (AppDbContext db) =>
{
    return await db.Times.ToListAsync();
});

// GET por Id
app.MapGet("/times/{id}", async (int id, AppDbContext db) =>
{
    var time = await db.Times.FindAsync(id);
    return time is not null ? Results.Ok(time) : Results.NotFound("Time não encontrado!");
});

// POST - criar novo time
app.MapPost("/times", async (AppDbContext db, Time novoTime) =>
{
    db.Times.Add(novoTime);
    await db.SaveChangesAsync();
    return Results.Created($"/times/{novoTime.Id}", novoTime);
});

// PUT - atualizar time existente
app.MapPut("/times/{id}", async (int id, AppDbContext db, Time timeAtualizado) =>
{
    var time = await db.Times.FindAsync(id);
    if (time is null) return Results.NotFound("Time não encontrado!");

    time.Nome = timeAtualizado.Nome;
    time.Cidade = timeAtualizado.Cidade;
    time.TitulosBrasileiros = timeAtualizado.TitulosBrasileiros;
    time.TitulosMundiais = timeAtualizado.TitulosMundiais;

    await db.SaveChangesAsync();
    return Results.Ok(time);
});

// DELETE - remover time
app.MapDelete("/times/{id}", async (int id, AppDbContext db) =>
{
    var time = await db.Times.FindAsync(id);
    if (time is null) return Results.NotFound("Time não encontrado!");

    db.Times.Remove(time);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();

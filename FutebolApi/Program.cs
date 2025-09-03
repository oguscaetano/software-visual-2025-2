using System;
using FutebolApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar o SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=futebol.db"));

var app = builder.Build();

app.MapGet("/times", async (AppDbContext db) =>
    await db.Times.ToListAsync()
);

app.Run();

# Swagger

O **Swagger** é uma **ferramenta para documentar e testar APIs**. Ele transforma seu código de API em uma interface interativa no navegador, onde você consegue:

1. **Ver todos os endpoints** disponíveis na sua API.
2. **Entender quais parâmetros** cada endpoint espera (query, body, path, headers…).
3. **Ver os tipos de retorno** (JSON, objetos, listas, etc).
4. **Testar a API diretamente** do navegador, enviando requisições e vendo respostas.

---

### Por que é útil?

* Facilita a **documentação**: outros desenvolvedores sabem rapidamente como usar sua API.
* Ajuda no **debug e testes**, sem precisar criar scripts ou Postman.
* Gera **contratos da API** que podem ser usados por ferramentas de frontend ou mobile.


## **🪛 Instalar o swagger**

No terminal, na pasta do projeto rode o comando:

```bash
dotnet add package Swashbuckle.AspNetCore --version 7.0.0
```

---

## Alterações no `Program.cs`

O `Program.cs` completo ficaria assim:

```csharp
//using FutebolApi;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

// Configurar o SQLite
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlite("Data Source=futebol.db"));

// ✅ Adicionar serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Habilitar Swagger no ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.MapGet("/times", async (AppDbContext db) =>
//    await db.Times.ToListAsync()
//);

//app.MapGet("/times/{id}", async (int id, AppDbContext db) =>
//{
//    var time = await db.Times.FindAsync(id);
//    return time is not null ? Results.Ok(time) : Results.NotFound("Time não encontrado.");
//});

app.Run();
```

---

## Rodar a aplicação

```bash
dotnet run
```

Acesse no navegador:

```
https://localhost:5001/swagger
```

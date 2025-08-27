# 📚 Aula: Criando uma API Minimal com EF Core + SQLite

## 1. Criando o projeto do zero

No terminal, execute:

```bash
dotnet new web -n FutebolApi
cd FutebolApi
code .
```

Isso cria um projeto **API Minimal**.

---

## 2. Instalando pacotes necessários

Vamos instalar o **Entity Framework Core** com provedor para SQLite:

1. Ctrl + Shift + P
2. NuGet: Add NuGet Package
3. Microsoft.EntityFrameworkCore
4. Version 7.0.0

Faça o mesmo procedimento para intalar o Sqlite.

Também é possível fazer esse processo via CLI:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

## 3. Criando a classe `Time`

No arquivo `Time.cs`:

```csharp
namespace FutebolApi;

public class Time
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cidade { get; set; }
    public int TitulosBrasileiros { get; set; }
    public int TitulosMundiais { get; set; }
}
```

---

## 4. Criando o `DbContext`

No arquivo `AppDbContext.cs`:

```csharp
using Microsoft.EntityFrameworkCore;
using FutebolApi;

namespace FutebolApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Time> Times => Set<Time>();
}
```

---

## 5. Configurando o SQLite no `Program.cs`

Abra `Program.cs` e configure:

```csharp
//using FutebolApi;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

// Configurar o SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=futebol.db"));

//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
```

---

## 6. Criando o banco de dados (SQLite)

### 6.1 Criar a migration

```bash
dotnet ef migrations add InitialCreate
```

### 6.2 Criar o banco

```bash
dotnet ef database update
```

Isso gera o arquivo `futebol.db`.

---

## 7. Inserindo dados iniciais via SQL

Crie um arquivo chamado **`dados.sql`** com o seguinte conteúdo:

```sql
INSERT INTO Times (Nome, Cidade, TitulosBrasileiros, TitulosMundiais) VALUES
('Flamengo', 'Rio de Janeiro', 8, 1),
('Palmeiras', 'São Paulo', 12, 0),
('Corinthians', 'São Paulo', 7, 2),
('São Paulo', 'São Paulo', 6, 3),
('Grêmio', 'Porto Alegre', 2, 1),
('Internacional', 'Porto Alegre', 3, 0),
('Atlético Mineiro', 'Belo Horizonte', 2, 1),
('Cruzeiro', 'Belo Horizonte', 4, 0),
('Vasco da Gama', 'Rio de Janeiro', 4, 1),
('Santos', 'Santos', 8, 2);
```

Depois rode o comando o SQLite: Run Query da extensão SQLite.

---

## 8. Testando o GET

```csharp
// Endpoint GET - Buscar todos os times
app.MapGet("/", async (AppDbContext db) =>
    await db.Times.ToListAsync()
);
```

Rode a aplicação:

```bash
dotnet run
```

Acesse no navegador ou na extensão API Client Lite do VSCode:

```
http://localhost:5000/
```

---

## 9. O que vai aparecer (JSON)

A resposta será em **JSON**, algo assim:

```json
[
  {
    "id": 1,
    "nome": "Flamengo",
    "cidade": "Rio de Janeiro",
    "titulosBrasileiros": 8,
    "titulosMundiais": 1
  },
  {
    "id": 2,
    "nome": "Palmeiras",
    "cidade": "São Paulo",
    "titulosBrasileiros": 12,
    "titulosMundiais": 0
  }
]
```

---

## 10. JSON

* **JSON (JavaScript Object Notation)** é o formato mais usado para APIs.
* É leve, fácil de ler, e funciona em qualquer linguagem.
* Ele usa **pares chave-valor**.
* Exemplo:

  ```json
  {
    "nome": "Corinthians",
    "cidade": "São Paulo",
    "titulosBrasileiros": 7,
    "titulosMundiais": 2
  }
  ```
* O ASP.NET Core já transforma objetos C# em JSON automaticamente (usando `System.Text.Json`).

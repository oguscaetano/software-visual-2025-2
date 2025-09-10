# Método PUT

```csharp
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
```

## Requisição

```sh
PUT http://localhost:5298/times/3
content-type: application/json

{
  "nome": "Corinthians",
  "cidade": "São Paulo",
  "titulosBrasileiros": 28,
  "titulosMundiais": 999
}
```
# Método DELETE

```csharp
// DELETE - remover time
app.MapDelete("/times/{id}", async (int id, AppDbContext db) =>
{
    var time = await db.Times.FindAsync(id);
    if (time is null) return Results.NotFound("Time não encontrado!");

    db.Times.Remove(time);
    await db.SaveChangesAsync();
    return Results.NoContent();
});
```

## Requisição

```sh
DELETE http://localhost:5298/times/2
```
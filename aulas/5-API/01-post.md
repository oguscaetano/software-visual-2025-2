# Método POST

```csharp
// POST - criar novo time
app.MapPost("/times", async (AppDbContext db, Time novoTime) =>
{
    db.Times.Add(novoTime);
    await db.SaveChangesAsync();
    return Results.Created($"/times/{novoTime.Id}", novoTime);
});
```

## Requisição

```sh
POST http://localhost:5298/times
content-type: application/json

{
  "nome": "Real Madrid",
  "cidade": "Madrid",
  "titulosBrasileiros": 0,
  "titulosMundiais": 8
}
```

## JSON de times para POST

```json
[
  {
    "nome": "Real Madrid",
    "cidade": "Madrid",
    "titulosBrasileiros": 0,
    "titulosMundiais": 8
  },
  {
    "nome": "Barcelona",
    "cidade": "Barcelona",
    "titulosBrasileiros": 0,
    "titulosMundiais": 3
  },
  {
    "nome": "Manchester United",
    "cidade": "Manchester",
    "titulosBrasileiros": 0,
    "titulosMundiais": 2
  },
  {
    "nome": "Liverpool",
    "cidade": "Liverpool",
    "titulosBrasileiros": 0,
    "titulosMundiais": 1
  },
  {
    "nome": "Bayern de Munique",
    "cidade": "Munique",
    "titulosBrasileiros": 0,
    "titulosMundiais": 4
  },
  {
    "nome": "Milan",
    "cidade": "Milão",
    "titulosBrasileiros": 0,
    "titulosMundiais": 4
  },
  {
    "nome": "Inter de Milão",
    "cidade": "Milão",
    "titulosBrasileiros": 0,
    "titulosMundiais": 3
  },
  {
    "nome": "Chelsea",
    "cidade": "Londres",
    "titulosBrasileiros": 0,
    "titulosMundiais": 1
  },
  {
    "nome": "Ajax",
    "cidade": "Amsterdã",
    "titulosBrasileiros": 0,
    "titulosMundiais": 2
  },
  {
    "nome": "Santos Laguna",
    "cidade": "Torreón",
    "titulosBrasileiros": 0,
    "titulosMundiais": 0
  }
]

```
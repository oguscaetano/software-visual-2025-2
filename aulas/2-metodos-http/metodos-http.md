# Métodos HTTP e APIs Mínimas em C# .NET

## 1. Introdução: O que é HTTP?

* **HTTP (HyperText Transfer Protocol)** é o protocolo de comunicação da web.
* Ele define como **clientes (navegadores, apps, Postman, etc.)** e **servidores** trocam informações.
* O cliente envia uma **requisição HTTP**, e o servidor devolve uma **resposta HTTP**.

📌 Estrutura básica de uma requisição HTTP:

```
Método  URL        Versão
GET     /usuarios  HTTP/1.1
Headers (informações extras, como tipo de conteúdo, autenticação)
Body (opcional - usado em POST/PUT)
```

📌 Estrutura básica de uma resposta HTTP:

```
Versão  Código de Status  Mensagem
HTTP/1.1 200              OK
Headers
Body (conteúdo retornado)
```

---

## 2. Principais métodos HTTP

1. **GET** – Ler informações

   * Analogia: "Quero ver o cardápio de um restaurante".
   * Não altera nada no servidor, apenas consulta.

2. **POST** – Criar informações

   * Analogia: "Quero adicionar um pedido novo".
   * Envia dados no **body** da requisição.

3. **PUT** – Atualizar informações (substitui tudo)

   * Analogia: "Trocar meu pedido inteiro por outro".

4. **PATCH** – Atualizar parcialmente

   * Analogia: "Quero trocar apenas a bebida do meu pedido".

5. **DELETE** – Remover informações

   * Analogia: "Cancelar meu pedido".

---

## 3. Criando uma API mínima com .NET

### Passo 1: Criar projeto

```bash
dotnet new web -n MinhaApi
cd MinhaApi
dotnet run
```

👉 Isso gera uma API mínima já rodando na porta padrão `http://localhost:5000`.

---

## 4. Endpoints com cada método

### `Program.cs`

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GET - Buscar todos os usuários
app.MapGet("/usuarios", () =>
{
    List<string> nomes = new List<string>
    {
        "João",
        "Maria",
        "Luizinho",
    };

    return nomes;
});

// POST - Criar um novo usuário
app.MapPost("/usuarios", (string nome) =>
{
    return Results.Ok($"Usuário {nome} criado com sucesso!");
});

// PUT - Atualizar um usuário (substitui tudo)
app.MapPut("/usuarios/{id}", (int id, string novoNome) =>
{
    return Results.Ok($"Usuário {id} atualizado para {novoNome}");
});

// PATCH - Atualizar parcialmente (exemplo simples)
app.MapPatch("/usuarios/{id}", (int id, string campo, string valor) =>
{
    return Results.Ok($"Usuário {id} teve o campo {campo} atualizado para {valor}");
});

// DELETE - Remover um usuário
app.MapDelete("/usuarios/{id}", (int id) =>
{
    return Results.Ok($"Usuário {id} removido com sucesso!");
});

app.Run();
```

---

## 5. Status Codes importantes

* **200 OK** → deu certo.
* **201 Created** → recurso criado.
* **400 Bad Request** → erro do cliente (enviou dados errados).
* **404 Not Found** → não encontrado.
* **500 Internal Server Error** → problema no servidor.

---

## 6. Conclusão

* HTTP é a **linguagem da web**.
* Cada método tem um papel claro.
* Uma **API mínima** em .NET permite expor facilmente endpoints com esses métodos.
* Próximos passos: trabalhar com **banco de dados** e **modelos de dados**.
# Exercício

Você foi contratado para desenvolver uma **API de Gerenciamento de Times de Futebol Brasileiros**.
Essa API será usada por uma aplicação de estatísticas esportivas que precisa consultar, cadastrar e atualizar informações sobre os times.

Seu objetivo é criar uma **API mínima em .NET 7/8** que permita manipular dados de times de futebol.

## Estrutura de um time

Cada time terá as seguintes informações:

* `Id` (int) → identificador único do time
* `Nome` (string) → nome oficial do clube (ex: Flamengo, Corinthians, Palmeiras)
* `Cidade` (string) → cidade onde o clube está localizado
* `TitulosBrasileiros` (int) → número de títulos do Campeonato Brasileiro
* `TitulosMundiais` (int) → número de títulos mundiais

---

## Funcionalidades da API

1. **GET /times**

   * Retorna a lista de todos os times cadastrados.

2. **GET /times/{id}**

   * Retorna apenas o time com o `id` informado.
   * Se não existir, retornar `404 Not Found`.

3. **POST /times**

   * Cadastra um novo time.
   * Retornar `201 Created` com a mensagem `"Time {Nome} cadastrado com sucesso!"`.

4. **PUT /times/{id}**

   * Atualiza **todas as informações** de um time existente.
   * Se o `id` não existir, retornar `404`.

5. **DELETE /times/{id}**

   * Remove um time do sistema.
   * Retornar `200 OK` com a mensagem `"Time {id} removido com sucesso!"`.
   * Se não existir, retornar `404`.
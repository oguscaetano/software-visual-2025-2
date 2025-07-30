# 📘 Introdução ao C# e à Programação Orientada a Objetos (POO)

### 🎯 Objetivos da Aula

* Compreender o que é o C# e o .NET
* Configurar o ambiente de desenvolvimento com VS Code
* Escrever e executar o primeiro programa em C#
* Entender sintaxes básicas da linguagem
* Aprender os pilares básicos da orientação a objetos
* Criar e utilizar classes, atributos, métodos e objetos
* Compreender o conceito de relacionamento entre classes

## 🧠 Apresentação conceitual

* O que é C#?

  > Linguagem criada pela Microsoft, fortemente tipada, moderna e orientada a objetos. Muito usada no desenvolvimento de aplicações web, desktop, mobile e jogos com Unity.

* O que é o .NET Core?

  > Plataforma de desenvolvimento **open source e cross-platform** (Windows, macOS, Linux) para construção de aplicações modernas com C#.

---

## 🛠️ Configuração do Ambiente

### Passos para o setup no VS Code

1. Instalar o **.NET SDK** mais recente: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

2. Instalar o **VS Code** e a extensão **C# da Microsoft**

```bash
dotnet new list
```

3. Criar um novo projeto:

   ```bash
   dotnet new console -n AulaIntroCSharp
   cd AulaIntroCSharp
   code .
   ```

4. Executar o programa:

   ```bash
   dotnet run
   ```

## ✍️ Primeiro Programa em C#

### Código base: `Program.cs`

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, mundo!");
    }
}
```

### Conceitos abordados:

* `using System` → biblioteca padrão
* `class Program` → definição de classe
* `static void Main()` → ponto de entrada da aplicação
* `Console.WriteLine()` → saída no terminal

## 🔤 Sintaxe Básica da Linguagem

### 🧮 Tipos de dados

```csharp
int idade = 25;
double altura = 1.75;
char sexo = 'M';
string nome = "Gustavo";
bool ligado = true;
```

### 🔁 Estruturas de controle

```csharp
if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Valor de i: " + i);
    //Console.WriteLine($"Valor de i: {i}"); Interpolação
}
```

### 📦 Coleções simples

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
```

## 🧱 Conceitos Fundamentais de POO

### 🧩 O que é orientação a objetos?

* Abstração
* Encapsulamento
* Herança
* Polimorfismo

### 📌 Classe, Atributos e Métodos

#### Exemplo simples: Classe Pessoa

```csharp
class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
```

#### Usando a classe no `Main`:

```csharp
Pessoa p = new Pessoa();
p.Nome = "Ana";
p.Idade = 22;
p.Apresentar();
```

### 📘 Explicações:

* `public` → visibilidade pública
* `string Nome` → atributo
* `void Apresentar()` → método
* `new Pessoa()` → instanciando objeto

---

### 🔄 Construtores

```csharp
class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
```

```csharp
Pessoa p2 = new Pessoa("Carlos", 30);
p2.Apresentar();
```

## 🤝 Relacionamento entre Classes

### 🧭 Exemplo: Pessoa e Endereço

```csharp
class Endereco
{
    public string Rua;
    public string Cidade;
}

class Pessoa
{
    public string Nome;
    public Endereco EnderecoResidencial;

    public void MostrarEndereco()
    {
        Console.WriteLine($"Endereço: {EnderecoResidencial.Rua}, {EnderecoResidencial.Cidade}");
    }
}
```

```csharp
Endereco end = new Endereco();
end.Rua = "Av. Brasil";
end.Cidade = "São Paulo";

Pessoa p3 = new Pessoa();
p3.Nome = "Lucia";
p3.EnderecoResidencial = end;
p3.MostrarEndereco();
```

### Tipos de relacionamento

* **Composição**: Pessoa *tem um* Endereço

## 📚 Atividade

1. Criar as classes `Carro` e `Motor`.
2. `Carro` deve ter atributos como `modelo`, `ano` e um objeto `Motor`.
3. `Motor` deve ter `potencia` e `tipo`.
4. No `Main()`, instanciar um carro e mostrar todos os dados.

## 🧩 Dicas adicionais

* Usar **camelCase** para variáveis e **PascalCase** para classes
* Comentar o código com `//` para facilitar entendimento
* Praticar pequenos projetos antes de projetos maiores

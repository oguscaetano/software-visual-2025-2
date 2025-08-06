# EXERCÍCIOS

## **Exercício 1 – Declarando variáveis simples**
Crie um programa que declara as seguintes variáveis e exiba seus valores no console:

* Um número inteiro representando a idade de uma pessoa.
* Um número real representando a altura de uma pessoa.
* Um caractere representando a inicial do nome da pessoa.
* Um texto com o nome completo da pessoa.
* Um valor booleano indicando se a pessoa está ativa.

---

## **Exercício 2 – Conversa com o usuário**
Peça para o usuário digitar sua idade, altura, e nome. Depois, exiba essas informações no console formatadas de forma amigável.

---

## **Exercício 3 – Tipos e operações**
Crie duas variáveis inteiras chamadas `a` e `b`, com os valores 10 e 20. Some esses dois valores e exiba o resultado. Depois, crie duas variáveis do tipo `double` e faça o mesmo.

---

## **Exercício 4 – Tipos booleanos**
Crie uma variável chamada `temCarteiraMotorista` do tipo `bool`. Ela deve ser `true`. Depois, exiba no console a mensagem:
`"Você pode dirigir? true"`

---

## **Exercício 5 – Misturando tipos e concatenação**
Declare as seguintes variáveis:

* nome (string)
* idade (int)
* altura (double)
* gostaDeProgramar (bool)

Depois, exiba no console uma frase como:
`"Olá, meu nome é João, tenho 30 anos, 1.80m de altura e é verdade que gosto de programar: True"`

>Exiba a altura com 2 casas decimais.

---

## **Exercício 6 – Verificar se a pessoa é maior de idade**
Crie um programa que peça a idade do usuário e verifique se ele é maior de idade (18 anos ou mais). Exiba uma mensagem informando se a pessoa é maior ou menor de idade.

---

## **Exercício 7 – Verificar número positivo ou negativo**
Peça para o usuário digitar um número inteiro. Mostre na tela se ele é **positivo**, **negativo** ou **zero**.

---

## **Exercício 8 – Verificar se o aluno foi aprovado**
Solicite a nota de um aluno (de 0 a 10). Se a nota for maior ou igual a 6, exiba **"Aprovado"**, caso contrário, exiba **"Reprovado"**.

---

## **Exercício 9 – Verificar se o número é par ou ímpar**
Peça ao usuário um número inteiro. Mostre se ele é **par** ou **ímpar**.

---

## **Exercício 10 – Verificar se pode entrar em uma festa**
Um sistema de entrada de festa deve permitir apenas pessoas com idade igual ou maior que 18 **e** com convite. Solicite a idade e se a pessoa tem convite (true ou false). Exiba se a pessoa pode entrar ou não.

---

## **Exercício 11 – Verificar números pares e ímpares**
Use um loop `for` para percorrer os números de 1 a 10. Para cada número, mostre se ele é **par** ou **ímpar**.

---

## **Exercício 12 – Contar quantos nomes começam com uma letra**
Peça ao usuário para digitar 5 nomes. Para cada nome, verifique se ele **começa com a letra "A"** (maiúscula). Ao final, mostre quantos nomes começam com "A".

---

## **Exercício 13 – Contar quantos alunos foram aprovados**
Peça a nota de 5 alunos (valores `double`). Se a nota for maior ou igual a 6.0, considere o aluno aprovado. Ao final, mostre **quantos foram aprovados** e **quantos foram reprovados**.

>💡 Use CultureInfo.InvariantCulture para garantir que o separador decimal seja ponto (.):
```csharp
double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
```

---

## **Exercício 14 – Verificar respostas booleanas**
Peça ao usuário 5 vezes: **"Você gosta de programação?"** e espere que ele digite `true` ou `false`. Conte quantas respostas foram `true` e quantas foram `false`.

---

## **Exercício 15 – Verificar vogais e consoantes**
Peça ao usuário para digitar 5 letras (tipo `char`). Para cada letra, diga se é uma **vogal** ou **consoante**.
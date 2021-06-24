# Feito por Thiago Carrenho Ferreira

# Como executar

Ter o SDK do .Net Core 3.1

e executar o comando dotnet run ou

ctrl + f5

# Comandos pra gerar e que possibilitou o trabalho
dotnet add package Microsoft.EntityFrameworkCore.InMemory //EntityFramework instalar para poder executar o projeto
dotnet new webapi -o lanchonete //Usado pra gerar a estrutura do projeto da api no .NET Core 3.1

# Ferramenta que usei para testar as APIs
Usei o Postman para testar as APIs:(Verbos Http Get e Post)

# Primeira Url
https://localhost:5001/lanchonete/lanches

# Primeiro Post e posteriormente Get pra testar
{
    "lanche": "X-Burguer",
    "itens": "Hambúrguer de carne e queijo" ,
    "valor": 4.50
}

{
    "lanche": "X-Egg Bacon",
    "itens": "Ovo, Bacon, Hambúrguer de carne e queijo" ,
    "valor": 7.30
}

# Segunda url
https://localhost:5001/lanchonete/ingredientes

# Segundo Post e Get pra testar
{
    "lanche": "X-Bacon",
    "itens": "Bacon, Hambúrguer de carne e queijo" ,
    "valor": 6.50
}

{
    "nome": "Hambúrger de carne",
    "preco": 3.00 ,
    "lanchesId": 1
}

{
    "nome": "Bacon",
    "preco": 2.00 ,
    "lanchesId": 2
}

{
    "nome": "Bacon",
    "preco": 2.00 ,
    "lanchesId": 3
}

# Testar a terceira Url pra receber pelo método GET o ingrediente com id X
https://localhost:5001/lanchonete/ingredientes/3

https://localhost:5001/lanchonete/ingredientes/1

# Testar quarta url pra receber pelo método GET e verificar o ingrediente relacionado com o nome do lanche formado pelo ingrendiente do id X

https://localhost:5001/lanchonete/ingredientes/lanches/1

https://localhost:5001/lanchonete/ingredientes/lanches/2

https://localhost:5001/lanchonete/ingredientes/lanches/3
# My Finance

O `My Finance` é um projeto realizado para demonstrar a aplicação de alguns conceitos e arquiteturas vistas na aula de `Práticas de Implementação e Evolução de Software`

## 🛠️ Tecnologias

Este projeto está estruturado em:
- .NET 9
- Entity Framework Core com suporte para Sqlite e SQL Server
- EF Migrations para criação e inserção de registros em ambos os motores de banco de dados
- Angular 20
- OpenAPI Specification 3.0
- Minimal Apis

## 🧱 Arquitetura

Este projeto está desenvolvido utilizando **Clean Architecture** como base, separando as responsabilidades nas seguintes camadas:

- **Domain**: Possui as regras de negócio relacionadas aos modelos. É representada pelo projeto `MyFinance.Domain`.
- **Aplicação**: Gerencia as requisições. É representada pelo projeto `MyFinance.Application`.
- **Infraestrutura**: Configura as dependências externas, principalmente acesso ao banco de dados. É representada pelo projeto `MyFinance.Infra`.
- **Apresentação**: Endpoints e o app Angular que trabalha como frontend da aplicação. É representada pelo projeto `MyFinance.Presentation`.
- **Inversão de Dependência**: Responsável por realizar todo o registro de DI. É representada pelo projeto `MyFinance.Ioc`.

## ⚙️ Como Executar

```
ATENÇÃO: Por utilizar EF Migrations, não é necessário realizar a aplicação de nenhum script de banco de dados. Basta subir a aplicação conforme explicado abaixo e o banco de dados será criado e populado automaticamente.
```
1. Clone o repositório:

```bash
git clone https://github.com/SamRener/myFinance.git
cd myfinance
```

2. [Opcional] Configure o `appsettings.Development.json` com:

- String de Conexão da base de dados SQL Server

```
Esse projeto possui a capacidade de rodar mesmo sem um banco de dados Sql Server configurado, através do Sqlite. Caso queira utilizar o Sqlite, basta ignorar o passo 2.
```


3. Execute a aplicação:

```bash
dotnet run --project MyFinance.Presentation
```

4. Acesse a aplicação em: http://localhost:5141


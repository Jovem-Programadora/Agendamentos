# Objetivo e Funcionalidades 
Sistema de agendamento de horarios, permitindo aos usuários agendar seu horario, editar e remover.

## Tecnalogias 
- Linguagem: CSS, C#;
- Banco de Dados: API.

## Pre-requisitos 
- NET-SDK (versão 8.0)
- Git 
- Visual studio 2022
- API 
 
## Passo de Instalação 
- Clonar o repositorio no git clone atravez do prompt de comando()
- Acessar a pasta do projeto (cd Agendamentos)
- Restaurar dependências (dotnet restore)
- Abra as configurações base do arquivo(appsettings.json) e define as strings de conexão do banco de dados:
"ConnectionStrings":{ "DefaultConnection":"Server=localhost;Database=MeuDB;User Id=sa;Password=123;"}
	""Logging": { "LogLevel": {"Default": "Information", "Microsoft.AspNetCore": "Warning" } }"

## Acessar o nosso site
- Link do site: 

## Documentação de Design
- Cores: Produto (#DBC170 #B8952E #846F2E) Base (#F5F4F5 #B2AFB6 #98959D #7A767F #3E3C41 #2E2C30 #232225 #19181B #050505)
- Componentes: Button, Text Input, Data Input, Time Select, Calendar.
- Tipografia: Catamaran.
- Millena Kupsinskü Martins.

## Documentação de manutenção e boas práticas
- todos os commits devem seguir os padrão conventional Commits.
- As branches seguem o formato: feature/nome, fix/nome.
- Para acessar a logs e monitoramento do ambiente de produção, leia https://learn.microsoft.com/pt-br/azure/devops/?view=azure-devops


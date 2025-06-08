# EcoAlert

Um breve e conciso resumo do seu projeto. O que ele faz? Qual problema ele resolve?
## 💡 Visão Geral

Detalhe um pouco mais sobre o projeto. Explique o contexto, o propósito e a arquitetura geral (MVC).

## 👩‍👦‍👦 Equipe
- Felipe Seiki Hashiguti - RM98985
- Lucas Corradini Silveira - RM555118
- Matheus Gregorio Mota - RM557254

## ✨ Funcionalidades

Liste as principais funcionalidades que o seu aplicativo oferece. Use bullet points para clareza.

* Funcionalidade 1: Descrição detalhada.
* Funcionalidade 2: Descrição detalhada.
* Funcionalidade 3: Descrição detalhada.

## 📈 Diagramas

Esta seção deve conter diagramas que ajudam a entender a arquitetura e o fluxo do seu aplicativo.

### Diagrama de Arquitetura

Descreva brevemente o diagrama de arquitetura. Pode ser um diagrama de componentes, camadas ou um diagrama de contexto.

## ⚡ Executando o Projeto
### ✅ Pré-requisitos
- .NET SDK 8.0 ou superior instalado
- Oracle Database acessível
- Visual Studio 2022 ou VS Code com extensões C#

### 🚀 Instruções de Acesso (Configuração e Execução)
Instruções passo a passo para configurar e rodar o projeto.

1. Clonar o Repositório
```bash
git clone https://github.com/MatheusGmota/EcoAlert.git
cd EcoAlert
```

### ⚙ Configuração do Banco de Dados
No arquivo `appsettings.Development.json` em `appsettings.json`, configure os dados do banco Oracle, alterando o `HOST`, `User Id` e a `Password`:
```
"ConnectionStrings": {
  "Oracle": "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=host)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=ORCL)));User Id=userId};Password=senha;"
}
```

Verifique se a pasta `Migrations`  existe no seu diretorio, caso não tenha abra o Console Gerenciador de Pacotes e execute os seguintes comandos
```
// Gerar a migration caso necessário
Add-Migration intitdb 

// Atualizar o banco de dados
Update-Database
```

### 🖥️ Com Visual Studio
- Abra a solução EcoAlert.sln
- Defina o projeto EcoAlert como startup
- Execute com F5 ou Ctrl+F5

### 💻 Com terminal
```bash
cd EcoAlert
dotnet build
dotnet run
```

### 📚 Documentação Interativa
- Ao executar a API, acesse a documentação Swagger digitando `/swagger` para testar os endpoints diretamente pelo navegador.

## 🛠️ Tecnologias Utilizadas
- [ASP.NET](http://ASP.NET "smartCard-inline")  Core 8
- Entity Framework Core
- Swashbuckle (Swagger)
- Banco de dados Oracle
- Visual Studio 2022


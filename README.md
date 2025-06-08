# EcoAlert
 
O EcoAlert é uma aplicação web desenvolvida com ASP.NET Core 8, focada na gestão e monitoramento de limiares ambientais. A plataforma permite a visualização, o cadastro, edição e exclusão de valores máximos e mínimos para variáveis ambientais, como temperatura ou umidade, que podem ser posteriormente consumidos por sistemas externos para geração de alertas.

## 💡 Visão Geral

O projeto EcoAlert surge da necessidade de manter um controle centralizado e confiável sobre os limiares ambientais usados em sistemas que monitoram variáveis do meio ambiente (como sensores de temperatura, umidade ou qualidade do ar). Esses limiares são usados como referência para alertar sobre situações fora dos padrões normais.
A plataforma expõe uma API RESTful que permite a integração com outros sistemas — como uma aplicação em Java que consome os limiares cadastrados e gera alertas com base nas leituras dos sensores.

## 👩‍👦‍👦 Equipe
- Felipe Seiki Hashiguti - RM98985
- Lucas Corradini Silveira - RM555118
- Matheus Gregorio Mota - RM557254

## ✨ Funcionalidades

- ✅ **Cadastro de Limiar Ambiental**
  Permite ao usuário inserir novos registros de limiares contendo nome, valor mínimo e valor máximo para determinada variável ambiental. Esses dados são armazenados em um banco de dados relacional Oracle.
- ✏️ **Edição e Exclusão de Limiar**
  Oferece uma interface simples e eficiente para editar os valores de limiares previamente cadastrados, bem como removê-los do sistema caso não sejam mais necessários.
- 🌐 **API REST para Integração Externa**
  Disponibiliza endpoints RESTful para consulta e gerenciamento dos limiares, facilitando a integração com sistemas de terceiros (como a aplicação Java que consome esses dados para análise em tempo real).
- 🧭 **Interface Web com Razor Pages e TagHelpers**
  Utiliza as ferramentas nativas do [ASP.NET](http://ASP.NET "smartCard-inline")  Core para construir páginas web dinâmicas e responsivas, facilitando o uso por administradores.
- 📑 **Documentação via Swagger**
  A API REST conta com documentação interativa através do Swagger, permitindo testes rápidos e visualização completa dos endpoints disponíveis.
- 📂 **Uso de Migrations para Evolução do Banco de Dados**
  Toda a estrutura do banco de dados é gerenciada com Migrations do Entity Framework Core, garantindo rastreabilidade e consistência nas alterações de schema.

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
## 📡 Endpoints
### 📈 LimiarController

- `GET /api/limiar`
   Retorna todos os limites climáticos cadastrados.
- `GET /api/limiar/{id}`
   Retorna os dados de um limite climático específico pelo seu `id`.
- `POST /api/limiar`
   Cria um novo limite climático.
   Corpo da requisição:
   ```java
   {
    "parametroSensor": "temperatura",
    "valorMin": 10,
    "valorMax": 35,
    "msgMin": "Temperatura muito baixa!",
    "msgMax": "Temperatura muito alta!",
    "recomendacaoAlerta": "Procure abrigo ou fontes de aquecimento/resfriamento"
  }
   ```
- `PUT /api/limiar/{id}`
   Atualiza os dados de um limite climático existente pelo `id`.
- `DELETE /api/limiar/{id}`
   Remove um limite climático existente.

### 📚 Documentação Interativa
- Ao executar a API, acesse a documentação Swagger digitando `/swagger` para testar os endpoints diretamente pelo navegador.]

  ![image](https://github.com/user-attachments/assets/e5f0195c-e95d-49d1-888b-5c4d3fb2f6c0)


## 🛠️ Tecnologias Utilizadas
- [ASP.NET](http://ASP.NET "smartCard-inline")  Core 8
- Entity Framework Core
- Swashbuckle (Swagger)
- Banco de dados Oracle
- Visual Studio 2022


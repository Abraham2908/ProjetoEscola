<h1 align="center">
     :computer: <a href="#" alt="site do ecoleta">Projeto Escola </a>
</h1>

<h3 align="center">
    Aplicação simples para cadastro de professores e alunos. Construida utilizando Vue para o Front End e uma Web Api .NET Core 5 para o Back End.
</h3>

</p>

<h4 align="center">
	🚧   Em Construção 🚀 🚧
</h4>

Tabela de conteúdos
=================
<!--ts-->
   * [Sobre o projeto](#-sobre-o-projeto)
   * [Funcionalidades](#%EF%B8%8F-funcionalidades)
   * [Como executar o projeto](#-como-executar-o-projeto)
     * [Pré-requisitos](#pré-requisitos)
     * [Rodando a Aplicação](#user-content--rodando-a-aplicação)
   * [Tecnologias](#-tecnologias)
   * [Autor](#-autor)
   * [Licença](#user-content--licença)
<!--te-->


## 💻 Sobre o projeto

:computer: Projeto Escola - é uma aplicação base para cadastro de professores e alunos.

A aplicação é uma base de .NET Core 5 Web API com VueJs.<br/><br/>
O sistema conta com diversas possibilidades de aprimoramento e implementações que podem ser realizadas em cima do Projeto.

---

## ⚙️ Funcionalidades

  - [x] Cadastro de professores
  - [x] Cadastro de alunos
  - [x] Quantidade de alunos por professor
  - [x] Painel de detalhes de aluno

---

## 🚀 Como executar o projeto

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina a seguinte ferramenta:
[Git](https://git-scm.com). 
Além disto, é bom ter uma IDE ou editor para trabalhar com o código como [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) no caso de Windows ou 
[VSCode](https://code.visualstudio.com/) para demais plataformas.

#### 🎲 Rodando a aplicação

```bash
Visual Studio 2019 -

  Clone este repositório
$ git clone https://github.com/Abraham2908/ProjetoEscola

# Abra seu VS 2019, selecione a opção abrir um projeto ou uma solução, vá até o diretorio onde 
# o projeto foi clonado e selecione o ProjetoK1.sln.

Entity Framework Core

# Agora vamos instalar o EF Core, Para instalar o Entity Framework em nosso projeto vamos usar a opção do 
# menu Tools-> Nuget Package Manager ->  Package Manage Console.

# Vamos instalar o provider para o SQL Server.

# Digite o seguinte comando : Install-Package Microsoft.EntityFrameworkCore.SqlServer

# A seguir vamos instalar o Microsoft.EntityFrameworkCore.Tools para ter acesso às ferramentas de Scaffolding e 
# usar o Migrations em nosso projeto.

# Digite o comando : Install-Package Microsoft.EntityFrameworkCore.Tools

Banco de Dados - SQL Server

# O banco de dados está configurado para o meu servidor,  
# para mudar a conexão, é só ir até o arquivo appsettings.json e alterar a Connection string de acordo com
# a sua conexão, como desejar.

# Abra o Package Manager Console e digite o comando: Update-database

# Abra o SQL Server Object Explorer e em seguida clique no (localdb) ou faça conexão com o seu SQL SERVER, 
# vá ate o banco de dados ProjetoEscola
# e verifique a aba tables para verificar se as tables foram criadas.
# Caso não, digite no Package Manager Console o comando: Add-migration (nome) e em seguida Update-database

# Execute o projeto teclando Ctrl + F5.

# O servidor inciará. 

```
#### 🎲 Rodando o Front End

Vá até o diretório onde se encontra a aplicação Vuejs e rode os seguinte comando:
```
npm install
```
Em seguida, inicie o servidor.
```
npm run serve
```
---

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

#### **Front-End**  ([VueJs](https://vuejs.org/) + [Bootstrap](https://getbootstrap.com/))


#### **Back-End**  ([C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)  +  [.NET Core 5](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0))

-   **[Sistema de Cadastro/Autenticação - (Falta Implementação]**

#### **Banco de Dados**  ([SQL Server](https://www.microsoft.com/pt-br/sql-server/))


---

## 🦸 Autor

 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/85251911?s=400&u=879b9dbf2180c63fc98bde28f93c6d85c17ee215&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Abraham França</b></sub></a> <a href="https://blog.rocketseat.com.br/author/thiago/" title="Rocketseat">🚀</a>
 <br />

[![Linkedin Badge](https://img.shields.io/badge/-Abraham-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/abraham-franca/)](https://www.linkedin.com/in/abraham-franca/) 
[![Gmail Badge](https://img.shields.io/badge/-abrahampedrog@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:abrahampedrog@gmail.com)](mailto:abrahampedrog@gmail.com)

---

## 📝 Licença

Este projeto esta sobe a licença [MIT](./LICENSE).

Feito por Abraham França 👋🏽 [Entre em contato!](https://www.linkedin.com/in/abraham-franca/)

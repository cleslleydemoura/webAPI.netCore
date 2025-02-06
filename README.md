<h1>webAPI.netCore</h1>

<p align="center">
  <a href="#">
      <img src="https://skillicons.dev/icons?i=cs,dotnet,mysql"/>
  </a>
</p>
<hr>
<h1>Introdução</h1>
<p>Neste repositório, está a base de uma estrutura em C# utilizando .NET (v8.0), projetado para facilitar o desenvolvimento de aplicações e a utilização de ferramentas essenciais para versionamento de banco de dados via migrações e documentação automática com Swagger.</p>

<h1>Guia Completo para Configuração de um Projeto .NET com Web API e MySQL</h1>
<h2>1. Criando o Projeto Web API</h2>
<p>Para iniciar um novo projeto .NET Core Web API, use o seguinte comando:</p>

```dotnet new webapi -o api```

<p>Este comando cria um novo projeto do tipo Web API na pasta api. Agora, para acessar a api:</p>

```cd api```

<h2>2. Rodando a API em desenvolvimento</h2>
<p>Para rodar a API de desenvolvimento e acompanhar as mudanças em tempo real, digite no terminal:</p>

```dotnet watch run```

<p>Esse comando inicia a aplicação, recompilando automaticamente o código sempre que houver alterações (hot reload).</p>

<h2>3. Instalando Pacotes NuGet para MySQL</h2>
<p>Utilizando o VSCode, baixe a extensão do NuGet Gallery e instale as seguintes extensões: </p>
<ul>
    <li>Microsoft.EntityFrameworkCore.SqlServer</li>
    <li>Microsoft.EntityFrameworkCore.Tools</li>
    <li>Microsoft.VisualStudio.Azure.Containers.Tools.Targets</li>
    <li>Swashbuckle.AspNetCore</li>
</ul>

# Funções das extenções:

| Pacote | Função | Comando
|--------|--------|--------|
|📌 `Microsoft.EntityFrameworkCore.SqlServer` |  Permite que aplicações .NET interajam com bancos de dados Microsoft SQL Server usando Entity Framework Core. |```dotnet add package Microsoft.EntityFrameworkCore.SqlServer```|
|📌 `Microsoft.EntityFrameworkCore.Tools` | Fornece ferramentas para gerenciar o Entity Framework Core via linha de comando e permite criar e aplicar migrações, gerar código a partir do banco e atualizar o esquema do banco. |```dotnet add package Microsoft.EntityFrameworkCore.Tools```|
|📌 `Microsoft.VisualStudio.Azure.Containers.Tools.Targets` | Auxilia na integração e implantação de contêineres Docker dentro do Visual Studio e permite executar, depurar e publicar aplicações em contêineres de forma integrada. |```dotnet add package Microsoft.EntityFrameworkCore.Tools```|
| 📌`Swashbuckle.AspNetCore` | Adiciona suporte ao Swagger para documentar e testar APIs. |```dotnet add package Swashbuckle.AspNetCore```|

<h2>4. Migration e conexão com SQL</h2>
<p>Quando se trabalha com Entity Framework Core e deseja utilizar seu próprio modelo em um banco de dados, utiliza-se o conceito de migrações.</p>
<p>A migração permite que seja criado ou atualizado a estrutura do banco de dados automaticamente a partir do código da aplicação, sem a necessidade de <b>escrever os comandos SQL manualmente</b>.</p>

```dotnet ef migrations add init```

<p><b>ALTERAÇÃO no appsettings.json</b>: Devem ser adicionadas as linhas: </p>

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source={NOME-DO-SEU-COMPUTADOR}\\SQLEXPRESS;Initial Catalog={NOME-DA-SUA-TABELA};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
  },
```
<p>As informações sobre sua tabela e nome do computador devem estar de acordo com as fornecidas dentro do <b>SQL Server Management Studio</b>.</p>
<p>Comando para verificar se todas as pendências estão sincronizadas com o banco de dados:</p>

```dotnet ef database update```
<p>Aplica todas as migrações pendentes ao banco de dados, garantindo que ele esteja sincronizado com o modelo definido no código da aplicação.</p>


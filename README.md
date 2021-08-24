# Comandos iniciais:
``` bash
mkdir aula-desafio21dias-mvc-entity-framework #criei a pasta 
cd aula-desafio21dias-mvc-entity-framework # entrei dentro dela
dotnet new mvc # criei meu projeto
```

# Comando git 
``` bash
code .gitignore  ### gerei o conteudo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore
Criei o repositorio e rodei os comandos
```
``` bash
git init
git add .
git commit -m "Iniciando projeto"
git remote add origin https://github.com/wotoss/atencao-desafio21dias-mvc-entity-framework.git
git branch -M main
git push -u origin main
```
#Componentes instalados:
```bash
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.9
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.9
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```
# Comandos para migração
``` bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add nomeDamigracao
dotnet ef database update
```
```bash
#Dicas
Mega explicação sobre string de connecção 1:30

```
# Instalação do code generator
```bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de Aluno
```bash
#colocando o --useDefaultLayout ele faz com o layout padrão para todas as paginas.
dotnet aspnet-codegenerator controller -name AlunosController -m Aluno -dc DbContexto --relativeFolderPath Controllers --useDefaultLayout

GET - Buscar informações.
POST - Cadastrar informações.
PUT - Para fazer a alteração de todos os campos.
PATCH - Para fazer alterações de alguns 


Web - HTML ... Amaram as coisas por suas tags
SOAP - XML ...

REST - GET, POST, PUT, DELETE ....Minimo para uma App rest, (JSON ou XML)

RESTFULL - REST - GET, POST, PUT, DELETE ....Responde por formatos diferentes, HTML
```
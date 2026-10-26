Project name : Ticketing and booking

Steps : 
1.Project creation
2.schema design
3.migrations

-------------
check versions of all tools
dotnet --version
node --version
docker --version
psql --version
----------------
1.Project-creation:
-> mkdir Ticketing && cd Ticketing
-> Backend: 
 dotnet new sln -n Ticketing
 dotnet new webapi -n Ticketing.Api -o backend/Ticketing.Api --use-controllers
 dotnet sln add backend/Ticketing.Api
-> Frontend : 
npm create vite@latest frontend -- --template react-ts
cd frontend && npm install 
------------------
--each file usecase--
1.Ticketing.slnx -> solution file -it lists .net projects and treate them as one unit.
2.Readme.md file -> for project description
3.Program.cs -> the entry point
4.Ticketing.Api.csproj -> project file -lists all the packages and version of .net.
5.Controllers - in this we have files for different feature endpoints.
6.Model - classes of like DTO
7.appsettings.json - configuaration: logging and dbconnection  string
8.appsettings.development.json - overides used in development environment.
9.Properties/launchSettings.json - which ports and URLS dotnet run uses.
10.Ticketing.Api.http - A file for sending requests from VS Code or visual Studio.
bin/,obj/ - build output.

Frontend Files: 
1.index.html - main file browser open this file first.
2.main.tsx - entrypoint for javascript code.
---
in index.html file <div> empty container then script tag tells browser to load main.
<script type="module" src="/src/main.tsx"></script>
main file it renders react app.
createRoot(documnet.getElementById('root')!).render(<App />)
---
3.app.tsx - root react component -SPA
4.assets - styles and images
5.package.json - dependencies and scripts ?????
6.ESLint and oxlint are linters- reads the code withoout running it  and flags likely bugs and style problems.
7.package-lock.json - records exact versions of every package
8.vite.config.ts - configures vite-
=React plugin- handles jsx and hot reload
=proxy - frontend calls /api and forwarded to .net through port 5210
or custom port
9.eslint.config.js - it holds ESLint rules.
10.public - holds static files
11.dist - build file -npm run build
12.node_modules - npm i -consist all downloaded packages.
-------------------------------
Migrations : 
-add packages - 
dotnet add package npgsql.EntityFrameworkCore.PostgreSQL - EFCore speak to postgres
dotnet add package Microsoft.EntityFrameworkCore.Design - need for migrations
dotnet tool install --global dotnet-ef - command line tool-(add,update db)

-----
Entities : 
for every table - one entity class
public class entity_name {
    public type Property_name {get;set;}
}
get - to get a value and set - set a value
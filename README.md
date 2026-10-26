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
index.html - main file browser open this file first.
main.tsx - entrypoint for javascript code.
---
in index.html file <div> empty container then script tag tells browser to load main.
<script type="module" src="/src/main.tsx"></script>
main file it renders react app.
createRoot(documnet.getElementById('root')!).render(<App />)
---
app.tsx - root react component -SPA
assets - styles and images
package.json - dependencies and scripts ?????
ESLint and oxlint are linters- reads the code withoout running it  and flags likely bugs and style problems.
package-lock.json - records exact versions of every package
vite.config.ts - configures vite-
=React plugin- handles jsx and hot reload
=proxy - frontend calls /api and forwarded to .net through port 5210
or custom port
eslint.config.js - it holds ESLint rules.
public - holds static files
dist - build file -npm run build
node_modules - npm i -consist all downloaded packages.

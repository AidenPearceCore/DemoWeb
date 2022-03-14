DemoWeb WebApi後端
------------------


>說明\n
簡易ASP.NET Core WepApi CRUD 實作\n\n

/appsettings.json 組態資料\n
/launchSettings.json 環境設定\n
/Program.cs EntryPoint&註冊DI\n
/.gitattributes Git版控\n
/DemoWeb.csproj 相關套件\n


>開發語言\n
C#\n


>資料表schema建立Script\n
DemoWeb/DemoData/DemoDatabase.sql\n


>編譯&建置版本\n
Visual Studio 2022\n
SQL Server Express 2019\n
SQL Server Management Studio 18\n


>測試範例\n
請求\n
GET /api/List/{id}/ information HTTP/1.1\n
參數說明\n
[HttpGet("{id}")]\n
回應\n
HTTP/1.1 200 OK + json格式資料回傳\n


>待學習
- Azure CI/CD
- 自動化Unit testing
- Markdown語法 <https://www.markdownguide.org/basic-syntax/>
- <https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio>
- <https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-6.0?view=aspnetcore-6.0>


DemoWeb WebApi後端
------------------


>說明
<br>簡易ASP.NET Core WepApi CRUD 實作<br><br>

/appsettings.json 組態資料<br>
/launchSettings.json 環境設定<br>
/Program.cs EntryPoint&註冊DI<br>
/.gitattributes Git版控<br>
/DemoWeb.csproj 相關套件<br><br>


>開發語言
<br>C#<br><br>


>資料表schema建立Script
<br>DemoWeb/DemoData/DemoDatabase.sql<br><br>


>編譯&建置版本
<br>Visual Studio 2022<br>
SQL Server Express 2019<br>
SQL Server Management Studio 18<br><br>


>測試範例
<br>請求<br>
GET /api/List/{id}/ information HTTP/1.1<br>
參數說明<br>
[HttpGet("{id}")]<br>
回應<br>
HTTP/1.1 200 OK + json格式資料回傳<br><br>


>待學習
- Azure CI/CD
- 自動化Unit testing
- Markdown語法 <https://www.markdownguide.org/basic-syntax/>
- <https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio>
- <https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-6.0?view=aspnetcore-6.0>


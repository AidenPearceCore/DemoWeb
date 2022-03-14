DemoWeb WebApi後端
------------------


>說明
簡易ASP.NET Core WepApi CRUD 實作

/appsettings.json 組態資料
/launchSettings.json 環境設定
/Program.cs EntryPoint&註冊DI
/.gitattributes Git版控
/DemoWeb.csproj 相關套件


>開發語言
C#


>資料表schema建立Script
DemoWeb/DemoData/DemoDatabase.sql


>編譯&建置版本
Visual Studio 2022
SQL Server Express 2019
SQL Server Management Studio 18


>測試範例
請求
GET /api/List/{id}/ information HTTP/1.1
參數說明
[HttpGet("{id}")]
回應
HTTP/1.1 200 OK + json格式資料回傳


>待學習
- Azure CI/CD
- 自動化Unit testing
- Markdown語法 <https://www.markdownguide.org/basic-syntax/>
- <https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio>
- <https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-6.0?view=aspnetcore-6.0>


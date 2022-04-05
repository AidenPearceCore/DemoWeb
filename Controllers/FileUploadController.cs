using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public FileUploadController(IWebHostEnvironment env)
        {
            _env = env;
        }

        #region Post(List<IFormFile> files) 多筆檔案上傳
        [HttpPost]
        public void Post(List<IFormFile> files)
        {
            //取得存放目錄
            string rootPath = _env.ContentRootPath + @"\wwwroot\";
            //多筆檔案傳入
            foreach(var file in files)
            {
                //空檔案不上傳
                if(file.Length > 0)
                {
                    string filePath = file.FileName;
                    using var stream = System.IO.File.Create(rootPath + filePath);
                    file.CopyTo(stream);
                }
            }
        }
        #endregion
    }
}


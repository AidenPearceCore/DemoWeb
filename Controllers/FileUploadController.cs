using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// 多筆檔案上傳
        /// </summary>
        /// <param name="files">檔案</param>
        [HttpPost]
        public void Post(List<IFormFile> files)
        {
            string rootPath = _env.ContentRootPath + @"\wwwroot\"; //取得存放目錄            
            foreach (var file in files)                            //多筆檔案傳入
            {                
                if(file.Length > 0)                                //空檔案不上傳
                {
                    string filePath = file.FileName;
                    using var stream = System.IO.File.Create(rootPath + filePath);
                    file.CopyTo(stream);
                }
            }
        }
    }
}


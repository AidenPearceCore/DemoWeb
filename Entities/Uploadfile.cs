using System;
using System.Collections.Generic;

namespace DemoWeb.Entities
{
    public partial class Uploadfile
    {
        /// <summary>
        /// 上傳檔案編號
        /// </summary>
        public int UploadFileId { get; set; }
        /// <summary>
        /// 檔名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 路徑
        /// </summary>
        public string? Src { get; set; }
        /// <summary>
        /// 物件編號
        /// </summary>
        public int? HouseId { get; set; }
    }
}

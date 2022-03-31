using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    public partial class Customer
    {
        /// <summary>
        /// 客戶編號
        /// </summary>
        public string Id { get; set; } = null!;
        /// <summary>
        /// 性別
        /// </summary>
        public string? Gender { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }
        
        //TODO: 待新增 市內電話 與 手機 欄位
        
        /// <summary>
        /// 電話
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// 電子郵件
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// 詳細地址
        /// </summary>
        public string? Street { get; set; }
        /// <summary>
        /// 城市地址
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        /// 客戶公司
        /// </summary>
        public string? Company { get; set; }

        public virtual Company IdNavigation { get; set; } = null!;
    }
}

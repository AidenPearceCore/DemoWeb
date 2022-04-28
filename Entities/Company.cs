using System;
using System.Collections.Generic;

namespace DemoWeb.Entities
{
    public partial class Company
    {
        /// <summary>
        /// 公司編號
        /// </summary>
        public string Id { get; set; } = null!;

        //TODO: 待新增 集團 子公司 等欄位

        /// <summary>
        /// 公司名稱
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 公司總機
        /// </summary>
        public string? Tel { get; set; }
        /// <summary>
        /// 公司地址
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        /// 聯絡事項
        /// </summary>
        public string? Contect { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}

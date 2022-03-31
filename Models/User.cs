using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    public partial class User
    {   
        /// <summary>
        /// 帳號編號
        /// </summary>
        public string Id { get; set; } = null!;
        /// <summary>
        /// 使用者帳號名稱
        /// </summary>
        public string? UserId { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// MiddleName
        /// </summary>
        public string? MiddleName { get; set; }
        /// <summary>
        /// LastName
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// 手機號碼
        /// </summary>
        public string? Mobile { get; set; }
        /// <summary>
        /// Pwd
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// 使用者密碼
        /// </summary>
        public string? HashSaltedPwd { get; set; }
        /// <summary>
        /// 管理權限
        /// </summary>
        public string? Admin { get; set; }
        /// <summary>
        /// Vender
        /// </summary>
        public string? Vender { get; set; }
        /// <summary>
        /// 帳號層級
        /// </summary>
        public string? Role { get; set; }
        /// <summary>
        /// 註冊時間戳
        /// </summary>
        public DateTime? RegisteredDate { get; set; }
        /// <summary>
        /// 最後登入時間戳
        /// </summary>
        public DateTime? LastLogin { get; set; }
        /// <summary>
        /// Infro
        /// </summary>
        public string? Intro { get; set; }
        /// <summary>
        /// Profile
        /// </summary>
        public string? Profile { get; set; }        
    }
}

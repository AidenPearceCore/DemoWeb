using Microsoft.AspNetCore.Mvc;
using DemoWeb.Models;
using DemoWeb.DTOs;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        #region 注入(資料庫,log)
        private readonly DemoDatabaseContext _demoDatabaseContext;
        private readonly ILogger<WeatherForecastController> _logger;
        public LoginController(DemoDatabaseContext demoDatabaseContext, ILogger<WeatherForecastController> logger)
        {
            _demoDatabaseContext = demoDatabaseContext;
            _logger = logger;
        }
        #endregion

        /// <summary>
        /// 使用者登入
        /// </summary>
        /// <param name="value">帳號密碼</param>
        [HttpPost]
        public string Login(LoginDto value)
        {
            //TODO: HashSalted pwd
            //TODO: Storing logs in DB or json
            var user = (from a in _demoDatabaseContext.Users
                        where a.UserId == value.UserId
                        && a.Password == value.Password
                        select a).SingleOrDefault();
            if (user is null)
            {
                _logger.LogInformation($"{value.UserId}於{DateTime.UtcNow.ToLongTimeString()}嘗試登入失敗");
                return "帳號密碼錯誤";                
            }
            var claim = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserId),
                new Claim("FullName", user.UserId)
            };
            var claimsIdentity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));            
            _logger.LogInformation($"{user.UserId}於{DateTime.UtcNow.ToLongTimeString()}登入成功");

            return "登入成功";
        }

        /// <summary>
        /// 使用者登出
        /// </summary>
        [HttpDelete]
        public string Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return "登出成功";
        }
    }
}

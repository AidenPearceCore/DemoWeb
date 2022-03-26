using AutoMapper;
using DemoWeb.Models;
using DemoWeb.DTOs;

namespace DemoWeb.Profiles
{
    public class ListProfile : Profile
    {
        public ListProfile()
        {
            //第三方套件 僅小工具或練習用
            //重要核心功能請用.NET官方套件 危險行為請勿模仿
            CreateMap<House, ListSelectDto>();
        }

    }
}

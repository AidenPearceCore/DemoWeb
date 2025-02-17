﻿using DemoWeb.Data;
using DemoWeb.Entities;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.ValidationAttributes
{
    public class ListSelectId : ValidationAttribute
    {
        /// <summary>
        /// 驗證Id是否存在
        /// </summary>        
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DemoDatabaseContext _demoDatabaseContext = (DemoDatabaseContext)validationContext.GetService(typeof(DemoDatabaseContext));
            var findId = from a in _demoDatabaseContext.Houses
                         where a.Id == (int?)value
                         select a;
            return (findId.FirstOrDefault() is null) ? new ValidationResult("物件不存在") : ValidationResult.Success;
        }
    }
}
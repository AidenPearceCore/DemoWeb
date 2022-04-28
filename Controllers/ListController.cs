﻿using Microsoft.AspNetCore.Mvc;
using DemoWeb.Entities;
using DemoWeb.DTOs;
using DemoWeb.Parameters;
using DemoWeb.Data;
using DemoWeb.Repositories;

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        #region 注入(資料庫,Service)
        //private readonly DemoDatabaseContext _demoDatabaseContext;
        private readonly ListRepository _listService;

        public ListController(/*DemoDatabaseContext demoDatabaseContext,*/ ListRepository listService)
        {
            //_demoDatabaseContext = demoDatabaseContext;
            _listService = listService;
        }
        #endregion

        #region #region 使用Restful風格實作WebApi
        /// <summary>
        /// GET: api/ListController
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _listService.GetAllHouses();
            //這行是DTO版的Model
            //var result = _listService.GetAllHousesByDTO(_demoDatabaseContext);

            if(result is null || result.Count() == 0)
            {
                return NotFound("404 Not Found");
            }

            return Ok(result);
        }

        /// <summary>
        /// GET api/ListController/id
        /// </summary>
        /// <param name="value">預查詢的欄位id值</param>
        [HttpGet("{id}")]
        public ListSelectDto Get([FromRoute] ListSelectParameter value)
        {
            var result = _listService.GetHouseById(value.id);

            if (result is null)
            {
                Response.StatusCode = 404;
            }

            return result;
        }

        /// <summary>
        /// POST api/ListController
        /// </summary>
        /// <param name="value">預新增的Model欄位</param>
        [HttpPost]
        public async Task Post([FromBody] House value)
        {
            await _listService.InsertHouse(value);
        }

        /// <summary>
        /// PUT api/ListController/id
        /// </summary>
        /// <param name="id">預更新的欄位id值</param>
        /// <param name="value">預更新的Model資料</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] House value)
        {
            _listService.UpdateHouseById(id, value);
        }

        /// <summary>
        /// DELETE api/ListController/id
        /// </summary>
        /// <param name="value">預刪除的欄位id值</param>
        [HttpDelete("{id}")]
        public void Delete([FromRoute] ListSelectParameter value)
        {
            _listService.DeleteHouseById(value.id);
        }
        #endregion
    }
}

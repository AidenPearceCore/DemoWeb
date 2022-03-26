using Microsoft.AspNetCore.Mvc;
using DemoWeb.Services;
using DemoWeb.Models;
using DemoWeb.DTOs;
using DemoWeb.Parameters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        #region 使用DI依賴注入(資料庫,Service)
        private readonly DemoDatabaseContext _demoDatabaseContext;
        private readonly ListService _listService;

        public ListController(DemoDatabaseContext demoDatabaseContext, ListService listService)
        {
            _demoDatabaseContext = demoDatabaseContext;
            _listService = listService;
        }
        #endregion

        #region 使用Restful風格實作WebApi
        // GET: api/<ListController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _listService.GetAllHouses(_demoDatabaseContext);
            //這行是DTO版的Model
            //var result = _listService.GetAllHousesByDTO(_demoDatabaseContext);

            if(result == null || result.Count() == 0)
            {
                return NotFound("404 Not Found");
            }

            return Ok(result);
        }

        // GET api/<ListController>/id
        [HttpGet("{id}")]
        public ListSelectDto Get([FromRoute] ListSelectParameter value)
        {
            var result = _listService.GetHouseById(_demoDatabaseContext, value.id);

            if (result == null)
            {
                Response.StatusCode = 404;
            }

            return result;
        }

        // POST api/<ListController>
        [HttpPost]
        public void Post([FromBody] House value)
        {
            _listService.InsertHouse(_demoDatabaseContext, value);
        }

        // PUT api/<ListController>/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] House value)
        {
            _listService.UpdateHouseById(_demoDatabaseContext, id, value);
        }

        // DELETE api/<ListController>/id
        [HttpDelete("{id}")]
        public void Delete([FromRoute] ListSelectParameter value)
        {
            _listService.DeleteHouseById(_demoDatabaseContext, value.id);
        }
        #endregion
    }
}

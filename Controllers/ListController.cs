using Microsoft.AspNetCore.Mvc;
using DemoWeb.Services;
using DemoWeb.Models;
using DemoWeb.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        #region 使用DI依賴注入反向控制資料庫
        private readonly DemoDatabaseContext _demoDatabaseContext;
        public ListController(DemoDatabaseContext demoDatabaseContext)
        {
            _demoDatabaseContext = demoDatabaseContext;
        }
        #endregion

        //TODO: 與Service高耦合 待改成DI注入
        ListService listService = new ListService();

        #region 使用Restful風格實作WebApi
        // GET: api/<ListController>
        [HttpGet]
        public IEnumerable<ListSelectDto> Get(String? estatename,String? city, String? type)
        {
            var result = listService.GetAllHouses(_demoDatabaseContext, estatename, city, type);

            return result;
        }

        // GET api/<ListController>/id
        [HttpGet("{id}")]
        public ListSelectDto Get(int id)
        {
            var result = listService.GetHouseById(_demoDatabaseContext, id);

            return result;
        }

        // POST api/<ListController>
        [HttpPost]
        public void Post([FromBody] House value)
        {
            listService.InsertHouse(_demoDatabaseContext, value);
        }

        // PUT api/<ListController>/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] House value)
        {
            listService.UpdateHouseById(_demoDatabaseContext, id, value);
        }

        // DELETE api/<ListController>/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listService.DeleteHouseById(_demoDatabaseContext, id);
        }
        #endregion
    }
}

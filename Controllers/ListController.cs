using Microsoft.AspNetCore.Mvc;
using DemoWeb.Entities;
using DemoWeb.DTOs;
using DemoWeb.Parameters;
using DemoWeb.Repositories;

namespace DemoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly ListRepository _listRepository;

        public ListController(ListRepository listRepository)
        {
            _listRepository = listRepository;
        }

        #region #region 使用Restful風格實作WebApi
        /// <summary>
        /// GET: api/ListController
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _listRepository.GetAllHouses();
                //這行是DTO版的Model
                //var result = _listService.GetAllHousesByDTO(_demoDatabaseContext);

                if(result is null || result.Count() == 0)
                {
                    return NotFound("404 Not Found");
                }

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Status 500");
            }

        }

        /// <summary>
        /// GET api/ListController/id
        /// </summary>
        /// <param name="value">欲查詢的欄位id值</param>
        [HttpGet("{id}")]
        public ListSelectDto Get([FromRoute] ListSelectParameter value)
        {
            var result = _listRepository.GetHouseById(value.id);

            if (result is null)
            {
                Response.StatusCode = 404;
            }

            return result;
        }

        /// <summary>
        /// POST api/ListController
        /// </summary>
        /// <param name="value">欲新增的Model欄位</param>
        [HttpPost]
        public async Task Post([FromBody] House value)
        {
            await _listRepository.InsertHouse(value);
        }

        /// <summary>
        /// PUT api/ListController/id
        /// </summary>
        /// <param name="id">欲更新的欄位id值</param>
        /// <param name="value">欲更新的Model資料</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] House value)
        {
            _listRepository.UpdateHouseById(id, value);
        }

        /// <summary>
        /// DELETE api/ListController/id
        /// </summary>
        /// <param name="value">欲刪除的欄位id值</param>
        [HttpDelete("{id}")]
        public void Delete([FromRoute] ListSelectParameter value)
        {
            _listRepository.DeleteHouseById(value.id);
        }
        #endregion
    }
}

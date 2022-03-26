using AutoMapper;
using DemoWeb.DTOs;
using DemoWeb.Models;

namespace DemoWeb.Services
{
    public class ListService
    {
        private readonly IMapper _iMapper;

        public ListService(IMapper imapper)
        {
            _iMapper = imapper;
        }

        #region 第二層Service層
        public IEnumerable<ListSelectDto> GetAllHousesByDTO(DemoDatabaseContext _demoDatabaseContext)
        {
            var result = _demoDatabaseContext.Houses
            .Select(a => new ListSelectDto
            {
                Estatename = a.Estatename,
                City = a.City,
                Type = a.Type,
                Numberofrooms = a.Numberofrooms,
                Price = a.Price
            });            

            return result;
        }

        public IEnumerable<House> GetAllHouses(DemoDatabaseContext _demoDatabaseContext)
        {
            var result = _demoDatabaseContext.Houses;
            //原本寫法
            //.Select(a => new House
            //{
            //    Id = a.Id,
            //    Estatename = a.Estatename,
            //    City = a.City,
            //    Type = a.Type,
            //    Floor = a.Floor,
            //    Numberofrooms = a.Numberofrooms,
            //    Price = a.Price
            //});
            //return result;

            //與AutoMapper寫法 比較
            return _iMapper.Map<IEnumerable<House>>(result);
        }


        public ListSelectDto GetHouseById(DemoDatabaseContext _demoDatabaseContext, int id)
        {
            var result = _demoDatabaseContext.Houses
                .Where(a => a.Id == id)
                .Select(a => new ListSelectDto
                {
                    Estatename = a.Estatename,
                    City = a.City,
                    Type = a.Type,
                    Numberofrooms = a.Numberofrooms,
                    Price = a.Price
                }).SingleOrDefault();

            return result;
        }

        public void InsertHouse(DemoDatabaseContext _demoDatabaseContext, House value)
        {
            House insert = new()
            {
                Id = value.Id,
                Estatename = value.Estatename,
                City = value.City,
                Type = value.Type,
                Floor = value.Floor,
                Numberofrooms = value.Numberofrooms,
                Price = value.Price
            };
            _demoDatabaseContext.Houses.Add(insert);
            _demoDatabaseContext.SaveChanges();
        }

        public void UpdateHouseById(DemoDatabaseContext _demoDatabaseContext, int id, House value)
        {
            var update = (from a in _demoDatabaseContext.Houses
                          where a.Id == id
                          select a).SingleOrDefault();

            if (update != null)
            {
                update.Estatename = value.Estatename;
                update.City = value.City;
                update.Numberofrooms = value.Numberofrooms;
                update.Price = value.Price;
                update.Type = value.Type;
                _demoDatabaseContext.SaveChanges();
            }

        }

        public void DeleteHouseById(DemoDatabaseContext _demoDatabaseContext, int id)
        {
            var delete = (from a in _demoDatabaseContext.Houses
                          where a.Id == id
                          select a).SingleOrDefault();

            if (delete != null)
            {
                _demoDatabaseContext.Houses.Remove(delete);
                _demoDatabaseContext.SaveChanges();
            }
        }
        
        //private static IQueryable<ListSelectDto> SearchByQueryParameter(string? estatename, string? city, string? type, IQueryable<ListSelectDto> result)
        //{
        //    if (!string.IsNullOrWhiteSpace(estatename))
        //    {
        //        result = result.Where(a => a.Estatename.Contains(estatename));
        //    }
        //    if (!string.IsNullOrWhiteSpace(city))
        //    {
        //        result = result.Where(a => a.City.Contains(city));
        //    }
        //    if (!string.IsNullOrWhiteSpace(type))
        //    {
        //        result = result.Where(a => a.Type.Contains(type));
        //    }

        //    return result;
        //}
        #endregion

    }
}

//using AutoMapper;
using DemoWeb.Data;
using DemoWeb.DTOs;
using DemoWeb.Entities;

namespace DemoWeb.Repositories.Contracts
{
    public interface IListRepository
    {
        void DeleteHouseById(int id);
        IEnumerable<House> GetAllHouses();
        IEnumerable<ListSelectDto> GetAllHousesByDTO();
        ListSelectDto GetHouseById(int id);
        Task InsertHouse(House value);
        void UpdateHouseById(int id, House value);
    }
}
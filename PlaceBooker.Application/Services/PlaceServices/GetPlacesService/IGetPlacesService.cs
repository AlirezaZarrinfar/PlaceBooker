
using Dapper;
using PlaceBooker.Persistance.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.PlaceServices.GetPlacesService
{
    public interface IGetPlacesService
    {
        List<GetPlaceDto> GetPlaces(string searchKey , int page); 
    }
    public class GetPlacesService : IGetPlacesService
    {
        public List<GetPlaceDto> GetPlaces(string searchKey, int page)
        {
            try
            {
                var values = new
                {
                    searchkey = "%" + searchKey + "%",
                    num = page,
                };
                var data = Connection.sqlConnection.Query<GetPlaceDto>("GetPlaces", values, commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
    public class GetPlaceDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
        public long UserCreated { get; set; }
        public bool IsBooked { get; set; }
    }
}

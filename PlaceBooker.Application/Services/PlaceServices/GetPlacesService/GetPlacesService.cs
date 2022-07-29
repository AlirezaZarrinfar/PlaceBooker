
using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PlaceBooker.Application.Services.PlaceServices.GetPlacesService
{
    public class GetPlacesService : IGetPlacesService
    {
        public GetPlaceDto GetPlaceById(long id)
        {
            try
            {
                var data = Connection.sqlConnection.Query<GetPlaceDto>(PlaceCommands.GetPlaceById, new
                {
                    @id = id
                }).SingleOrDefault();
                return data;
            }
            catch
            {
                return null;
            }
        }

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
}

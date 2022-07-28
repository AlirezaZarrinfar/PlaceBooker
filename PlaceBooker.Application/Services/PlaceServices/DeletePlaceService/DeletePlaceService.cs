using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;

namespace PlaceBooker.Application.Services.PlaceServices.DeletePlaceService
{
    public class DeletePlaceService : IDeletePlaceService
    {
        public bool DeletePlace(long id)
        {
            try
            {
                Connection.sqlConnection.Query(PlaceCommands.DeletePlace, new
                {
                    @Id = id,
                });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

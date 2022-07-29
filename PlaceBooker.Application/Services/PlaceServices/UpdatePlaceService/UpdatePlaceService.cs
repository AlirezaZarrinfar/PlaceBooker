using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;

namespace PlaceBooker.Application.Services.PlaceServices.UpdatePlaceService
{
    public class UpdatePlaceService : IUpdatePlaceService
    {

        public bool UpdatePlace(UpdatePlaceDto model)
        {
            try
            {
                Connection.sqlConnection.Query<UpdatePlaceDto>(PlaceCommands.UpdatePlace, new
                {
                    Title = model.Title,
                    Address = model.Address,
                    Type = model.Type,
                    Location = model.Location,
                    DateCreated = model.DateCreated,
                    UserCreated = model.UserCreated,
                    @Id = model.Id
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

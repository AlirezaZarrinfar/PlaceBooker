using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System;

namespace PlaceBooker.Application.Services.PlaceServices.AddPlaceService
{
    public class AddPlaceService : IAddPlaceService
    {
        public bool AddPlace(AddPlaceDto model)
        {
            try
            {
                Connection.sqlConnection.Query<AddPlaceDto>(PlaceCommands.AddPlace, new
                {
                    Title = model.Title,
                    Address = model.Address,
                    Type = model.Type,
                    Location = model.Location,
                    DateCreated = DateTime.Now,
                    UserCreated = model.UserCreated
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

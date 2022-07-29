using Dapper;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System.Collections.Generic;
using System.Linq;

namespace PlaceBooker.Application.Services.BookServices.GetBooksService
{
    public class GetBooksService : IGetBooksService
    {
        public List<GetBooksDto> GetBooks(long placeId)
        {
            try
            {
                var data = Connection.sqlConnection.Query<GetBooksDto>(BookCommands.GetBook, new
                {
                    @id = placeId,
                }).ToList();
                return data;
            }
            catch
            {
                return null;
            }
        }
    }
}

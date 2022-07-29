using Dapper;
using PlaceBooker.Application.Services.BookServices.GetBooksService;
using PlaceBooker.Application.Services.PlaceServices.GetPlacesService;
using PlaceBooker.Common.Commands;
using PlaceBooker.Persistance.Connection;
using System;

namespace PlaceBooker.Application.Services.BookServices.AddBookService
{
    public class AddBookService : IAddBookService
    {
        private IGetBooksService _getBooksService;
        public AddBookService(IGetBooksService getBooksService)
        {
            _getBooksService = getBooksService;
        }

        private bool CheckIsBooked(DateTime bookDate, long placeId)
        {
            var books = _getBooksService.GetBooks(placeId);
            if (books.Count != 0)
            {
                foreach (var item in books)
                {
                    if (item.DateBooked.Date == bookDate.Date)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddBook(AddBookDto model)
        {
            try
            {
                if(CheckIsBooked(model.DateBooked,model.PlaceId))
                {
                    return false;
                }
                Connection.sqlConnection.Query(BookCommands.AddBook, new
                {
                    DateCreated = DateTime.Now,
                    DateBooked = model.DateBooked,
                    UserId = model.UserId,
                    PlaceId = model.PlaceId,
                    Price = model.Price,
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

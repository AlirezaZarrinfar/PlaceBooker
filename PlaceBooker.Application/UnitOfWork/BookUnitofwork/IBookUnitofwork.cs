using PlaceBooker.Application.Services.BookServices.AddBookService;
using PlaceBooker.Application.Services.BookServices.GetBooksService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.UnitOfWork.BookUnitofwork
{
    public interface IBookUnitofwork
    {
        IGetBooksService getBooksService { get; }
        IAddBookService addBookService { get; }
    }
}

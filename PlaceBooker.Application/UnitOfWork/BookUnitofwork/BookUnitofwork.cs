using PlaceBooker.Application.Services.BookServices.AddBookService;
using PlaceBooker.Application.Services.BookServices.GetBooksService;

namespace PlaceBooker.Application.UnitOfWork.BookUnitofwork
{
    public class BookUnitofwork : IBookUnitofwork
    {
        public IAddBookService _addBookService;
        public IAddBookService addBookService
        {
            get
            {
                if (_addBookService == null)
                {
                    _addBookService = new AddBookService(getBooksService);
                }
                return _addBookService;
            }
        }


        public IGetBooksService _getBooksService;
        public IGetBooksService getBooksService
        {
            get
            {
                if (_getBooksService == null)
                {
                    _getBooksService = new GetBooksService();
                }
                return _getBooksService;
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.BookServices.AddBookService
{
    public interface IAddBookService
    {
        bool AddBook(AddBookDto model);
    }
}

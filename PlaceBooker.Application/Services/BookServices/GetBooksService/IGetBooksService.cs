using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.BookServices.GetBooksService
{
    public interface IGetBooksService
    {
        List<GetBooksDto> GetBooks(long placeId);
    }
}

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.PlaceServices.GetPlacesService
{
    public interface IGetPlacesService
    {
        List<GetPlaceDto> GetPlaces(string searchKey , int page);
        GetPlaceDto GetPlaceById(long id);
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.PlaceServices.AddPlaceService
{
    public interface IAddPlaceService
    {
        bool AddPlace(AddPlaceDto model);
    }
}

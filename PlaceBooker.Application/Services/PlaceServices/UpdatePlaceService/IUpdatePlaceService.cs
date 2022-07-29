using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.PlaceServices.UpdatePlaceService
{
    public interface IUpdatePlaceService
    {
        bool UpdatePlace(UpdatePlaceDto model);
    }
}

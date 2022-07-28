using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.Services.PlaceServices.DeletePlaceService
{
    public interface IDeletePlaceService
    {
        bool DeletePlace(long id);
    }
}

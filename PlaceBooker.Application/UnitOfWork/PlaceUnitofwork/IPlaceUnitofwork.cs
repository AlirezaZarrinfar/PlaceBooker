using PlaceBooker.Application.Services.PlaceServices.AddPlaceService;
using PlaceBooker.Application.Services.PlaceServices.DeletePlaceService;
using PlaceBooker.Application.Services.PlaceServices.GetPlacesService;
using PlaceBooker.Application.Services.PlaceServices.UpdatePlaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Application.UnitOfWork.PlaceUnitofwork
{
    public interface IPlaceUnitofwork
    {
        IAddPlaceService addPlaceService { get; }
        IDeletePlaceService deletePlaceService { get; }
        IUpdatePlaceService updatePlaceService { get; }
        IGetPlacesService getPlacesService { get; }
    }
}

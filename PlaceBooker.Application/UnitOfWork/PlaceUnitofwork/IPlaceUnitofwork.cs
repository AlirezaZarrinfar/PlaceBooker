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
    public class PlaceUnitofwork : IPlaceUnitofwork
    {
        private IAddPlaceService _addPlaceService;
        public IAddPlaceService addPlaceService
        {
            get
            {
                if (_addPlaceService == null)
                {
                    _addPlaceService = new AddPlaceService();
                }
                return _addPlaceService;
            }
        }

        public IDeletePlaceService _deletePlaceService;
        public IDeletePlaceService deletePlaceService
        {
            get
            {
                if (_deletePlaceService == null)
                {
                    _deletePlaceService = new DeletePlaceService();
                }
                return _deletePlaceService;
            }
        }

        public IUpdatePlaceService _updatePlaceService;
        public IUpdatePlaceService updatePlaceService
        {
            get
            {
                if (_updatePlaceService == null)
                {
                    _updatePlaceService = new UpdatePlaceService();
                }
                return _updatePlaceService;
            }
        }

        public IGetPlacesService _getPlacesService;
        public IGetPlacesService getPlacesService
        {
            get
            {
                if (_getPlacesService == null)
                {
                    _getPlacesService = new GetPlacesService();
                }
                return _getPlacesService;
            }
        }
    }
}

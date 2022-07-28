using PlaceBooker.Application.Services.PlaceServices.AddPlaceService;
using PlaceBooker.Application.Services.PlaceServices.DeletePlaceService;
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
    }
}

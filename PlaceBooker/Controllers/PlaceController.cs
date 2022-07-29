using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceBooker.Application.Services.PlaceServices.AddPlaceService;
using PlaceBooker.Application.Services.PlaceServices.UpdatePlaceService;
using PlaceBooker.Application.UnitOfWork.PlaceUnitofwork;
using PlaceBooker.Common.ViewModels.PlaceViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceBooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlaceController : ControllerBase
    {
        private IPlaceUnitofwork _placeUnitofwork;
        public PlaceController(IPlaceUnitofwork placeUnitofwork)
        {
            _placeUnitofwork = placeUnitofwork;
        }
        [HttpPost]
        public IActionResult AddPlace(AddPlaceVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var res = _placeUnitofwork.addPlaceService.AddPlace(new AddPlaceDto
            {
                Title = model.Title,
                Address = model.Address,
                Location = model.Location,
                Type = model.Type,
                UserCreated = Convert.ToInt64(User.Claims.ToList()[0].Value)
            });
            return Ok(res);
        }

        [HttpDelete]
        public IActionResult DeletePlace(long id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var res = _placeUnitofwork.deletePlaceService.DeletePlace(id);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult UpdatePlace(UpdatePlaceVM model)
        {
            if (!ModelState.IsValid || model.UserCreated == 0 || model.Id == 0)
            {
                return BadRequest();
            }
            var res = _placeUnitofwork.updatePlaceService.UpdatePlace(new UpdatePlaceDto
            {
                Id = model.Id,
                Title = model.Title,
                Address = model.Address,
                Type = model.Type,
                Location = model.Location,
                DateCreated = model.DateCreated,
                UserCreated = model.UserCreated,
            });
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetPlace(string? searchKey, int page)
        {
            var res = _placeUnitofwork.getPlacesService.GetPlaces(searchKey, page);
            if(res.Count == 0)
            {
                return Ok("Data not found !!");
            }
            return Ok(res);
        }
    }
}

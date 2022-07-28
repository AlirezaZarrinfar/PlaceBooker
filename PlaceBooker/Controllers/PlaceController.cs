using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceBooker.Application.Services.PlaceServices.AddPlaceService;
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
    }
}

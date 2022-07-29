using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceBooker.Application.Services.BookServices.AddBookService;
using PlaceBooker.Application.UnitOfWork.BookUnitofwork;
using PlaceBooker.Common.ViewModels.BookViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceBooker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private IBookUnitofwork _bookUnitofwork;
        public BookController(IBookUnitofwork bookUnitofwork)
        {
            _bookUnitofwork = bookUnitofwork;
        }
        [HttpPost]
        public IActionResult AddBook(AddBookVM model)
        {
            var res = _bookUnitofwork.addBookService.AddBook(new AddBookDto
            {
                DateBooked = model.DateBooked,
                PlaceId = model.PlaceId,
                UserId = Convert.ToInt64(User.Claims.ToList()[0].Value),
                Price = model.Price,
            });
            return Ok(res);
        }
    }
}

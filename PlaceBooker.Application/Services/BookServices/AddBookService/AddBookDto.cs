using System;

namespace PlaceBooker.Application.Services.BookServices.AddBookService
{
    public class AddBookDto
    {
        public DateTime DateBooked { get; set; }
        public long UserId { get; set; }
        public long PlaceId { get; set; }
        public double Price { get; set; }
    }
}

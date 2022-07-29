using System;

namespace PlaceBooker.Application.Services.PlaceServices.UpdatePlaceService
{
    public class UpdatePlaceDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
        public long UserCreated { get; set; }
    }
}

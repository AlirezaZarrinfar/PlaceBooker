namespace PlaceBooker.Application.Services.PlaceServices.AddPlaceService
{
    public class AddPlaceDto
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public long UserCreated { get; set; }
    }
}

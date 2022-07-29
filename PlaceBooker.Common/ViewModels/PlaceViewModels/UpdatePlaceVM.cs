using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Common.ViewModels.PlaceViewModels
{
    public class UpdatePlaceVM
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public long UserCreated { get; set; }
    }
}

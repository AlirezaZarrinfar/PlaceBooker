using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Common.ViewModels.BookViewModels
{
    public class AddBookVM
    {
        [Required]
        public DateTime DateBooked { get; set; }
        [Required]
        public long PlaceId { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

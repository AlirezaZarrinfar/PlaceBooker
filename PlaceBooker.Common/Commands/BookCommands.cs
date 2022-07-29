using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Common.Commands
{
    public class BookCommands
    {
        public static string AddBook = "Insert Into [Book] Values (@DateCreated , @DateBooked , @UserId , @PlaceId , @Price )";
        public static string GetBook = "Select [DateBooked] from [Book] where PlaceId = @id";

    }
}

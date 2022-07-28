using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Common.Commands
{
    public class Commands
    {
        public static string AddUser = "Insert Into [User] Values (@Username , @Password , @IsActive , @RegisterTime , @Role)";

        public static string GetUserByUsername = "Select * From [User] Where Username = @Username";
    }
}

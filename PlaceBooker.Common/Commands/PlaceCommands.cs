using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooker.Common.Commands
{
    public class PlaceCommands
    {
        public static string AddPlace = "Insert Into [Place] Values (@Title , @Address , @Type , @Location , @DateCreated , @UserCreated)";
        public static string DeletePlace = "Delete From [Place] Where Id = @Id";

    }
}

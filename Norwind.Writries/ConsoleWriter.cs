using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norwind.Writries
{
    internal class ConsoleWriter : IUserActionWriter
    {
    }

    public void Write(IUserActionWriter action)
    {
        Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",


            action.CreatedDateTime, action.User, action.Description);
    }
}

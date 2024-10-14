using NorthWind.Entities.ValueObjects;
using NorthWind.Entities.ValueObjects.Interfaces;

namespace Norwind.ConsoleAPP.Services
{
    internal class AppLoger(IUserActionWriter writer)
    {
        public void Writelog(string message)
        {
            UserAction Log = new UserAction("System", message);
            writer.Write(Log);
        }
    }
}

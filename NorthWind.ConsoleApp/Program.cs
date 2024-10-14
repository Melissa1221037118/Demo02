
using NorthWind.Entities.ValueObjects.Interfaces;

IUserActionWriter writer = default;


AppLoger logger = new AppLoger(writer);
logger.WriteLog("Application started");

using NorthWind.Entities.Interfaces;
using NorthWind.ConsoleApp.Services;

IUserActionWriter Writer = default;

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");
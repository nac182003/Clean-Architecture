using NorthWind.Entities.Interfaces;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

IUserActionWriter Writer = new ConsoleWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");
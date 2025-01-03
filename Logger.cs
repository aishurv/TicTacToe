using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace TicTacToe
{
    public static class Logger
    {
        public static void LogInitializer()
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }
        public static void LogClose()
        {
            Log.Information("Program is Closing !");
            Log.CloseAndFlush();
        }
    }

}

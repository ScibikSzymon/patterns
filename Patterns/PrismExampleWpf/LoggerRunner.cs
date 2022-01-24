using Infrastructure;
using Serilog;
using Serilog.Events;
using System.IO;

namespace PrismExampleWpf
{
    /// <summary>
    /// Configure and run SerilogLogger
    /// </summary>
    static class LoggerRunner
    {
        const int MaxFileSize20MB = 20_000_000;
        const int MaxFilesCount10 = 10;

        /// <summary>
        /// Run 4 loggers:
        /// 1. Console
        /// 2. Debug
        /// 3. Info
        /// 4. Error
        /// </summary>
        public static void Run()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(
                    _debugFilePath(),
                    LogEventLevel.Debug,
                    fileSizeLimitBytes: MaxFileSize20MB,
                    rollingInterval: RollingInterval.Minute,
                    retainedFileCountLimit: MaxFilesCount10
                    )
                .WriteTo.File(
                    _infoFilePath(),
                    LogEventLevel.Information,
                    fileSizeLimitBytes: MaxFileSize20MB,
                    rollingInterval: RollingInterval.Minute,
                    retainedFileCountLimit: MaxFilesCount10
                )
                .WriteTo.File(
                    _errorFilePath(),
                    LogEventLevel.Error,
                    fileSizeLimitBytes: MaxFileSize20MB,
                    rollingInterval: RollingInterval.Minute,
                    retainedFileCountLimit: MaxFilesCount10
                )
                .CreateLogger();

        }
        private static string _debugFilePath()
        {
            return Path.Combine(
                ApplicationPaths.ProgramDataPath,
                "Logs",
                "DebugLog",
                "log_debug-{Date}.txt"
                );
        }
        private static string _infoFilePath()
        {
            return Path.Combine(
                ApplicationPaths.ProgramDataPath,
                "Logs",
                "InfoLog",
                "log-info-{Date}.txt"
                );
        }
        private static string _errorFilePath()
        {
            return Path.Combine(
                ApplicationPaths.ProgramDataPath,
                "Logs",
                "ErrorLog",
                "log_error-{Date}.txt"
                );
        }
    }
}

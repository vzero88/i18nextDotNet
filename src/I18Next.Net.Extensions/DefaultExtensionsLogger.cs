using System;
using Microsoft.Extensions.Logging;
using ILogger = I18Next.Net.Plugins.ILogger;

namespace I18Next.Net.Extensions
{
    /// <summary>
    /// Logger implementation which forwards the logging method calls to a Microsoft.Extensions.Logging.ILogger.
    /// </summary>
    public class DefaultExtensionsLogger : ILogger
    {
        private readonly Microsoft.Extensions.Logging.ILogger _logger;

        /// <inheritdoc />
        public DefaultExtensionsLogger(Microsoft.Extensions.Logging.ILogger logger)
        {
            _logger = logger;
        }

        /// <inheritdoc />
        public void LogCritical(string message, params object[] args)
        {
            _logger.LogCritical(message, args);
        }

        /// <inheritdoc />
        public void LogCritical(Exception exception, string message, params object[] args)
        {
            _logger.LogCritical(exception, message, args);
        }

        /// <inheritdoc />
        public void LogDebug(string message, params object[] args)
        {
            _logger.LogDebug(message, args);
        }

        /// <inheritdoc />
        public void LogDebug(Exception exception, string message, params object[] args)
        {
            _logger.LogDebug(exception, message, args);
        }

        /// <inheritdoc />
        public void LogError(string message, params object[] args)
        {
            _logger.LogError(message, args);
        }

        /// <inheritdoc />
        public void LogError(Exception exception, string message, params object[] args)
        {
            _logger.LogError(exception, message, args);
        }

        /// <inheritdoc />
        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        /// <inheritdoc />
        public void LogInformation(Exception exception, string message, params object[] args)
        {
            _logger.LogInformation(exception, message, args);
        }

        /// <inheritdoc />
        public void LogTrace(string message, params object[] args)
        {
            _logger.LogTrace(message, args);
        }

        /// <inheritdoc />
        public void LogTrace(Exception exception, string message, params object[] args)
        {
            _logger.LogTrace(exception, message, args);
        }

        /// <inheritdoc />
        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }

        /// <inheritdoc />
        public void LogWarning(Exception exception, string message, params object[] args)
        {
            _logger.LogWarning(exception, message, args);
        }
    }
}

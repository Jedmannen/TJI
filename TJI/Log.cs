﻿using System;
using log4net;
using log4net.Core;

namespace TJI
{
    internal class Log
    {
        private readonly ILog _logger;

        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }

        private Log(ILog logger)
        {
            _logger = logger;
        }

        public static event Action<string> Logging; 

        public void Debug(string message)
        {
            if (_logger.IsDebugEnabled)
            {
                _logger.Debug(message);
                Logging?.Invoke(message);
            }
        }

        public void Debug(string message, Exception exception)
        {
            // TODO: Handle exception
            Debug(message);
        }

        public void DebugFormat(string format, params object[] args)
        {
            Debug(string.Format(format, args));
        }

        public void Info(string message)
        {
            if (_logger.IsInfoEnabled)
            {
                _logger.Info(message);
                Logging?.Invoke(message);
            }
        }

        public void Info(string message, Exception exception)
        {
            // TODO: Handle exception
            Info(message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            Info(string.Format(format, args));
        }

        public void Warn(string message)
        {
            if (_logger.IsWarnEnabled)
            {
                _logger.Warn(message);
                Logging?.Invoke(message);
            }
        }

        public void Warn(string message, Exception exception)
        {
            // TODO: Handle exception
            Warn(message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            Warn(string.Format(format, args));
        }

        public void Error(string message)
        {
            if (_logger.IsErrorEnabled)
            {
                _logger.Error(message);
                Logging?.Invoke(message);
            }
        }

        public void Error(string message, Exception exception)
        {
            // TODO: Handle exception
            Error(message);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            Error(string.Format(format, args));
        }
    }
}

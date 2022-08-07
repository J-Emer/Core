using System;


namespace Core
{
    public static class Debug
    {
        /// <summary>
        /// logs a message to the System.Console
        /// </summary>
        /// <param name="message">the message to display to the Console</param>
        public static void Log(string message) => Console.WriteLine(message);

        /// <summary>
        /// Logs a message to the System.Console
        /// </summary>
        /// <param name="sender">the calling object</param>
        /// <param name="message">the message to display to the Console</param>
        public static void Log(object sender, string message) => Console.WriteLine($"{sender.GetType().Name} : {message}");

        /// <summary>
        /// Logs a message to the System.Console
        /// </summary>
        /// <param name="sender">the calling object</param>
        /// <param name="message">calls the .ToString() on an object</param>
        public static void Log(object sender, object message) => Console.WriteLine($"{sender.GetType().Name} : {message}");

    }
}

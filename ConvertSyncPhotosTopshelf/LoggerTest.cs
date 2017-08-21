using System;

namespace ConvertSyncPhotosTopshelf
{
    /// <summary>
    /// !!! FOR TEST ONLY !!! This class is needed to log the operation of the service 
    /// </summary>
    public class LoggerTest : ILog
    {
        public bool NeedToLog { set { } }
        
        public void Log(string fileName, string typeAction)
        {
            Console.WriteLine(Logger.FormatMsg(fileName, typeAction));
        }
    }
}

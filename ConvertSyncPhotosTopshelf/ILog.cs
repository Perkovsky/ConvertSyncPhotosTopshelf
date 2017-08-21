
namespace ConvertSyncPhotosTopshelf
{
    /// <summary>
    /// This interface is required for DI
    /// </summary>
    public interface ILog
    {
        bool NeedToLog { set; }
        void Log(string fileName, string typeAction);
    }
}

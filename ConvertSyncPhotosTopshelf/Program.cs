using Topshelf;

namespace ConvertSyncPhotosTopshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<Watcher>(s =>
                {
                    s.ConstructUsing(name => new Watcher(new Logger()));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDisplayName("Convert and sync photos");
                x.SetServiceName("ConvertSyncPhotos");
                x.SetDescription("");
                x.StartAutomatically();
            });
        }
    }
}

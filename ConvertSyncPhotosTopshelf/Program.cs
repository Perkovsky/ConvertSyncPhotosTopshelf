using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    s.WhenStarted(tc =>
                    {
                        if (!tc.Start())
                        {
                            tc.Log(string.Format(@"{0}\settings.xml", GeneralMethods.GetCurrentDirectory()), "Not started! Specify settings.");
                        }
                        //tc.Start();
                    });
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

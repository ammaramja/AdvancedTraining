using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myService
{
    public partial class myService : ServiceBase
    {
        public myService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("MyLogSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyLogSource", "MyLog");

            eventLog1.Source = "MyLogSource";
            eventLog1.Log = "MyLog";

        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Ammar's File Service is ready to run!");

            //System.Timers.Timer myTimer = new System.Timers.Timer();

            //myTimer.Interval = 30000;
            //myTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MyTimer_Elapsed);
            //myTimer.Start();
        }

        //private void MyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    eventLog1.WriteEntry("Monitoring",EventLogEntryType.Information);
        //}

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Ammar's File Service has stopped!");
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("It has been changed!");
            eventLog1.WriteEntry(e.Name);
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            //eventLog1.WriteEntry("A new file in the original directory has been created!");

            string srcName = @"C:\Users\amjawala_am\Documents\Visual Studio 2015\Projects\myService\myService\bin\Debug\FolderToBeMonitored\"+e.Name;
            string destName = @"D:\BackupFolderForService\"+e.Name;
            eventLog1.WriteEntry(destName);

            File.Copy(srcName,destName);

            eventLog1.WriteEntry("File has been copied to: "+destName);


        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(e.Name+" has been deleted!");
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            

            string destName = @"D:\BackupFolderForService\" + e.Name;
            string srcName = @"C:\Users\amjawala_am\Documents\Visual Studio 2015\Projects\myService\myService\bin\Debug\FolderToBeMonitored\" + e.Name;

            File.Delete(@"D:\BackupFolderForService\"+e.OldName);
            File.Copy(srcName,destName);

            eventLog1.WriteEntry(e.OldName + " has been renamed to " + e.Name);
        }
    }
}

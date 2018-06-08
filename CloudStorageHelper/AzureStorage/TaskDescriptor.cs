using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzureStorage
{
    public enum peTaskType { DirectoryToBlob=0, FileToBlob=1}

    public class TaskDescriptor
    {
        public Task task { get; set; }
        public CancellationTokenSource cts { get; set; }
        public string taskParams { get; set; }
        public int autoretryNum { get; set; }
    }
}

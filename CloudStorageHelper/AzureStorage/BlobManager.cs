using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.DataMovement;
using System.Collections.Generic;

namespace AzureStorage
{
    public delegate void ErrorDelegate(Exception ex);
    public delegate void BytesTransferedDelegate(long bytesTransferred);
    public delegate void ExposeTaskCancelationDelegate(Task task, CancellationTokenSource cts);

    public class BlobManager
    {
        private string _accountName = string.Empty;
        private string _accountKey = string.Empty;
        private int _autoRecoveryAttempts = 0;
        private CloudStorageAccount _account = null;
        private List<TaskDescriptor> _cancellationList = new List<TaskDescriptor>();


        public event ErrorDelegate Error;
        public event BytesTransferedDelegate BytesTransferred;
        public event ExposeTaskCancelationDelegate ExposeTaskCancelation;

        private bool _stopFlag = false;

        public void Start()
        {

        }

        public void Stop()
        {
            _stopFlag = true;

            foreach (TaskDescriptor tc in _cancellationList)
            {
                tc.cts.Cancel();
            }
        }

        public BlobManager(string accountName, string accountKey, int autoRecoveryAttempts = 0)
        {
            try
            {
                _accountKey = accountKey;
                _accountName = accountName;
                _autoRecoveryAttempts = autoRecoveryAttempts;
                string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=" + accountName + ";AccountKey=" + accountKey;
                _account = CloudStorageAccount.Parse(storageConnectionString);
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

        }

    }
}

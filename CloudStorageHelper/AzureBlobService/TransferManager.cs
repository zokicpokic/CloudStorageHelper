using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureStorage;

namespace AzureBlobService
{
    public class TransferManager
    {
        private string _accName = string.Empty;
        private string _accKey = string.Empty;
        private string _rootDir = string.Empty;
        private int _autoRecoveryAttempts = 0;
        private BlobManager _blobManager;


        public TransferManager(string accName, string accKey, string rootDir, int autoRecoveryAttempts = 0)
        {
            _accName = accName ;
            _accKey = accKey ;
            _rootDir = rootDir ;
            _autoRecoveryAttempts = autoRecoveryAttempts;
            _blobManager = new BlobManager(_accName, _accKey, _autoRecoveryAttempts);
        }

        public void Start()
        {
            _blobManager.Start();
        }

        public void Stop()
        {
            _blobManager.Stop();
            _blobManager = null;
        }
    }
}
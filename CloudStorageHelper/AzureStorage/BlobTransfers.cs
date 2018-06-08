using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.DataMovement;

namespace AzureStorage
{
    public class BlobTransfers
    {
        private CloudStorageAccount _account = null;

        public event ErrorDelegate Error;
        public event BytesTransferedDelegate BytesTransferred;
        public event ExposeTaskCancelationDelegate ExposeTaskCancelation;

        private bool _stopFlag = false;

        public bool StopFlag
        {
            get
            {
                return _stopFlag;
            }
            set
            {
                _stopFlag = value;
            }
        }    
        public SingleTransferContext GetSingleTransferContext(TransferCheckpoint checkpoint)
        {
            SingleTransferContext context = new SingleTransferContext(checkpoint);

            context.ProgressHandler = new Progress<TransferStatus>((progress) =>
            {
                if (BytesTransferred != null)
                {
                    BytesTransferred(progress.BytesTransferred);
                }
            });

            return context;
        }

        public DirectoryTransferContext GetDirectoryTransferContext(TransferCheckpoint checkpoint)
        {
            DirectoryTransferContext context = new DirectoryTransferContext(checkpoint);

            context.ProgressHandler = new Progress<TransferStatus>((progress) =>
            {
                if (BytesTransferred != null)
                    BytesTransferred(progress.BytesTransferred);
            });

            return context;
        }

        private CloudBlockBlob GetBlob(string containerName, string blobName)
        {
            CloudBlobClient blobClient = _account.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExistsAsync().Wait();
            CloudBlockBlob blob = container.GetBlockBlobReference(blobName);
            return blob;
        }

        private CloudBlobDirectory GetBlobDirectory(string containerName)
        {
            CloudBlobClient blobClient = _account.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(containerName);
            container.CreateIfNotExistsAsync().Wait();

            CloudBlobDirectory blobDirectory = container.GetDirectoryReference("");

            return blobDirectory;
        }

        public async Task DownloadAzureBlobToLocalFile(string DestinationFullFilePath, string ContainerName, string BlobName)
        {
            CloudBlockBlob blob = GetBlob(ContainerName, BlobName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);

            Task task;

            try
            {
                task = TransferManager.DownloadAsync(blob, DestinationFullFilePath, null, context, cancellationSource.Token);  //(LocalSourceFilePath, blob, null, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                //autoretry
            }

        }

        public async Task DownloadAzureBlobDirectoryToLocalDirectory(string LocalSourceDirPath, string ContainerName, bool RecursiveDownload = true)
        {
            CloudBlobDirectory blobDirectory = GetBlobDirectory(ContainerName);
            TransferCheckpoint checkpoint = null;
            DirectoryTransferContext context = GetDirectoryTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);
            Task task;

            DownloadDirectoryOptions options = new DownloadDirectoryOptions()
            {
                Recursive = RecursiveDownload
            };

            try
            {
                task = TransferManager.DownloadDirectoryAsync(blobDirectory, LocalSourceDirPath, options, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                //autoretry
            }
        }

        public async Task TransferLocalFileToAzureBlob(string LocalSourceFilePath, string ContainerName, string BlobName)
        {

            CloudBlockBlob blob = GetBlob(ContainerName, BlobName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(1000000);

            Task task;

            try
            {
                task = TransferManager.UploadAsync(LocalSourceFilePath, blob, null, context, cancellationSource.Token);
                if (ExposeTaskCancelation != null)
                    ExposeTaskCancelation(task, cancellationSource);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                Thread.Sleep(3000);
                checkpoint = context.LastCheckpoint;
                context = GetSingleTransferContext(checkpoint);
                await TransferManager.UploadAsync(LocalSourceFilePath, blob, null, context);
            }
        }

        public async Task TransferLocalDirectoryToAzureBlobDirectory(string LocalSourceDirPath, string ContainerName)
        {
            CloudBlobDirectory blobDirectory = GetBlobDirectory(ContainerName);
            TransferCheckpoint checkpoint = null;
            DirectoryTransferContext context = GetDirectoryTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);

            Task task;

            UploadDirectoryOptions options = new UploadDirectoryOptions()
            {
                Recursive = true
            };

            try
            {
                task = TransferManager.UploadDirectoryAsync(LocalSourceDirPath, blobDirectory, options, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                Thread.Sleep(3000);
                checkpoint = context.LastCheckpoint;
                context = GetDirectoryTransferContext(checkpoint);
                await TransferManager.UploadDirectoryAsync(LocalSourceDirPath, blobDirectory, options, context);
            }
        }

        public async Task TransferUrlToAzureBlob(Uri BlobUrl, string ContainerName, string BlobName)
        {
            CloudBlockBlob blob = GetBlob(ContainerName, BlobName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);

            Task task;
            try
            {
                task = TransferManager.CopyAsync(BlobUrl, blob, true, null, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                //autoretry
            }

        }

        public async Task TransferAzureBlobToAzureBlob(string ContainerSourceName, string BlobSourceName, string ContainerDestinationName, string BlobDestinationName)
        {
            CloudBlockBlob sourceBlob = GetBlob(ContainerSourceName, BlobSourceName);
            CloudBlockBlob destinationBlob = GetBlob(ContainerDestinationName, BlobDestinationName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(100000000);

            Task task;
            try
            {
                task = TransferManager.CopyAsync(sourceBlob, destinationBlob, true, null, context, cancellationSource.Token);

                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                if (_stopFlag)
                    return;
                //autoretry        
            }
        }
    }
}

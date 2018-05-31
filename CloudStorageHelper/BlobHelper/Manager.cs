﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.DataMovement;

namespace BlobHelper
{
    public delegate void ErrorDelegate(Exception ex);
    public delegate void BytesTransferedDelegate(long bytesTransferred);
    public class Manager
    {
        private string _accountName = string.Empty;
        private string _accountKey = string.Empty;
        private CloudStorageAccount _account = null;

        public event ErrorDelegate Error;
        public event BytesTransferedDelegate BytesTransferred;

        public Manager(string accountName, string accountKey)
        {
            try
            {
                _accountKey = accountKey;
                _accountName = accountName;
                string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=" + accountName + ";AccountKey=" + accountKey;
                _account = CloudStorageAccount.Parse(storageConnectionString);
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
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

        public async Task TransferLocalFileToAzureBlob(string LocalSourceFilePath, string ContainerName, string BlobName)
        {

            CloudBlockBlob blob = GetBlob(ContainerName, BlobName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);

            Stopwatch stopWatch = Stopwatch.StartNew();
            Task task;

            try
            {
                task = TransferManager.UploadAsync(LocalSourceFilePath, blob, null, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex) { 
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {

                //autoretry
            }

            stopWatch.Stop();
        }

        public async Task TransferLocalDirectoryToAzureBlobDirectory(string LocalSourceFilePath, string ContainerName)
        {
            CloudBlobDirectory blobDirectory = GetBlobDirectory(ContainerName);
            TransferCheckpoint checkpoint = null;
            DirectoryTransferContext context = GetDirectoryTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);
            Stopwatch stopWatch = Stopwatch.StartNew();
            Task task;

            UploadDirectoryOptions options = new UploadDirectoryOptions()
            {
                Recursive = true
            };

            try
            {
                task = TransferManager.UploadDirectoryAsync(LocalSourceFilePath, blobDirectory, options, context, cancellationSource.Token);
                await task;
            }
            catch (Exception ex)
            {
                if (Error != null)
                    Error(ex);
            }

            if (cancellationSource.IsCancellationRequested)
            {
                //autoretry
            }

            stopWatch.Stop();
        }

        public async Task TransferUrlToAzureBlob(Uri BlobUrl, string ContainerName, string BlobName)
        {
            CloudBlockBlob blob = GetBlob(ContainerName, BlobName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(10000000);

            Stopwatch stopWatch = Stopwatch.StartNew();
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
                //autoretry
            }

            stopWatch.Stop();

        }

        public async Task TransferAzureBlobToAzureBlob(string ContainerSourceName, string BlobSourceName, string ContainerDestinationName, string BlobDestinationName)
        {
            CloudBlockBlob sourceBlob = GetBlob(ContainerSourceName, BlobSourceName);
            CloudBlockBlob destinationBlob = GetBlob(ContainerDestinationName, BlobDestinationName);
            TransferCheckpoint checkpoint = null;
            SingleTransferContext context = GetSingleTransferContext(checkpoint);
            CancellationTokenSource cancellationSource = new CancellationTokenSource(100000000);

            Stopwatch stopWatch = Stopwatch.StartNew();
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
                //autoretry        
            }

            stopWatch.Stop();
        }
    }
}

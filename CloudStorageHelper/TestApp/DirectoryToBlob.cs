﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlobHelper;

namespace TestApp
{
    public partial class DirectoryToBlob : Form
    {
        public DirectoryToBlob()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            var accName = ConfigurationManager.AppSettings.Get("accountName");
            var accKey = ConfigurationManager.AppSettings.Get("accountKey");
            Manager mng = new Manager(accName, accKey);
            mng.Error += Mng_Error;
            mng.BytesTransferred += Mng_BytesTransferred;
            await mng.TransferLocalDirectoryToAzureBlobDirectory(txtFB.Text, cmbBlobContainers.SelectedItem.ToString());
            this.Close();
        }

        private void Mng_BytesTransferred(long bytesTransferred)
        {
            lblTransfer.Text = "Transferred bytes: " + bytesTransferred;
        }

        private void Mng_Error(Exception ex)
        {
            MessageBox.Show(ex.Message);
            btnOK.Enabled = false;
        }

        private void DirectoryToBlob_Load(object sender, EventArgs e)
        {
            var containerNames = ConfigurationManager.AppSettings.Get("containerName");
            var cArr = containerNames.Split(',');
            for (int i = 0; i < cArr.Length; i++)
            {
                cmbBlobContainers.Items.Add(cArr[i]);
            }
            cmbBlobContainers.SelectedIndex = 0;
        }

        private void btnSearchFB_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFB.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

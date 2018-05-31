using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileToBlob_Click_1(object sender, EventArgs e)
        {
            var frm = new FileToBlob();
            frm.ShowDialog();
        }

        private void btnDirectoryToBlob_Click_1(object sender, EventArgs e)
        {
            var frm = new DirectoryToBlob();
            frm.ShowDialog();
        }

        private void btnBlobToFile_Click_1(object sender, EventArgs e)
        {
            var frm = new BlobToFile();
            frm.ShowDialog();
        }

        private void btnBlobDirToLocalDir_Click(object sender, EventArgs e)
        {
            var frm = new BlobDirToLocalDir();
            frm.ShowDialog();
        }
    }
}

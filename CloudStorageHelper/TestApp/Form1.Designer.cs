namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFileToBlob = new System.Windows.Forms.Button();
            this.btnBlobDirToLocalDir = new System.Windows.Forms.Button();
            this.btnDirectoryToBlob = new System.Windows.Forms.Button();
            this.btnBlobToFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFileToBlob);
            this.groupBox1.Controls.Add(this.btnBlobDirToLocalDir);
            this.groupBox1.Controls.Add(this.btnDirectoryToBlob);
            this.groupBox1.Controls.Add(this.btnBlobToFile);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BLOB Manipulation";
            // 
            // btnFileToBlob
            // 
            this.btnFileToBlob.Location = new System.Drawing.Point(17, 28);
            this.btnFileToBlob.Name = "btnFileToBlob";
            this.btnFileToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnFileToBlob.TabIndex = 8;
            this.btnFileToBlob.Text = "File to Blob";
            this.btnFileToBlob.UseVisualStyleBackColor = true;
            this.btnFileToBlob.Click += new System.EventHandler(this.btnFileToBlob_Click_1);
            // 
            // btnBlobDirToLocalDir
            // 
            this.btnBlobDirToLocalDir.Location = new System.Drawing.Point(154, 57);
            this.btnBlobDirToLocalDir.Name = "btnBlobDirToLocalDir";
            this.btnBlobDirToLocalDir.Size = new System.Drawing.Size(131, 23);
            this.btnBlobDirToLocalDir.TabIndex = 7;
            this.btnBlobDirToLocalDir.Text = "Blob Dir To Local Dir";
            this.btnBlobDirToLocalDir.UseVisualStyleBackColor = true;
            this.btnBlobDirToLocalDir.Click += new System.EventHandler(this.btnBlobDirToLocalDir_Click);
            // 
            // btnDirectoryToBlob
            // 
            this.btnDirectoryToBlob.Location = new System.Drawing.Point(154, 28);
            this.btnDirectoryToBlob.Name = "btnDirectoryToBlob";
            this.btnDirectoryToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnDirectoryToBlob.TabIndex = 6;
            this.btnDirectoryToBlob.Text = "Directory To Blob";
            this.btnDirectoryToBlob.UseVisualStyleBackColor = true;
            this.btnDirectoryToBlob.Click += new System.EventHandler(this.btnDirectoryToBlob_Click_1);
            // 
            // btnBlobToFile
            // 
            this.btnBlobToFile.Location = new System.Drawing.Point(17, 57);
            this.btnBlobToFile.Name = "btnBlobToFile";
            this.btnBlobToFile.Size = new System.Drawing.Size(131, 23);
            this.btnBlobToFile.TabIndex = 5;
            this.btnBlobToFile.Text = "Blob To File";
            this.btnBlobToFile.UseVisualStyleBackColor = true;
            this.btnBlobToFile.Click += new System.EventHandler(this.btnBlobToFile_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 407);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Storage Helper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFileToBlob;
        private System.Windows.Forms.Button btnBlobDirToLocalDir;
        private System.Windows.Forms.Button btnDirectoryToBlob;
        private System.Windows.Forms.Button btnBlobToFile;
    }
}


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
            this.pnBlob = new System.Windows.Forms.Panel();
            this.btnFileToBlob = new System.Windows.Forms.Button();
            this.btnBlobToFile = new System.Windows.Forms.Button();
            this.btnDirectoryToBlob = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBlob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBlob
            // 
            this.pnBlob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBlob.Controls.Add(this.button1);
            this.pnBlob.Controls.Add(this.btnDirectoryToBlob);
            this.pnBlob.Controls.Add(this.btnBlobToFile);
            this.pnBlob.Controls.Add(this.btnFileToBlob);
            this.pnBlob.Location = new System.Drawing.Point(39, 53);
            this.pnBlob.Name = "pnBlob";
            this.pnBlob.Size = new System.Drawing.Size(624, 70);
            this.pnBlob.TabIndex = 0;
            // 
            // btnFileToBlob
            // 
            this.btnFileToBlob.Location = new System.Drawing.Point(21, 27);
            this.btnFileToBlob.Name = "btnFileToBlob";
            this.btnFileToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnFileToBlob.TabIndex = 0;
            this.btnFileToBlob.Text = "File to Blob";
            this.btnFileToBlob.UseVisualStyleBackColor = true;
            this.btnFileToBlob.Click += new System.EventHandler(this.btnFileToBlob_Click);
            // 
            // btnBlobToFile
            // 
            this.btnBlobToFile.Location = new System.Drawing.Point(317, 26);
            this.btnBlobToFile.Name = "btnBlobToFile";
            this.btnBlobToFile.Size = new System.Drawing.Size(131, 23);
            this.btnBlobToFile.TabIndex = 1;
            this.btnBlobToFile.Text = "Blob To File";
            this.btnBlobToFile.UseVisualStyleBackColor = true;
            this.btnBlobToFile.Click += new System.EventHandler(this.btnBlobToFile_Click);
            // 
            // btnDirectoryToBlob
            // 
            this.btnDirectoryToBlob.Location = new System.Drawing.Point(169, 26);
            this.btnDirectoryToBlob.Name = "btnDirectoryToBlob";
            this.btnDirectoryToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnDirectoryToBlob.TabIndex = 2;
            this.btnDirectoryToBlob.Text = "Directory To Blob";
            this.btnDirectoryToBlob.UseVisualStyleBackColor = true;
            this.btnDirectoryToBlob.Click += new System.EventHandler(this.btnDirectoryToBlob_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Blob Dir To Local Dir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BLOB manipulation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnBlob);
            this.Name = "Form1";
            this.Text = "Storage Helper";
            this.pnBlob.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBlob;
        private System.Windows.Forms.Button btnFileToBlob;
        private System.Windows.Forms.Button btnBlobToFile;
        private System.Windows.Forms.Button btnDirectoryToBlob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


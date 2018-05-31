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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDirectoryToBlob = new System.Windows.Forms.Button();
            this.btnBlobToFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFileToBlob);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDirectoryToBlob);
            this.groupBox1.Controls.Add(this.btnBlobToFile);
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BLOB Manipulation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFileToBlob
            // 
            this.btnFileToBlob.Location = new System.Drawing.Point(17, 28);
            this.btnFileToBlob.Name = "btnFileToBlob";
            this.btnFileToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnFileToBlob.TabIndex = 8;
            this.btnFileToBlob.Text = "File to Blob";
            this.btnFileToBlob.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Blob Dir To Local Dir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDirectoryToBlob
            // 
            this.btnDirectoryToBlob.Location = new System.Drawing.Point(154, 28);
            this.btnDirectoryToBlob.Name = "btnDirectoryToBlob";
            this.btnDirectoryToBlob.Size = new System.Drawing.Size(131, 23);
            this.btnDirectoryToBlob.TabIndex = 6;
            this.btnDirectoryToBlob.Text = "Directory To Blob";
            this.btnDirectoryToBlob.UseVisualStyleBackColor = true;
            // 
            // btnBlobToFile
            // 
            this.btnBlobToFile.Location = new System.Drawing.Point(17, 57);
            this.btnBlobToFile.Name = "btnBlobToFile";
            this.btnBlobToFile.Size = new System.Drawing.Size(131, 23);
            this.btnBlobToFile.TabIndex = 5;
            this.btnBlobToFile.Text = "Blob To File";
            this.btnBlobToFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Storage Helper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFileToBlob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDirectoryToBlob;
        private System.Windows.Forms.Button btnBlobToFile;
    }
}


namespace TestApp
{
    partial class BlobToFile
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbBlobContainers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchFB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(412, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Download";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbBlobContainers
            // 
            this.cmbBlobContainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlobContainers.FormattingEnabled = true;
            this.cmbBlobContainers.Location = new System.Drawing.Point(178, 117);
            this.cmbBlobContainers.Name = "cmbBlobContainers";
            this.cmbBlobContainers.Size = new System.Drawing.Size(267, 21);
            this.cmbBlobContainers.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "blob container name";
            // 
            // btnSearchFB
            // 
            this.btnSearchFB.Location = new System.Drawing.Point(451, 77);
            this.btnSearchFB.Name = "btnSearchFB";
            this.btnSearchFB.Size = new System.Drawing.Size(36, 23);
            this.btnSearchFB.TabIndex = 11;
            this.btnSearchFB.Text = "...";
            this.btnSearchFB.UseVisualStyleBackColor = true;
            this.btnSearchFB.Click += new System.EventHandler(this.btnSearchFB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "download to file";
            // 
            // txtFB
            // 
            this.txtFB.Location = new System.Drawing.Point(178, 79);
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(267, 20);
            this.txtFB.TabIndex = 9;
            // 
            // txtBlobName
            // 
            this.txtBlobName.Location = new System.Drawing.Point(178, 43);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(267, 20);
            this.txtBlobName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "name of the blob in azure";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(178, 153);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(0, 13);
            this.lblTransfer.TabIndex = 20;
            // 
            // BlobToFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 275);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.txtBlobName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbBlobContainers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchFB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlobToFile";
            this.Text = "BlobToFile";
            this.Load += new System.EventHandler(this.BlobToFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbBlobContainers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblTransfer;
    }
}
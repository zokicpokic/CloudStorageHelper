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
            this.pnBlob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBlob
            // 
            this.pnBlob.Controls.Add(this.btnFileToBlob);
            this.pnBlob.Location = new System.Drawing.Point(39, 53);
            this.pnBlob.Name = "pnBlob";
            this.pnBlob.Size = new System.Drawing.Size(684, 160);
            this.pnBlob.TabIndex = 0;
            // 
            // btnFileToBlob
            // 
            this.btnFileToBlob.Location = new System.Drawing.Point(21, 28);
            this.btnFileToBlob.Name = "btnFileToBlob";
            this.btnFileToBlob.Size = new System.Drawing.Size(211, 23);
            this.btnFileToBlob.TabIndex = 0;
            this.btnFileToBlob.Text = "File to Blob";
            this.btnFileToBlob.UseVisualStyleBackColor = true;
            this.btnFileToBlob.Click += new System.EventHandler(this.btnFileToBlob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnBlob);
            this.Name = "Form1";
            this.Text = "Storage Helper";
            this.pnBlob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBlob;
        private System.Windows.Forms.Button btnFileToBlob;
    }
}


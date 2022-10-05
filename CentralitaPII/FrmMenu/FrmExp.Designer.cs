namespace FrmMenu
{
    partial class FrmExp
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
            this.rtbExceptionDescription = new System.Windows.Forms.RichTextBox();
            this.lblRealDateException = new System.Windows.Forms.Label();
            this.btnExceptionOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbExceptionDescription
            // 
            this.rtbExceptionDescription.Location = new System.Drawing.Point(46, 39);
            this.rtbExceptionDescription.Name = "rtbExceptionDescription";
            this.rtbExceptionDescription.Size = new System.Drawing.Size(417, 158);
            this.rtbExceptionDescription.TabIndex = 0;
            this.rtbExceptionDescription.Text = "";
            // 
            // lblRealDateException
            // 
            this.lblRealDateException.AutoSize = true;
            this.lblRealDateException.Location = new System.Drawing.Point(46, 234);
            this.lblRealDateException.Name = "lblRealDateException";
            this.lblRealDateException.Size = new System.Drawing.Size(38, 15);
            this.lblRealDateException.TabIndex = 1;
            this.lblRealDateException.Text = "label1";
            // 
            // btnExceptionOK
            // 
            this.btnExceptionOK.Location = new System.Drawing.Point(176, 233);
            this.btnExceptionOK.Name = "btnExceptionOK";
            this.btnExceptionOK.Size = new System.Drawing.Size(124, 23);
            this.btnExceptionOK.TabIndex = 2;
            this.btnExceptionOK.Text = "OK";
            this.btnExceptionOK.UseVisualStyleBackColor = true;
            this.btnExceptionOK.Click += new System.EventHandler(this.btnExceptionOK_Click);
            // 
            // FrmExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnExceptionOK);
            this.Controls.Add(this.lblRealDateException);
            this.Controls.Add(this.rtbExceptionDescription);
            this.Name = "FrmExp";
            this.Text = "FrmExp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbExceptionDescription;
        private System.Windows.Forms.Label lblRealDateException;
        private System.Windows.Forms.Button btnExceptionOK;
    }
}
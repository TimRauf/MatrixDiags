namespace MatrixDiags
{
    partial class MainForm
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
            this.tbTBoxMx = new System.Windows.Forms.TextBox();
            this.btnCreateMx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTBoxMx
            // 
            this.tbTBoxMx.Location = new System.Drawing.Point(121, 47);
            this.tbTBoxMx.Multiline = true;
            this.tbTBoxMx.Name = "tbTBoxMx";
            this.tbTBoxMx.Size = new System.Drawing.Size(239, 155);
            this.tbTBoxMx.TabIndex = 0;
            // 
            // btnCreateMx
            // 
            this.btnCreateMx.Location = new System.Drawing.Point(176, 247);
            this.btnCreateMx.Name = "btnCreateMx";
            this.btnCreateMx.Size = new System.Drawing.Size(144, 56);
            this.btnCreateMx.TabIndex = 1;
            this.btnCreateMx.UseVisualStyleBackColor = true;
            this.btnCreateMx.Click += new System.EventHandler(this.btnCreateMx_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.btnCreateMx);
            this.Controls.Add(this.tbTBoxMx);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTBoxMx;
        private System.Windows.Forms.Button btnCreateMx;
    }
}


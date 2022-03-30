namespace NotePad_OOP_Project_2019
{
    partial class frmAbout
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
            this.lblproductname = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.lblproductversion = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(37, 27);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(46, 17);
            this.lblproductname.TabIndex = 0;
            this.lblproductname.Text = "label1";
            this.lblproductname.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(157, 170);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 52);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblproductversion
            // 
            this.lblproductversion.AutoSize = true;
            this.lblproductversion.Location = new System.Drawing.Point(37, 76);
            this.lblproductversion.Name = "lblproductversion";
            this.lblproductversion.Size = new System.Drawing.Size(46, 17);
            this.lblproductversion.TabIndex = 2;
            this.lblproductversion.Text = "label2";
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Location = new System.Drawing.Point(37, 125);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(46, 17);
            this.lblcopyright.TabIndex = 3;
            this.lblcopyright.Text = "label3";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 234);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.lblproductversion);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblproductname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblproductversion;
        private System.Windows.Forms.Label lblcopyright;
    }
}
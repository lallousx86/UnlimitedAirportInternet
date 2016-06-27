namespace lallouslab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.lblSite = new System.Windows.Forms.LinkLabel();
            this.lblBatchography = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrLastRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnFreeInternet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Powered by: ";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(76, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(205, 23);
            this.lblTimer.TabIndex = 18;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(12, 163);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(27, 13);
            this.lblHelp.TabIndex = 17;
            this.lblHelp.TabStop = true;
            this.lblHelp.Text = "help";
            this.lblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblHelp_LinkClicked);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(276, 163);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(68, 13);
            this.lblSite.TabIndex = 16;
            this.lblSite.TabStop = true;
            this.lblSite.Text = "lallouslab.net";
            this.lblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSite_LinkClicked);
            // 
            // lblBatchography
            // 
            this.lblBatchography.AutoSize = true;
            this.lblBatchography.Location = new System.Drawing.Point(183, 183);
            this.lblBatchography.Name = "lblBatchography";
            this.lblBatchography.Size = new System.Drawing.Size(161, 13);
            this.lblBatchography.TabIndex = 15;
            this.lblBatchography.TabStop = true;
            this.lblBatchography.Text = "ChangeMACAddressBatch script";
            this.lblBatchography.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBatchography_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time since last free internet renew request:";
            // 
            // tmrLastRefresh
            // 
            this.tmrLastRefresh.Interval = 1000;
            this.tmrLastRefresh.Tick += new System.EventHandler(this.tmrLastRefresh_Tick);
            // 
            // btnFreeInternet
            // 
            this.btnFreeInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeInternet.Image = global::lallouslab.Properties.Resources.Refresh_64;
            this.btnFreeInternet.Location = new System.Drawing.Point(80, 61);
            this.btnFreeInternet.Name = "btnFreeInternet";
            this.btnFreeInternet.Size = new System.Drawing.Size(201, 89);
            this.btnFreeInternet.TabIndex = 13;
            this.btnFreeInternet.Text = "Give me more free internet";
            this.btnFreeInternet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFreeInternet.UseVisualStyleBackColor = true;
            this.btnFreeInternet.Click += new System.EventHandler(this.btnFreeInternet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblBatchography);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFreeInternet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlimited Internet at Airports - lallouslab.net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel lblHelp;
        private System.Windows.Forms.LinkLabel lblSite;
        private System.Windows.Forms.LinkLabel lblBatchography;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFreeInternet;
        private System.Windows.Forms.Timer tmrLastRefresh;
    }
}


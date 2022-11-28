namespace YoutubeDownloader
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.panelEntete = new System.Windows.Forms.Panel();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.panelCorps = new System.Windows.Forms.Panel();
            this.btnTelecharger = new System.Windows.Forms.Button();
            this.lblPourc = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.panelCorps.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEntete.Controls.Add(this.pictLogo);
            this.panelEntete.Controls.Add(this.lblTitre);
            this.panelEntete.Controls.Add(this.lblMin);
            this.panelEntete.Controls.Add(this.lblQuitter);
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Margin = new System.Windows.Forms.Padding(4);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(459, 32);
            this.panelEntete.TabIndex = 0;
            // 
            // pictLogo
            // 
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(15, 2);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(32, 29);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictLogo.TabIndex = 9;
            this.pictLogo.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(154, 10);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 16);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Youtube Downloader";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(391, 2);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(22, 28);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "-";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(423, 2);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(20, 24);
            this.lblQuitter.TabIndex = 1;
            this.lblQuitter.Text = "x";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // panelCorps
            // 
            this.panelCorps.BackColor = System.Drawing.SystemColors.Control;
            this.panelCorps.Controls.Add(this.btnTelecharger);
            this.panelCorps.Controls.Add(this.lblPourc);
            this.panelCorps.Controls.Add(this.progressBar);
            this.panelCorps.Controls.Add(this.cboResolution);
            this.panelCorps.Controls.Add(this.lblResolution);
            this.panelCorps.Controls.Add(this.lblUrl);
            this.panelCorps.Controls.Add(this.txtUrl);
            this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorps.Location = new System.Drawing.Point(0, 32);
            this.panelCorps.Margin = new System.Windows.Forms.Padding(4);
            this.panelCorps.Name = "panelCorps";
            this.panelCorps.Size = new System.Drawing.Size(459, 210);
            this.panelCorps.TabIndex = 1;
            // 
            // btnTelecharger
            // 
            this.btnTelecharger.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelecharger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelecharger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnTelecharger.Location = new System.Drawing.Point(289, 131);
            this.btnTelecharger.Name = "btnTelecharger";
            this.btnTelecharger.Size = new System.Drawing.Size(95, 29);
            this.btnTelecharger.TabIndex = 2;
            this.btnTelecharger.Text = "&Télécharger";
            this.btnTelecharger.UseVisualStyleBackColor = false;
            this.btnTelecharger.Click += new System.EventHandler(this.btnTelecharger_Click);
            // 
            // lblPourc
            // 
            this.lblPourc.AutoSize = true;
            this.lblPourc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblPourc.Location = new System.Drawing.Point(390, 97);
            this.lblPourc.Name = "lblPourc";
            this.lblPourc.Size = new System.Drawing.Size(26, 16);
            this.lblPourc.TabIndex = 5;
            this.lblPourc.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(116, 92);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(268, 24);
            this.progressBar.TabIndex = 4;
            // 
            // cboResolution
            // 
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolution.Location = new System.Drawing.Point(116, 49);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(121, 25);
            this.cboResolution.TabIndex = 1;
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblResolution.Location = new System.Drawing.Point(17, 52);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(82, 16);
            this.lblResolution.TabIndex = 2;
            this.lblResolution.Text = "Résolution :";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblUrl.Location = new System.Drawing.Point(61, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(38, 16);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(116, 10);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(319, 23);
            this.txtUrl.TabIndex = 0;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelEntete;
            this.bunifuDragControl.Vertical = true;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 27;
            this.bunifuElipse.TargetControl = this;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 208);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(459, 34);
            this.panelFooter.TabIndex = 2;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 242);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelCorps);
            this.Controls.Add(this.panelEntete);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downlaoder";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.panelCorps.ResumeLayout(false);
            this.panelCorps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Panel panelCorps;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnTelecharger;
        private System.Windows.Forms.Label lblPourc;
        private System.Windows.Forms.Label lblQuitter;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Label lblTitre;
    }
}


namespace SpritePacker
{
    partial class frmMain
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.lviewFrames = new System.Windows.Forms.ListView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblRestart = new System.Windows.Forms.LinkLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPageGIF = new System.Windows.Forms.TabPage();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.lblRestartGif = new System.Windows.Forms.LinkLabel();
            this.webBrowserGif = new System.Windows.Forms.WebBrowser();
            this.cmbAlignGif = new System.Windows.Forms.ComboBox();
            this.lblHelpGif = new System.Windows.Forms.LinkLabel();
            this.btnConvertGif = new System.Windows.Forms.Button();
            this.lblGifLocation = new System.Windows.Forms.Label();
            this.btnOpenGif = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPageGIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(2, 5);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Select Frames";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "Select frames";
            this.openDialog.Filter = "Images|*.png;*.jpg";
            this.openDialog.Multiselect = true;
            // 
            // cmbAlign
            // 
            this.cmbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlign.Items.AddRange(new object[] {
            "Horizontal Line",
            "Vertical Line",
            "Rectangular Horizontal",
            "(N/A)Rectangualr Vertical"});
            this.cmbAlign.Location = new System.Drawing.Point(2, 93);
            this.cmbAlign.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlign.Name = "cmbAlign";
            this.cmbAlign.Size = new System.Drawing.Size(120, 21);
            this.cmbAlign.TabIndex = 1;
            // 
            // lviewFrames
            // 
            this.lviewFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lviewFrames.AutoArrange = false;
            this.lviewFrames.Location = new System.Drawing.Point(126, 5);
            this.lviewFrames.Margin = new System.Windows.Forms.Padding(2);
            this.lviewFrames.Name = "lviewFrames";
            this.lviewFrames.Size = new System.Drawing.Size(201, 109);
            this.lviewFrames.TabIndex = 3;
            this.lviewFrames.UseCompatibleStateImageBehavior = false;
            this.lviewFrames.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(2, 49);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvert.ForeColor = System.Drawing.Color.Red;
            this.btnConvert.Location = new System.Drawing.Point(2, 261);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 40);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelp.Location = new System.Drawing.Point(-1, 120);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(29, 13);
            this.lblHelp.TabIndex = 6;
            this.lblHelp.TabStop = true;
            this.lblHelp.Text = "Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "png";
            this.saveDialog.FileName = "spriteSheet.png";
            this.saveDialog.Filter = "Sprite sheet|*png";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageImage);
            this.tabControl.Controls.Add(this.tabPageGIF);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(337, 332);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.pictureBox);
            this.tabPageImage.Controls.Add(this.lblRestart);
            this.tabPageImage.Controls.Add(this.webBrowser);
            this.tabPageImage.Controls.Add(this.btnOpen);
            this.tabPageImage.Controls.Add(this.lviewFrames);
            this.tabPageImage.Controls.Add(this.btnConvert);
            this.tabPageImage.Controls.Add(this.lblHelp);
            this.tabPageImage.Controls.Add(this.btnClear);
            this.tabPageImage.Controls.Add(this.cmbAlign);
            this.tabPageImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(329, 306);
            this.tabPageImage.TabIndex = 0;
            this.tabPageImage.Text = "Convert from images";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox.Image = global::SpritePacker.Resource.help;
            this.pictureBox.Location = new System.Drawing.Point(2, 136);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(118, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Location = new System.Drawing.Point(135, 143);
            this.lblRestart.Margin = new System.Windows.Forms.Padding(10);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(40, 13);
            this.lblRestart.TabIndex = 12;
            this.lblRestart.TabStop = true;
            this.lblRestart.Text = "Replay";
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(126, 120);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(201, 183);
            this.webBrowser.TabIndex = 8;
            // 
            // tabPageGIF
            // 
            this.tabPageGIF.Controls.Add(this.pictureBoxGif);
            this.tabPageGIF.Controls.Add(this.lblRestartGif);
            this.tabPageGIF.Controls.Add(this.webBrowserGif);
            this.tabPageGIF.Controls.Add(this.cmbAlignGif);
            this.tabPageGIF.Controls.Add(this.lblHelpGif);
            this.tabPageGIF.Controls.Add(this.btnConvertGif);
            this.tabPageGIF.Controls.Add(this.lblGifLocation);
            this.tabPageGIF.Controls.Add(this.btnOpenGif);
            this.tabPageGIF.Location = new System.Drawing.Point(4, 22);
            this.tabPageGIF.Name = "tabPageGIF";
            this.tabPageGIF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGIF.Size = new System.Drawing.Size(329, 306);
            this.tabPageGIF.TabIndex = 1;
            this.tabPageGIF.Text = "Convert from GIF";
            this.tabPageGIF.UseVisualStyleBackColor = true;
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Location = new System.Drawing.Point(2, 111);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(120, 103);
            this.pictureBoxGif.TabIndex = 14;
            this.pictureBoxGif.TabStop = false;
            // 
            // lblRestartGif
            // 
            this.lblRestartGif.AutoSize = true;
            this.lblRestartGif.LinkColor = System.Drawing.Color.Blue;
            this.lblRestartGif.Location = new System.Drawing.Point(134, 80);
            this.lblRestartGif.Margin = new System.Windows.Forms.Padding(10);
            this.lblRestartGif.Name = "lblRestartGif";
            this.lblRestartGif.Size = new System.Drawing.Size(40, 13);
            this.lblRestartGif.TabIndex = 11;
            this.lblRestartGif.TabStop = true;
            this.lblRestartGif.Text = "Replay";
            this.lblRestartGif.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblRestartGif.Click += new System.EventHandler(this.lblRestartGif_Click);
            // 
            // webBrowserGif
            // 
            this.webBrowserGif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserGif.Location = new System.Drawing.Point(127, 72);
            this.webBrowserGif.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGif.Name = "webBrowserGif";
            this.webBrowserGif.Size = new System.Drawing.Size(199, 142);
            this.webBrowserGif.TabIndex = 10;
            // 
            // cmbAlignGif
            // 
            this.cmbAlignGif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlignGif.Items.AddRange(new object[] {
            "Horizontal Line",
            "Vertical Line",
            "Rectangular Horizontal",
            "(N/A)Rectangualr Vertical"});
            this.cmbAlignGif.Location = new System.Drawing.Point(2, 72);
            this.cmbAlignGif.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlignGif.Name = "cmbAlignGif";
            this.cmbAlignGif.Size = new System.Drawing.Size(120, 21);
            this.cmbAlignGif.TabIndex = 8;
            // 
            // lblHelpGif
            // 
            this.lblHelpGif.AutoSize = true;
            this.lblHelpGif.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelpGif.Location = new System.Drawing.Point(-1, 95);
            this.lblHelpGif.Name = "lblHelpGif";
            this.lblHelpGif.Size = new System.Drawing.Size(29, 13);
            this.lblHelpGif.TabIndex = 7;
            this.lblHelpGif.TabStop = true;
            this.lblHelpGif.Text = "Help";
            this.lblHelpGif.Click += new System.EventHandler(this.lblHelpGif_Click);
            // 
            // btnConvertGif
            // 
            this.btnConvertGif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertGif.ForeColor = System.Drawing.Color.Red;
            this.btnConvertGif.Location = new System.Drawing.Point(2, 219);
            this.btnConvertGif.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertGif.Name = "btnConvertGif";
            this.btnConvertGif.Size = new System.Drawing.Size(325, 40);
            this.btnConvertGif.TabIndex = 6;
            this.btnConvertGif.Text = "Convert!";
            this.btnConvertGif.UseVisualStyleBackColor = true;
            this.btnConvertGif.Click += new System.EventHandler(this.btnConvertGif_Click);
            // 
            // lblGifLocation
            // 
            this.lblGifLocation.AutoSize = true;
            this.lblGifLocation.Location = new System.Drawing.Point(-1, 47);
            this.lblGifLocation.Name = "lblGifLocation";
            this.lblGifLocation.Size = new System.Drawing.Size(35, 13);
            this.lblGifLocation.TabIndex = 2;
            this.lblGifLocation.Text = "label1";
            // 
            // btnOpenGif
            // 
            this.btnOpenGif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenGif.Location = new System.Drawing.Point(2, 5);
            this.btnOpenGif.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenGif.Name = "btnOpenGif";
            this.btnOpenGif.Size = new System.Drawing.Size(325, 40);
            this.btnOpenGif.TabIndex = 1;
            this.btnOpenGif.Text = "Open GIF";
            this.btnOpenGif.UseVisualStyleBackColor = true;
            this.btnOpenGif.Click += new System.EventHandler(this.btnOpenGif_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 331);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "frmMain";
            this.Text = "Sprite Packer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageImage.ResumeLayout(false);
            this.tabPageImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPageGIF.ResumeLayout(false);
            this.tabPageGIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ComboBox cmbAlign;
        private System.Windows.Forms.ListView lviewFrames;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.LinkLabel lblHelp;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.TabPage tabPageGIF;
        private System.Windows.Forms.Button btnOpenGif;
        private System.Windows.Forms.ComboBox cmbAlignGif;
        private System.Windows.Forms.LinkLabel lblHelpGif;
        private System.Windows.Forms.Button btnConvertGif;
        private System.Windows.Forms.Label lblGifLocation;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.WebBrowser webBrowserGif;
        private System.Windows.Forms.LinkLabel lblRestart;
        private System.Windows.Forms.LinkLabel lblRestartGif;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBoxGif;
    }
}


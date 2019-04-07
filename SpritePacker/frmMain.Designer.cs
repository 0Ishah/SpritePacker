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
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFramesDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.lblAbout = new System.Windows.Forms.LinkLabel();
            this.lblSupport = new System.Windows.Forms.LinkLabel();
            this.groupPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.tabPageGIF = new System.Windows.Forms.TabPage();
            this.pictureBoxPreviewGif = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelpGif = new System.Windows.Forms.PictureBox();
            this.cmbAlignGif = new System.Windows.Forms.ComboBox();
            this.lblHelpGif = new System.Windows.Forms.LinkLabel();
            this.btnConvertGif = new System.Windows.Forms.Button();
            this.lblGifLocation = new System.Windows.Forms.Label();
            this.btnOpenGif = new System.Windows.Forms.Button();
            this.tmrFrameUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupPreviewGifFrames = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAboutGif = new System.Windows.Forms.LinkLabel();
            this.lblSupportGif = new System.Windows.Forms.LinkLabel();
            this.openGifDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.tabPageGIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpGif)).BeginInit();
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
            // openFramesDialog
            // 
            this.openFramesDialog.FileName = "Your frames";
            this.openFramesDialog.Filter = "Images|*.png;*.jpg";
            this.openFramesDialog.Multiselect = true;
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
            this.btnConvert.Location = new System.Drawing.Point(0, 266);
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
            this.lblHelp.Location = new System.Drawing.Point(36, 116);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(0);
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
            this.tabControl.Size = new System.Drawing.Size(387, 332);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.lblAbout);
            this.tabPageImage.Controls.Add(this.lblSupport);
            this.tabPageImage.Controls.Add(this.groupPreview);
            this.tabPageImage.Controls.Add(this.pictureBoxPreview);
            this.tabPageImage.Controls.Add(this.pictureBoxHelp);
            this.tabPageImage.Controls.Add(this.btnOpen);
            this.tabPageImage.Controls.Add(this.btnConvert);
            this.tabPageImage.Controls.Add(this.lblHelp);
            this.tabPageImage.Controls.Add(this.btnClear);
            this.tabPageImage.Controls.Add(this.cmbAlign);
            this.tabPageImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(379, 306);
            this.tabPageImage.TabIndex = 0;
            this.tabPageImage.Text = "Convert from images";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAbout.Location = new System.Drawing.Point(1, 116);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(35, 13);
            this.lblAbout.TabIndex = 18;
            this.lblAbout.TabStop = true;
            this.lblAbout.Text = "About";
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupport.Location = new System.Drawing.Point(65, 116);
            this.lblSupport.Margin = new System.Windows.Forms.Padding(0);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(44, 13);
            this.lblSupport.TabIndex = 17;
            this.lblSupport.TabStop = true;
            this.lblSupport.Text = "Support";
            this.lblSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSupport_LinkClicked);
            // 
            // groupPreview
            // 
            this.groupPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPreview.AutoScroll = true;
            this.groupPreview.Location = new System.Drawing.Point(125, 6);
            this.groupPreview.Name = "groupPreview";
            this.groupPreview.Size = new System.Drawing.Size(250, 108);
            this.groupPreview.TabIndex = 16;
            this.groupPreview.WrapContents = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.Location = new System.Drawing.Point(125, 136);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(250, 170);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 15;
            this.pictureBoxPreview.TabStop = false;
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Location = new System.Drawing.Point(0, 136);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(118, 125);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.TabIndex = 13;
            this.pictureBoxHelp.TabStop = false;
            // 
            // tabPageGIF
            // 
            this.tabPageGIF.Controls.Add(this.lblAboutGif);
            this.tabPageGIF.Controls.Add(this.lblSupportGif);
            this.tabPageGIF.Controls.Add(this.groupPreviewGifFrames);
            this.tabPageGIF.Controls.Add(this.pictureBoxPreviewGif);
            this.tabPageGIF.Controls.Add(this.pictureBoxHelpGif);
            this.tabPageGIF.Controls.Add(this.cmbAlignGif);
            this.tabPageGIF.Controls.Add(this.lblHelpGif);
            this.tabPageGIF.Controls.Add(this.btnConvertGif);
            this.tabPageGIF.Controls.Add(this.lblGifLocation);
            this.tabPageGIF.Controls.Add(this.btnOpenGif);
            this.tabPageGIF.Location = new System.Drawing.Point(4, 22);
            this.tabPageGIF.Name = "tabPageGIF";
            this.tabPageGIF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGIF.Size = new System.Drawing.Size(379, 306);
            this.tabPageGIF.TabIndex = 1;
            this.tabPageGIF.Text = "Convert from GIF";
            this.tabPageGIF.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreviewGif
            // 
            this.pictureBoxPreviewGif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreviewGif.Location = new System.Drawing.Point(128, 114);
            this.pictureBoxPreviewGif.Name = "pictureBoxPreviewGif";
            this.pictureBoxPreviewGif.Size = new System.Drawing.Size(248, 189);
            this.pictureBoxPreviewGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreviewGif.TabIndex = 15;
            this.pictureBoxPreviewGif.TabStop = false;
            // 
            // pictureBoxHelpGif
            // 
            this.pictureBoxHelpGif.Location = new System.Drawing.Point(2, 114);
            this.pictureBoxHelpGif.Name = "pictureBoxHelpGif";
            this.pictureBoxHelpGif.Size = new System.Drawing.Size(120, 148);
            this.pictureBoxHelpGif.TabIndex = 14;
            this.pictureBoxHelpGif.TabStop = false;
            // 
            // cmbAlignGif
            // 
            this.cmbAlignGif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlignGif.Items.AddRange(new object[] {
            "Horizontal Line",
            "Vertical Line",
            "Rectangular Horizontal",
            "(N/A)Rectangualr Vertical"});
            this.cmbAlignGif.Location = new System.Drawing.Point(2, 62);
            this.cmbAlignGif.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlignGif.Name = "cmbAlignGif";
            this.cmbAlignGif.Size = new System.Drawing.Size(120, 21);
            this.cmbAlignGif.TabIndex = 8;
            // 
            // lblHelpGif
            // 
            this.lblHelpGif.AutoSize = true;
            this.lblHelpGif.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHelpGif.Location = new System.Drawing.Point(35, 85);
            this.lblHelpGif.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHelpGif.Name = "lblHelpGif";
            this.lblHelpGif.Size = new System.Drawing.Size(29, 13);
            this.lblHelpGif.TabIndex = 7;
            this.lblHelpGif.TabStop = true;
            this.lblHelpGif.Text = "Help";
            this.lblHelpGif.Click += new System.EventHandler(this.lblHelpGif_Click);
            // 
            // btnConvertGif
            // 
            this.btnConvertGif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvertGif.ForeColor = System.Drawing.Color.Red;
            this.btnConvertGif.Location = new System.Drawing.Point(2, 264);
            this.btnConvertGif.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertGif.Name = "btnConvertGif";
            this.btnConvertGif.Size = new System.Drawing.Size(120, 40);
            this.btnConvertGif.TabIndex = 6;
            this.btnConvertGif.Text = "Convert!";
            this.btnConvertGif.UseVisualStyleBackColor = true;
            this.btnConvertGif.Click += new System.EventHandler(this.btnConvertGif_Click);
            // 
            // lblGifLocation
            // 
            this.lblGifLocation.AutoSize = true;
            this.lblGifLocation.Location = new System.Drawing.Point(3, 47);
            this.lblGifLocation.Name = "lblGifLocation";
            this.lblGifLocation.Size = new System.Drawing.Size(0, 13);
            this.lblGifLocation.TabIndex = 2;
            // 
            // btnOpenGif
            // 
            this.btnOpenGif.Location = new System.Drawing.Point(2, 5);
            this.btnOpenGif.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenGif.Name = "btnOpenGif";
            this.btnOpenGif.Size = new System.Drawing.Size(120, 40);
            this.btnOpenGif.TabIndex = 1;
            this.btnOpenGif.Text = "Open GIF";
            this.btnOpenGif.UseVisualStyleBackColor = true;
            this.btnOpenGif.Click += new System.EventHandler(this.btnOpenGif_Click);
            // 
            // tmrFrameUpdate
            // 
            this.tmrFrameUpdate.Interval = 200;
            this.tmrFrameUpdate.Tick += new System.EventHandler(this.tmrFrameUpdate_Tick);
            // 
            // groupPreviewGifFrames
            // 
            this.groupPreviewGifFrames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPreviewGifFrames.AutoScroll = true;
            this.groupPreviewGifFrames.Location = new System.Drawing.Point(128, 6);
            this.groupPreviewGifFrames.Name = "groupPreviewGifFrames";
            this.groupPreviewGifFrames.Size = new System.Drawing.Size(248, 102);
            this.groupPreviewGifFrames.TabIndex = 17;
            this.groupPreviewGifFrames.WrapContents = false;
            // 
            // lblAboutGif
            // 
            this.lblAboutGif.AutoSize = true;
            this.lblAboutGif.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAboutGif.Location = new System.Drawing.Point(-1, 85);
            this.lblAboutGif.Margin = new System.Windows.Forms.Padding(0);
            this.lblAboutGif.Name = "lblAboutGif";
            this.lblAboutGif.Size = new System.Drawing.Size(35, 13);
            this.lblAboutGif.TabIndex = 20;
            this.lblAboutGif.TabStop = true;
            this.lblAboutGif.Text = "About";
            // 
            // lblSupportGif
            // 
            this.lblSupportGif.AutoSize = true;
            this.lblSupportGif.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSupportGif.Location = new System.Drawing.Point(65, 85);
            this.lblSupportGif.Margin = new System.Windows.Forms.Padding(0);
            this.lblSupportGif.Name = "lblSupportGif";
            this.lblSupportGif.Size = new System.Drawing.Size(44, 13);
            this.lblSupportGif.TabIndex = 19;
            this.lblSupportGif.TabStop = true;
            this.lblSupportGif.Text = "Support";
            this.lblSupportGif.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSupportGif_LinkClicked);
            // 
            // openGifDialog
            // 
            this.openGifDialog.FileName = "Your gif";
            this.openGifDialog.Filter = "Gif Images|*.gif";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(400, 370);
            this.Name = "frmMain";
            this.Text = "Sprite Packer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageImage.ResumeLayout(false);
            this.tabPageImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.tabPageGIF.ResumeLayout(false);
            this.tabPageGIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFramesDialog;
        private System.Windows.Forms.ComboBox cmbAlign;
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
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.PictureBox pictureBoxHelpGif;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.PictureBox pictureBoxPreviewGif;
        private System.Windows.Forms.FlowLayoutPanel groupPreview;
        private System.Windows.Forms.Timer tmrFrameUpdate;
        private System.Windows.Forms.LinkLabel lblSupport;
        private System.Windows.Forms.LinkLabel lblAbout;
        private System.Windows.Forms.FlowLayoutPanel groupPreviewGifFrames;
        private System.Windows.Forms.LinkLabel lblAboutGif;
        private System.Windows.Forms.LinkLabel lblSupportGif;
        private System.Windows.Forms.OpenFileDialog openGifDialog;
    }
}


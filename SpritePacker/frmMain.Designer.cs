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
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.cmbAlign = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.LinkLabel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.previewGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.tabPageGIF = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.cmbAlignGif = new System.Windows.Forms.ComboBox();
            this.lblHelpGif = new System.Windows.Forms.LinkLabel();
            this.btnConvertGif = new System.Windows.Forms.Button();
            this.lblGifLocation = new System.Windows.Forms.Label();
            this.btnOpenGif = new System.Windows.Forms.Button();
            this.tmrFrameUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.tabPageGIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnConvert.Location = new System.Drawing.Point(2, 266);
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
            this.tabControl.Size = new System.Drawing.Size(387, 332);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.previewGroup);
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
            // previewGroup
            // 
            this.previewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGroup.AutoScroll = true;
            this.previewGroup.Location = new System.Drawing.Point(125, 6);
            this.previewGroup.Name = "previewGroup";
            this.previewGroup.Size = new System.Drawing.Size(250, 108);
            this.previewGroup.TabIndex = 16;
            this.previewGroup.WrapContents = false;
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
            this.pictureBoxHelp.Location = new System.Drawing.Point(2, 136);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(118, 125);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.TabIndex = 13;
            this.pictureBoxHelp.TabStop = false;
            // 
            // tabPageGIF
            // 
            this.tabPageGIF.Controls.Add(this.pictureBox1);
            this.tabPageGIF.Controls.Add(this.pictureBoxGif);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 187);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Location = new System.Drawing.Point(2, 111);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(120, 148);
            this.pictureBoxGif.TabIndex = 14;
            this.pictureBoxGif.TabStop = false;
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
            this.btnConvertGif.Location = new System.Drawing.Point(2, 264);
            this.btnConvertGif.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertGif.Name = "btnConvertGif";
            this.btnConvertGif.Size = new System.Drawing.Size(375, 40);
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
            this.btnOpenGif.Size = new System.Drawing.Size(375, 40);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openDialog;
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
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel previewGroup;
        private System.Windows.Forms.Timer tmrFrameUpdate;
    }
}


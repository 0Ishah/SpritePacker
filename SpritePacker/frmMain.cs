using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SpritePacker
{
    public partial class frmMain : Form
    {
        private List<Image> frames = new List<Image>();
        private List<Image> gifFrames = new List<Image>();
        private Image gifSpriteSheet;
        private Bitmap spriteSheet;
        private Image gifSource;

        public frmMain()
        {
            InitializeComponent();  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbAlign.SelectedIndex = 0;
            cmbAlignGif.SelectedIndex = 0;
            tmrFrameUpdate.Interval = (int)((float)numPlaySpeed.Value * -10f + 1001);
            groupPreview.VerticalScroll.Visible = false;
            groupPreview.VerticalScroll.Enabled = false;
            groupPreview.HorizontalScroll.Enabled = true;
            groupPreview.HorizontalScroll.Visible = true;
            numPlaySpeed.Visible = false;
            lblNumFrames.Hide();
            lblNumFramesGif.Hide();
            cmbAlign.SelectedIndex = 2;
            cmbAlignGif.SelectedIndex = 2;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFramesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> framePaths = new List<string>();
                    framePaths.AddRange(openFramesDialog.FileNames);
                    Image tempSizeCheck = Image.FromFile(framePaths[0]);
                    bool isSameSize = true;

                    for (int i = 0; i < framePaths.Count; i++)
                    {
                        frames.Add(Image.FromFile(framePaths[i]));
                        if (frames[i].Width != tempSizeCheck.Width || frames[i].Height != tempSizeCheck.Height)
                        {
                            isSameSize = false;
                        }
                    }

                    DialogResult differntSizeDialog = DialogResult.Yes;
                    if (!isSameSize)
                    {
                        differntSizeDialog = MessageBox.Show("Some of the selected images have different size. This can potentially cause problems with the sprite sheet. Do you want to continue?",
                                                             "Warning", MessageBoxButtons.YesNo);
                    }

                    if (differntSizeDialog == DialogResult.Yes)
                    {
                        groupPreview.Controls.Clear();
                        for (int i = 0; i < frames.Count; i++)
                        {
                            PictureBox tempPic = new PictureBox()
                            {
                                Margin = new Padding(0, 0, 2, 0),
                                Size = new Size(85, 85),
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = frames[i]
                            };

                            Label tempLbl = new Label()
                            {
                                //Text = "sample",
                                Location = new Point(0, 72)

                            };
                            tempPic.BringToFront();
                            tempLbl.BringToFront();
                            tempPic.Controls.Add(tempLbl);
                            groupPreview.Controls.Add(tempPic);
                        }

                        curFrame = 0;
                        pictureBoxPreview.Image = frames[curFrame];
                        numPlaySpeed.Visible = true;
                        btnOpen.Text = "Add frames";
                        lblNumFrames.Show();
                        lblNumFrames.Text = ("Frames: " + frames.Count());
                        numColumns.Maximum = frames.Count - 1;
                        tmrFrameUpdate.Start();
                    }
                    else
                    {
                        ClearFrameSelection();
                    }
                }
                catch
                {
                    MessageBox.Show("An unexpected error occured");
                    ClearFrameSelection();
                }
            }
        }

        private void cmbAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlign.SelectedIndex == 2)
            {
                lblNumColumns.Show();
                numColumns.Show();
                lblAbout.Location = new Point(0, 140);
                lblSupport.Location = new Point(35, 140);
            }
            else
            {
                lblNumColumns.Hide();
                numColumns.Hide();
                lblAbout.Location = new Point(0, 115);
                lblSupport.Location = new Point(35, 115);
            }
        }

        private void numPlaySpeed_ValueChanged(object sender, EventArgs e)
        {
            tmrFrameUpdate.Interval = (int)((float)numPlaySpeed.Value * -10f + 1001);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (frames.Count() != 0)
            {
                DialogResult clearCheck=  MessageBox.Show("Are you sure you want to clear the selected files?", "Clear", MessageBoxButtons.YesNo);
                if (clearCheck == DialogResult.Yes)
                {
                    ClearFrameSelection();
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (frames.Any() && saveDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (cmbAlign.SelectedIndex)
                    {
                        case 0:
                            spriteSheet = HorizontalAlign(frames);
                            break;
                        case 1:
                            spriteSheet = VerticalAlign(frames);
                            break;
                        case 2:
                            spriteSheet = BoxHorizontalAlign(frames,(int)numColumns.Value);
                            break;
                    }
                    spriteSheet.Save(saveDialog.FileName, ImageFormat.Png);
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occured");
            }
        }

        private int curFrame = 1;
        private void tmrFrameUpdate_Tick(object sender, EventArgs e)
        {
            curFrame++;
            if (curFrame < frames.Count)
            {
                pictureBoxPreview.Image = frames[curFrame];
            }
            else
            {
                curFrame = 0;
                pictureBoxPreview.Image = frames[curFrame];
            }
            
        }

        private void btnOpenGif_Click(object sender, EventArgs e)
        {
            if (openGifDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gifFrames.Clear();
                    groupPreviewGifFrames.Controls.Clear();
                    groupPreviewGifFrames.ResetText();
                    pictureBoxPreviewGif.Image = null;

                    gifSource = Image.FromFile(openGifDialog.FileName);
                    lblGifLocation.Text = Path.GetFileName(openGifDialog.FileName);
                    pictureBoxPreviewGif.Image = gifSource;

                    int index = 0;
                    int duration = 0;
                    for (int i = 0; i < gifSource.GetFrameCount(FrameDimension.Time); i++)
                    {
                        gifSource.SelectActiveFrame(FrameDimension.Time, i);
                        Image frame = gifSource.Clone() as Image;
                        gifFrames.Add(frame);

                        var delay = BitConverter.ToInt32(gifSource.GetPropertyItem(20736).Value, index) * 10;
                        duration += (delay < 100 ? 100 : delay);

                        index += 4;
                    }

                    lblNumFramesGif.Show();
                    lblNumFramesGif.Text = ("Frames: " + gifFrames.Count());
                    numColumnsGif.Maximum = gifFrames.Count() - 1;

                    for (int i = 0; i < gifFrames.Count; i++)
                    {
                        PictureBox tempPic = new PictureBox()
                        {
                            Margin = new Padding(0, 0, 2, 0),
                            Size = new Size(85, 85),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Image = gifFrames[i]
                        };
                        tempPic.Enabled = false;
                        tempPic.BringToFront();
                        groupPreviewGifFrames.Controls.Add(tempPic);
                    }
                }
                catch
                {
                    MessageBox.Show("An unexpected error occured");
                    gifFrames.Clear();
                    groupPreviewGifFrames.Controls.Clear();
                    groupPreviewGifFrames.ResetText();
                    pictureBoxPreviewGif.Image = null;
                    lblNumFramesGif.Hide();
                }
            }   
        }

        private void cmbAlignGif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlignGif.SelectedIndex == 2)
            {
                lblNumColumnsGif.Show();
                numColumnsGif.Show();
                lblAboutGif.Location = new Point(0, 115);
                lblSupportGif.Location = new Point(35, 115);

            }
            else
            {
                lblNumColumnsGif.Hide();
                numColumnsGif.Hide();
                lblAboutGif.Location = new Point(0, 95);
                lblSupportGif.Location = new Point(35, 95);
            }
        }

        private void btnConvertGif_Click(object sender, EventArgs e)
        {
            if (gifFrames.Any() && saveDialog.ShowDialog() == DialogResult.OK)
            {
                switch (cmbAlignGif.SelectedIndex)
                {
                    case 0:
                        spriteSheet = HorizontalAlign(gifFrames);
                        break;
                    case 1:
                        spriteSheet = VerticalAlign(gifFrames);
                        break;
                    case 2:
                        spriteSheet = BoxHorizontalAlign(gifFrames,(int)numColumnsGif.Value);
                        break;
                }
                try
                {
                    spriteSheet.Save(saveDialog.FileName, ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("An error occured when saving the image. This could be caused by excessive file size");
                    gifFrames.Clear();
                    groupPreviewGifFrames.Controls.Clear();
                    groupPreviewGifFrames.ResetText();
                    pictureBoxPreviewGif.Image = null;
                    lblNumFramesGif.Hide();
                }
            }
        }

        private void ClearFrameSelection()
        {
            frames.Clear();
            groupPreview.Controls.Clear();
            groupPreview.ResetText();
            btnOpen.Text = "Select frames";
            numPlaySpeed.Visible = false;
            pictureBoxPreview.Image = null;
            lblNumFrames.Hide();
            tmrFrameUpdate.Stop();
        }

        private Bitmap HorizontalAlign(List<Image> frames)
        {
            int width = frames[0].Width;
            int height = frames[0].Height;

            Bitmap sprite = new Bitmap(width * frames.Count(), height);
            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < frames.Count(); i++)
                {
                    g.DrawImageUnscaledAndClipped(frames[i], new Rectangle(width * i, 0, width, height));
                }
            }

            return sprite;
        }

        private Bitmap VerticalAlign(List<Image> frames)
        {
            int width = frames[0].Width;
            int height = frames[0].Height;

            Bitmap sprite = new Bitmap(width, height * frames.Count());
            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Transparent);
                for (int i = 0; i < frames.Count(); i++)
                {
                    g.DrawImageUnscaledAndClipped(frames[i], new Rectangle(0, height * i, width, height));
                }
            }

            return sprite;
        }

        private Bitmap BoxHorizontalAlign(List<Image> frames, int columns)
        {
            int width = frames[0].Width;
            int height = frames[0].Height;

            Bitmap sprite = new Bitmap(width * columns, height * ((frames.Count() / columns) + (frames.Count % columns != 0 ? 1 : 0)));
            Console.WriteLine(frames.Count() / columns);
            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Transparent);

                int cur = 0;
                for (int n = 0; n <= frames.Count() / columns; n++)
                {
                    for (int m = 0; m < columns; m++)
                    {
                        try
                        {
                            g.DrawImageUnscaledAndClipped(frames[cur], new Rectangle(m * width, n * height, width, height));
                            cur++;
                        }
                        catch{break;}
                    }
                }
            }
            return sprite;
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            ShowManual();
        }

        private void lblAboutGif_Click(object sender, EventArgs e)
        {
            ShowManual();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (Directory.Exists(String.Format(@"{0}\spritePackerTempFiles", Path.GetTempPath())))
                {
                    Directory.Delete(String.Format(@"{0}\spritePackerTempFiles", Path.GetTempPath()), true);
                }
            }
            catch
            {
            }
        }

        private void ShowManual()
        {
            try
            {
                string tempPath = String.Format(@"{0}\spritePackerTempFiles", Path.GetTempPath());
                Directory.CreateDirectory(tempPath);

                string page = String.Format(@"{0}\spritemanual.html", tempPath);
                string style = String.Format(@"{0}\style.css", tempPath);
                File.WriteAllText(page, Properties.Resources.manual);
                File.WriteAllText(style, Properties.Resources.style);

                Properties.Resources.e1.Save(String.Format(@"{0}\e1.png", tempPath));
                Properties.Resources.e2.Save(String.Format(@"{0}\e2.png", tempPath));
                Properties.Resources.e3.Save(String.Format(@"{0}\e3.png", tempPath));

                System.Diagnostics.Process.Start(page);
            }
            catch
            {
                MessageBox.Show("An error occured. This problem most likely caused by inaccessible temp folder");
                ClearFrameSelection();
            }
        }

        private void lblSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=UCXUXFEJ2583E&item_name=Need+money+for+food&currency_code=CAD&amount=2&source=url");
        }

        private void lblSupportGif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=UCXUXFEJ2583E&item_name=Need+money+for+food&currency_code=CAD&amount=2&source=url");
        }
    }
}


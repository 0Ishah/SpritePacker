using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
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

        private const int NUM_ROWS = 4;

        public frmMain()
        {
            InitializeComponent();  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbAlign.SelectedIndex = 0;
            cmbAlignGif.SelectedIndex = 0;
            pictureBoxHelp.Visible = false;
            pictureBoxHelpGif.Visible = false;
            groupPreview.VerticalScroll.Visible = false;
            groupPreview.VerticalScroll.Enabled = false;
            groupPreview.HorizontalScroll.Enabled = true;
            groupPreview.HorizontalScroll.Visible = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFramesDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> framePaths = new List<string>();
                framePaths.AddRange(openFramesDialog.FileNames);
                foreach (string path in framePaths)
                {
                    frames.Add(Image.FromFile(path));
                }

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
                        Text = "sample",
                        Location = new Point(0, 72)
                        
                    };

                    tempPic.BringToFront();
                    tempLbl.BringToFront();
                    tempPic.Controls.Add(tempLbl);
                    groupPreview.Controls.Add(tempPic);
                }

                curFrame = 0;
                pictureBoxPreview.Image = frames[curFrame];
                tmrFrameUpdate.Start();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (frames.Count() != 0)
            {
                DialogResult clearCheck=  MessageBox.Show("Are you sure you want to clear the selected files?", "Clear", MessageBoxButtons.YesNo);
                if (clearCheck == DialogResult.Yes)
                {
                    frames.Clear();
                    groupPreview.Controls.Clear();
                    groupPreview.ResetText();
                    pictureBoxPreview.Image = null;
                    tmrFrameUpdate.Stop();
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
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
                        spriteSheet = BoxHorizontalAlign(frames);
                        break;
                }
                spriteSheet.Save(saveDialog.FileName, ImageFormat.Png);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            if (pictureBoxHelp.Visible)
            {
                pictureBoxHelp.Hide();
            }
            else
            {
                pictureBoxHelp.Show();
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

                for (int i = 0; i < gifFrames.Count; i++)
                {
                    PictureBox tempPic = new PictureBox()
                    {
                        Margin = new Padding(0, 0, 2, 0),
                        Size = new Size(85, 85),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = gifFrames[i]
                    };
                    tempPic.BringToFront();
                    groupPreviewGifFrames.Controls.Add(tempPic);
                }
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
                        spriteSheet = BoxHorizontalAlign(gifFrames);
                        break;
                }
                spriteSheet.Save(saveDialog.FileName, ImageFormat.Png);
            }
        }

        private void lblHelpGif_Click(object sender, EventArgs e)
        {

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

        private Bitmap BoxHorizontalAlign(List<Image> frames)
        {
            int width = frames[0].Width;
            int height = frames[0].Height;

            Bitmap sprite = new Bitmap(width * NUM_ROWS, height * ((frames.Count() / NUM_ROWS) + 1));
            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Transparent);

                int cur = 0;
                for (int n = 0; n <= frames.Count() / NUM_ROWS; n++)
                {
                    for (int m = 0; m < NUM_ROWS; m++)
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

        private void lblSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=UCXUXFEJ2583E&item_name=Need+money+for+food&currency_code=CAD&amount=4&source=url");
        }

        private void lblSupportGif_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=UCXUXFEJ2583E&item_name=Need+money+for+food&currency_code=CAD&amount=4&source=url");
        }
    }
}


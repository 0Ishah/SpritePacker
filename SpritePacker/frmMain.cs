using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpritePacker
{
    public partial class frmMain : Form
    {
        public List<Image> frames = new List<Image>();
        public string gifPath;

        public frmMain()
        {
            InitializeComponent();  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbAlign.SelectedIndex = 0;
            cmbAlignGif.SelectedIndex = 0;
            lblRestart.Visible = false;
            lblRestartGif.Visible = false;
            pictureBox.Visible = false;
            pictureBoxGif.Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<string> framePaths = new List<string>();
                framePaths.AddRange(openDialog.FileNames);
                foreach (string path in framePaths)
                {
                    frames.Add(Image.FromFile(path));
                }

                lviewFrames.Clear();
                foreach (string frame in framePaths)
                {
                    lviewFrames.Items.Add(frame);
                }

                GifBitmapEncoder gifEncoder = new GifBitmapEncoder();
                foreach (Bitmap frame in frames)
                {
                    IntPtr bmp = frame.GetHbitmap();
                    BitmapSource src = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        bmp,
                        IntPtr.Zero,
                        System.Windows.Int32Rect.Empty,
                        BitmapSizeOptions.FromEmptyOptions());
                    gifEncoder.Frames.Add(BitmapFrame.Create(src));
                }

                using (FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\tmepGif.gif", FileMode.Create))
                {
                    gifEncoder.Save(fs);
                }
                lblRestart.Visible = true;
                webBrowser.DocumentText = "<html><head></head><body><img src='" + AppDomain.CurrentDomain.BaseDirectory + @"\tmepGif.gif" + "'/></body></html>";
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
                    lviewFrames.Clear();
                    webBrowser.Navigate("about:blank");
                    lblRestart.Visible = false;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (frames.Count != 0)
            {
                Bitmap finalSprite = new Bitmap(frames[0]);
                switch (cmbAlign.SelectedIndex)
                {
                    case 0:
                        finalSprite = HorizontalAlign(frames);
                        break;
                    case 1:
                        finalSprite = VerticalAlign(frames);
                        break;
                    case 2:

                        break;
                    default:
                        finalSprite = HorizontalAlign(frames);
                        break;
                }

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    finalSprite.Save(saveDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("File saved to: " + saveDialog.FileName);
                }
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            if (pictureBox.Visible)
            {
                pictureBox.Hide();
            }
            else
            {
                pictureBox.Show();
            }
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
        
        private void btnOpenGif_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertGif_Click(object sender, EventArgs e)
        {

        }

        private void lblHelpGif_Click(object sender, EventArgs e)
        {

        }

        private void lblRestartGif_Click(object sender, EventArgs e)
        {

        }

        private Bitmap HorizontalAlign(List<Image> frames)
        {
            int origWidht = frames[0].Width;
            int origHeight = frames[0].Height;

            int finalWidht = origWidht * frames.Count();

            Bitmap sprite = new Bitmap(finalWidht, origHeight);

            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Black);
                for (int i = 0; i < frames.Count(); i++)
                {
                    g.DrawImage(frames[i], new Point(origWidht * i, 0));
                }
            }

            foreach (Image frame in frames)
            {
                frame.Dispose();
            }

            return sprite;
        }

        private Bitmap VerticalAlign(List<Image> frames)
        {
            int origWidht = frames[0].Width;
            int origHeight = frames[0].Height;

            int finalHeight = origHeight * frames.Count();

            Bitmap sprite = new Bitmap(origWidht, finalHeight);

            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.Clear(Color.Black);
                for (int i = 0; i < frames.Count(); i++)
                {
                    g.DrawImage(frames[i], new Point(0, origHeight * i));
                }
            }

            foreach (Image frame in frames)
            {
                frame.Dispose();
            }

            return sprite;
        }
    }
}

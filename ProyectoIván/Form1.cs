using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;


namespace ProyectoIván
{
    public partial class Form1 : Form
    {
        //private bool captureInProgress;
        private bool imageInProgress;
        String filenameload;
        Image<Bgr, Byte> ImageFrame = new Image<Bgr, Byte>(320, 240);
        //Image<Bgr, Byte> ImageHSVwheel = new Image<Bgr, Byte>("HSV-Wheel.png");
        Image<Hsv, Byte> hsvImage = new Image<Hsv, Byte>(0, 0);
        int diff_LH;

        public Form1()
        {
            InitializeComponent();
            Application.Idle += ProcessFrame;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                filenameload = OpenFile.FileName;
                imageInProgress = true;
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (imageInProgress)
            {
                ImageFrame = new Image<Bgr, byte>(filenameload);
                int[] whD = new int[2];
                whD[0] = ImageFrame.Width;
                whD[1] = ImageFrame.Height;
                ImageFrame = ImageFrame.Resize(whD[0], whD[1], Emgu.CV.CvEnum.Inter.Linear);
                imageBox1.Image = ImageFrame;
                ImageProcessing();
            }

        }
        private void ImageProcessing()
        {
            Image<Gray, Byte> ImageFrameDetection = cvAndHsvImage(
                ImageFrame,
               Convert.ToInt32(numeric_HL.Value), Convert.ToInt32(numeric_HH.Value),
               Convert.ToInt32(numeric_SL.Value), Convert.ToInt32(numeric_SH.Value),
               Convert.ToInt32(numeric_VL.Value), Convert.ToInt32(numeric_VH.Value),
               checkBox_EH.Checked, checkBox_ES.Checked, checkBox_EV.Checked);

            if (iB2C == 0) imageBox2.Image = ImageFrameDetection;

            if (iB2C == 1)
            {
                Image<Bgr, Byte> imgF = new Image<Bgr, Byte>(ImageFrame.Width, ImageFrame.Height);
                Image<Bgr, Byte> imgD = ImageFrameDetection.Convert<Bgr, Byte>();
                CvInvoke.BitwiseAnd(ImageFrame, imgD, imgF, null);
                imageBox2.Image = imgF;
            }

            if (iB2C == 2)
            {
                Image<Bgr, Byte> imgF = new Image<Bgr, Byte>(ImageFrame.Width, ImageFrame.Height);
                Image<Bgr, Byte> imgD = ImageFrameDetection.Convert<Bgr, Byte>();
                CvInvoke.BitwiseAnd(ImageFrame, imgD, imgF);
                for (int x = 0; x < imgF.Width; x++)
                    for (int y = 0; y < imgF.Height; y++)
                    {
                        {
                            Bgr c = imgF[y, x];
                            if (c.Red == 0 && c.Blue == 0 && c.Green == 0)
                            {
                                imgF[y, x] = new Bgr(255, 255, 255);
                            }
                        }
                    }

                imageBox2.Image = imgF;
            }
        }
            int iB2C;
            private void imageBox2_Click(object sender, EventArgs e)
            {
                iB2C++;
                if (iB2C > 2) iB2C = 0;
            }
            private Image<Gray, Byte> cvAndHsvImage(Image<Bgr, Byte> imgFame, int L1, int H1, int L2, int H2, int L3, int H3, bool H, bool S, bool V)
        {
            Image<Hsv, Byte> hsvImage = imgFame.Convert<Hsv, Byte>();
            Image<Gray, Byte> ResultImage = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageH = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageS = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> ResultImageV = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);

            Image<Gray, Byte> img1 = inRangeImage(hsvImage, L1, H1, 0);
            Image<Gray, Byte> img2 = inRangeImage(hsvImage, L2, H2, 1);
            Image<Gray, Byte> img3 = inRangeImage(hsvImage, L3, H3, 2);
            Image<Gray, Byte> img4 = inRangeImage(hsvImage, 0, L1, 0);
            Image<Gray, Byte> img5 = inRangeImage(hsvImage, H1, 180, 0);

            #region checkBox Color Mode

            if (H)
            {
              ResultImageH = img1; 
            }

            if (S) ResultImageS = img2;
            if (V) ResultImageV = img3;

            if (H && !S && !V) ResultImage = ResultImageH;
            if (!H && S && !V) ResultImage = ResultImageS;
            if (!H && !S && V) ResultImage = ResultImageV;

            if (H && S && !V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageS, ResultImageH);
                ResultImage = ResultImageH;
            }

            if (H && !S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageV, ResultImageH);
                ResultImage = ResultImageH;
            }

            if (!H && S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageS, ResultImageV, ResultImageS);
                ResultImage = ResultImageS;
            }

            if (H && S && V)
            {
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageS, ResultImageH);
                CvInvoke.BitwiseAnd(ResultImageH, ResultImageV, ResultImageH);
                ResultImage = ResultImageH;
            }
            #endregion

            //CvInvoke.Erode(ResultImage, ResultImage, (IntPtr)null, 1);

            return ResultImage;
        }

        private Image<Gray, Byte> inRangeImage(Image<Hsv, Byte> hsvImage, int Lo, int Hi, int con)
        {
            Image<Gray, Byte> ResultImage = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height);
            Image<Gray, Byte> IlowCh = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height, new Gray(Lo));
            Image<Gray, Byte> IHiCh = new Image<Gray, Byte>(hsvImage.Width, hsvImage.Height, new Gray(Hi));
            //CvInvoke.cvInRange(hsvImage[con], IlowCh, IHiCh, ResultImage);

            return ResultImage;
        }

        private void trackbar_Low_ValueChanged(object sender, EventArgs e)
        {
            numeric_HL.Value = trackBar_HL.Value;
            numeric_SL.Value = trackBar_SL.Value;
            numeric_VL.Value = trackBar_VL.Value;
        }

        private void trackBar_High_ValueChanged(object sender, EventArgs e)
        {
            numeric_HH.Value = trackBar_HH.Value;
            numeric_SH.Value = trackBar_SH.Value;
            numeric_VH.Value = trackBar_VH.Value;
        }

        private void numeric_Low_ValueChanged(object sender, EventArgs e)
        {
            trackBar_HL.Value = Convert.ToInt32(numeric_HL.Value);
            trackBar_SL.Value = Convert.ToInt32(numeric_SL.Value);
            trackBar_VL.Value = Convert.ToInt32(numeric_VL.Value);
        }

        private void numeric_High_ValueChanged(object sender, EventArgs e)
        {
            trackBar_HH.Value = Convert.ToInt32(numeric_HH.Value);
            trackBar_SH.Value = Convert.ToInt32(numeric_SH.Value);
            trackBar_VH.Value = Convert.ToInt32(numeric_VH.Value);
        }
    }
}

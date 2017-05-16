using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using XirisWeldSDK;


namespace XirisSDKtest1
{
    public partial class Form1 : Form
    {
       // Camera _camera;
        static int i = 1;
        static int n = 0;
        static bool picSave = false;
        static Semaphore picSaveSem = new Semaphore(0, 1);
        static Semaphore setting = new Semaphore(1, 1);
        string pic_format_string=".jpg";
        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CameraDetector.Instance.CameraDetected += CameraDetector_CameraDetected;
                        
        }
        private Camera _camera;
        void CameraDetector_CameraDetected(object sender, CameraDetector.CameraEventArgs e)
        {
            if (e.CanConnect)
            {
                _camera = new Camera();
                _camera.CameraReady += _camera_CameraReady;
                _camera.Connect(e.CameraIPAddress);
               

            }
        }
        void _camera_CameraReady(object sender, CameraReadyEventArgs e)
        {
            if (e.IsReady)
            {
                _camera.BufferReady += _camera_BufferReady;
                _camera.Start();


                _camera.RollingFrameRate = 5;
                rollShutter.Checked = true;
                _camera.ShutterMode = Camera.ShutterModes.Rolling;
                
            }
        }
        void _camera_BufferReady(object sender, CameraBufferReadyEventArgs e)
        {
            pictureBox1.Image = e.Image;
            saveButton.Click += saveButton_Click;
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strMD = currentTime.ToString("yyyy-M-d,HH-mm-ss");
             
            
            string picName = strMD+ "," + i + pic_format_string;
            if (picSave)
            {
                picSaveSem.WaitOne();
                try
                {
                    if (!File.Exists(picName))
                    {
                        Bitmap pic = new Bitmap(e.Image);

                        pic.Save(picName, format);
      
                        pic.Dispose();
                        i++;
                        

                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

                picSaveSem.Release();
                
            }
            

        }


        //Save function
        private void saveButton_Click(object sender, EventArgs e)
        {

            setting.WaitOne();
            if (!picSave)
            {
                picSave = true;
                saveButton.Text = "Stop";
                picSaveSem.Release();
            }
            else { picSave = false; saveButton.Text = "Save"; picSaveSem.WaitOne(); }

            setting.Release();
        }

        private void gobalShutter_CheckedChanged(object sender, EventArgs e)
        {
            
            rollShutter.Checked = false;
            if (_camera != null && _camera.IsConnected)
                _camera.ShutterMode = Camera.ShutterModes.Global;
            else gobalShutter.Checked = false;
            
        }

        private void rollShutter_CheckedChanged(object sender, EventArgs e)
        {
            
            gobalShutter.Checked = false;
            if (_camera != null && _camera.IsConnected)
                _camera.ShutterMode = Camera.ShutterModes.Rolling;
            else rollShutter.Checked = false;
            
        }

        private void frameRate_ValueChanged(object sender, EventArgs e)
        {
            int fps = (int)frameRate.Value;
            
            if (_camera != null && _camera.IsConnected)
            { 
                _camera.RollingFrameRate = fps;
                rollShutter.Checked = true;
                _camera.ShutterMode = Camera.ShutterModes.Rolling;
            }
            
        }

        private void pixelDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (pixelDepth.Text == "8 bits")
                if (_camera != null && _camera.IsConnected)
                    _camera.PixelDepth = Camera.PixelDepths.Bpp8;
            if (pixelDepth.Text == "12 bits")
                if (_camera != null && _camera.IsConnected)
                    _camera.PixelDepth = Camera.PixelDepths.Bpp12;
            
        }

        private void triggerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (pixelDepth.Text == "自由运行")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.FreeRunning;
            if (pixelDepth.Text == "固定曝光")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.FixedExposure;
            if (pixelDepth.Text == "脉冲曝光")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.PulseWidthExposure;
            
        }

        private void aoiSet_Click(object sender, EventArgs e)
        {
            
            if (_camera != null && _camera.IsConnected)
            {
               _camera.AOI = new Rectangle((int)aoiLeft.Value, (int)aoiTop.Value, (int)aoiRight.Value - (int)aoiLeft.Value, (int)aoiBottom.Value - (int)aoiTop.Value);

            }
            
        }

        private void aoiReset_Click(object sender, EventArgs e)
        {
            
            if (_camera != null && _camera.IsConnected)
            {
                _camera.AOI = new Rectangle(0,0,1280,1024);
                aoiLeft.Value = 0;
                aoiTop.Value = 0;
                aoiRight.Value = 1280;
                aoiBottom.Value = 1024;
            }
            
        }

        private void picFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picFormat.Text == "bmp")
            { 
                pic_format_string = ".bmp"; 
                format = System.Drawing.Imaging.ImageFormat.Bmp;
          
            }
            if (picFormat.Text == "jpg")
            { pic_format_string = ".jpg"; format = System.Drawing.Imaging.ImageFormat.Jpeg; }
            if (picFormat.Text == "png")
            { pic_format_string = ".png"; format = System.Drawing.Imaging.ImageFormat.Png; }
            if (picFormat.Text == "gif")
            { pic_format_string = ".gif"; format = System.Drawing.Imaging.ImageFormat.Gif; }
        }

       



    }
}

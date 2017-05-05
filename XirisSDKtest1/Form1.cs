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

                try
                {
                    cameraReady.Text = "camera ready";
                    frameRate.Value = (decimal)_camera.RollingFrameRate;

                    if (_camera.PixelDepth == Camera.PixelDepths.Bpp8)
                        pixelDepth.Text = "8 bits";
                    if (_camera.PixelDepth == Camera.PixelDepths.Bpp12)
                        pixelDepth.Text = "12 bits";
                
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }






            }
        }
        void _camera_BufferReady(object sender, CameraBufferReadyEventArgs e)
        {
            pictureBox1.Image = e.Image;
            saveButton.Click += saveButton_Click;



            /*switch (calculator % 300)
            {
                case 0: if (File.Exists("1.bmp")) { File.Delete("1.bmp"); e.Image.Dispose(); break; } e.Image.Save("1.bmp", System.Drawing.Imaging.ImageFormat.Bmp); calculator = 0; break;
                case 100: if (File.Exists("2.bmp")) { File.Delete("2.bmp"); e.Image.Dispose(); break; } e.Image.Save("2.bmp", System.Drawing.Imaging.ImageFormat.Bmp); break;
                case 200: if (File.Exists("3.bmp")) { File.Delete("3.bmp"); e.Image.Dispose(); break; } e.Image.Save("3.bmp", System.Drawing.Imaging.ImageFormat.Bmp); break;
               // e.Buffer.
            }
            * 
             */
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            string strMD = currentTime.ToString("yyyy-M-d,HH-mm-ss");
             
            
            string picName = strMD+ "," + i + ".bmp";
            if (picSave)
            {
                picSaveSem.WaitOne();
                try
                {
                    if (!File.Exists(picName))
                    {
                        Bitmap pic = new Bitmap(e.Image);
                        pic.Save(picName, System.Drawing.Imaging.ImageFormat.Bmp);
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

            if (!picSave)
            {
                picSave = true;
                picSaveSem.Release();
                saveButton.Text = "Stop";
            }
            else { picSave = false; saveButton.Text = "Save"; picSaveSem.WaitOne(); }
        }

        private void gobalShutter_CheckedChanged(object sender, EventArgs e)
        {
            setting.WaitOne();
            rollShutter.Checked = false;
            if (_camera != null && _camera.IsConnected)
                _camera.ShutterMode = Camera.ShutterModes.Global;
            else gobalShutter.Checked = false;
            setting.Release();
        }

        private void rollShutter_CheckedChanged(object sender, EventArgs e)
        {
            setting.WaitOne();
            gobalShutter.Checked = false;
            if (_camera != null && _camera.IsConnected)
                _camera.ShutterMode = Camera.ShutterModes.Rolling;
            else rollShutter.Checked = false;
            setting.Release();
        }

        private void frameRate_ValueChanged(object sender, EventArgs e)
        {
            int fps = (int)frameRate.Value;
            setting.WaitOne();
            if (_camera != null && _camera.IsConnected)
            { 
                _camera.RollingFrameRate = fps;
                rollShutter.Checked = true;
                _camera.ShutterMode = Camera.ShutterModes.Rolling;
            }
            setting.Release();
        }

        private void pixelDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            setting.WaitOne();
            if (pixelDepth.Text == "8 bits")
                if (_camera != null && _camera.IsConnected)
                    _camera.PixelDepth = Camera.PixelDepths.Bpp8;
            if (pixelDepth.Text == "12 bits")
                if (_camera != null && _camera.IsConnected)
                    _camera.PixelDepth = Camera.PixelDepths.Bpp12;
            setting.Release();
        }

        private void triggerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            setting.WaitOne();
            if (pixelDepth.Text == "自由运行")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.FreeRunning;
            if (pixelDepth.Text == "固定曝光")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.FixedExposure;
            if (pixelDepth.Text == "脉冲曝光")
                if (_camera != null && _camera.IsConnected)
                    _camera.TriggerMode = Camera.TriggerModes.PulseWidthExposure;
            setting.Release();
        }

        private void aoiSet_Click(object sender, EventArgs e)
        {
            setting.WaitOne();
            if (_camera != null && _camera.IsConnected)
            {
               _camera.AOI = new Rectangle((int)aoiLeft.Value, (int)aoiTop.Value, (int)aoiRight.Value - (int)aoiLeft.Value, (int)aoiBottom.Value - (int)aoiTop.Value);

            }
            setting.Release();
        }

        private void aoiReset_Click(object sender, EventArgs e)
        {
            setting.WaitOne();
            if (_camera != null && _camera.IsConnected)
            {
                _camera.AOI = new Rectangle(0,0,1280,1024);
                aoiLeft.Value = 0;
                aoiTop.Value = 0;
                aoiRight.Value = 1280;
                aoiBottom.Value = 1024;
            }
            setting.Release();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Kütüphane_Otomasyon_Programı.Properties;

namespace Kütüphane_Programı
{
    public partial class CameraBarcodeReader : Form
    {
        FilterInfoCollection filterInfoCollection;
        public VideoCaptureDevice videoCaptureDevice;

        AddBook main;
        GiveBook giveBookForm;
        public CameraBarcodeReader(AddBook m)
        {
            InitializeComponent();
            main = m;
        }
        public CameraBarcodeReader(GiveBook m)
        {
            InitializeComponent();
            giveBookForm = m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo info in filterInfoCollection)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                try
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.beep);
                        player.Play();
                        if(main != null)
                        {
                            if (main.checkBox1.Checked)
                            {
                                Book book = GetBookInfo.BookInfo(result.ToString());
                                main.GetValuesFromBarcodeReaders(book);
                            }
                            else
                            {
                                Book book = new Book();
                                book.ISBN = result.ToString();
                                main.GetValuesFromBarcodeReaders(book);
                            }
                        }
                        else if(giveBookForm != null)
                        {
                            giveBookForm.isbnTextBox.Text = result.ToString();
                            this.Dispose();
                            if (videoCaptureDevice != null)
                            {
                                if (videoCaptureDevice.IsRunning)
                                {
                                    videoCaptureDevice.SignalToStop();
                                }
                            }
                            this.Close();
                        }
                    }
                    ));
                }
                catch
                {
                    MessageBox.Show("Veritabanından veri çekerken bir sorun oluştu");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }
    }
}

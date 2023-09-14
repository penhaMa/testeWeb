using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;

namespace testeWeb
{
    public partial class WebCam : Form
    {
        FilterInfoCollection filtro;
        VideoCaptureDevice video;
        public WebCam()
        {
            InitializeComponent();

            filtro = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filtro)
                camera.Items.Add(filterInfo.Name);

            camera.SelectedIndex = 0;
            video = new VideoCaptureDevice();
        }

        private void WebCam_Load(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            video = new VideoCaptureDevice(filtro[camera.SelectedIndex].MonikerString);

            video.NewFrame += video_Newframe;
            video.Start();
        }

        private void video_Newframe(object sender, NewFrameEventArgs e)
        {
            imagem.Image = (Bitmap)e.Frame.Clone();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(imagem.Image);
            recorte.Image = Clipboard.GetImage();
            Clipboard.Clear();

            recorte.Image.Save(@"C:\Users\penha\Desktop\imagem\imagem.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void encerrar_Click(object sender, EventArgs e)
        {
            Encerrar();
        }

        private void WebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Encerrar();
        }

        private void Encerrar()
        {
            if (!(video == null))
                if (video.IsRunning)
                {
                    video.NewFrame -= video_Newframe;
                    video.SignalToStop();
                    video = null;
                }
        }
    }
}

//23-Dec-2011,Varun,Image capturing
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using NSGVisitorManagement.Classes;


namespace NSGVisitorManagement.Forms
{
    public partial class frmCapturePhoto : Form
    {

        WebCamera oWebCam;
        private string registryNo;
        public delegate void PhotoCaptured(Image oImage);

        public frmCapturePhoto(string skillRegistryNo)
        {
            InitializeComponent();
            registryNo = skillRegistryNo;
        }

        //Creating Instance of WebCam Class.
        private void CapturePhoto_Load(object sender, EventArgs e)
        {
            oWebCam = new WebCamera();
            oWebCam.Container = pictureBox1;
            oWebCam.OpenConnection();
            Clipboard.Clear();
        }
        // Event For Saving Captured Data
        private void btnCapture_Click(object sender, EventArgs e)
        {
            GlobalClass.VisitorImage = oWebCam.SaveImage();//(registryNo);
            if (oWebCam != null)
            {
                oWebCam.CloseConnection();
                oWebCam = null;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (oWebCam != null)
            {
                oWebCam.CloseConnection();
                oWebCam = null;
            }
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            oWebCam.CloseConnection();
            oWebCam.Dispose();
            oWebCam = new WebCamera();
            oWebCam.Container = pictureBox1;
            oWebCam.OpenConnection();
            Clipboard.Clear();
        }

    }
}

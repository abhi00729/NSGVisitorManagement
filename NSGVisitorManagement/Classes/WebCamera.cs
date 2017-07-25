//23-Dec-2011,Varun,Image capturing into picturebox 
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace NSGVisitorManagement.Classes
{
    class WebCamera
    {
        //Vivek Verma 21-Dec-2011
        //Local Variables for accessing capGetDriverDescriptionA(),capCreateCaptureWindowA(),SendMessage functions.
        private const short WM_CAP = 0x400;
        private const int WM_CAP_DRIVER_CONNECT = 0x40a;
        private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
        private const int WM_CAP_EDIT_COPY = 0x41e;
        private const int WM_CAP_SET_PREVIEW = 0x432;
        private const int WM_CAP_SET_OVERLAY = 0x433;
        private const int WM_CAP_SET_PREVIEWRATE = 0x434;
        private const int WM_CAP_SET_SCALE = 0x435;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const short SWP_NOMOVE = 0x2;
        private short SWP_NOZORDER = 0x4;
        private short HWND_BOTTOM = 1;

        //Vivek Verma 21-Dec-2011
        //Importing Win Dlls for acessing avicap32.dll for capturing Image from WebCam.
        [DllImport("avicap32.dll")]
        protected static extern bool capGetDriverDescriptionA(short wDriverIndex,
            [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName,
           int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);
        [DllImport("avicap32.dll")]
        protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName,
            int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);
        [DllImport("user32")]
        protected static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32", EntryPoint = "SendMessageA")]
        protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);
        [DllImport("user32")]
        protected static extern bool DestroyWindow(int hwnd);
        int DeviceID = 0;
        int hHwnd = 0;
        ArrayList ListOfDevices = new ArrayList();
        public PictureBox Container { get; set; }

        //Vivek Verma 21-Dec-2011
        //First Time Initalisation of Container and Device
        public void Load()
        {
            string Name = String.Empty.PadRight(100);
            string Version = String.Empty.PadRight(100);
            bool EndOfDeviceList = false;
            short index = 0;

            do
            {
                EndOfDeviceList = capGetDriverDescriptionA(index, ref Name, 100, ref Version, 100);
                if (EndOfDeviceList) ListOfDevices.Add(Name.Trim());
                index += 1;
            }
            while (!(EndOfDeviceList == false));
        }

        //Vivek Verma 21-Dec-2011
        //Opening Connection For capturing image from Webcam
        public void OpenConnection()
        {
            CloseConnection();

            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, DeviceID, 0) != 0)
            {
                return;
            }
            string DeviceIndex = Convert.ToString(DeviceID);
            IntPtr oHandle = Container.Handle;

            hHwnd = capCreateCaptureWindowA(ref DeviceIndex, WS_VISIBLE | WS_CHILD, 0, 0, Container.Height, Container.Width, oHandle.ToInt32(), 0);
            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, DeviceID, 0) != 0)
            {
                SendMessage(hHwnd, WM_CAP_SET_SCALE, -1, 0);
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0);
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, -1, 0);
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, Container.Width, Container.Height, SWP_NOMOVE | SWP_NOZORDER);
            }
            else
            {
                DestroyWindow(hHwnd);
            }
        }

        //Vivek Verma 21-Dec-2011
        //For Closing Connection with the Driver
        public void CloseConnection()
        {
            SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, DeviceID, 0);
            DestroyWindow(hHwnd);
        }

        //Vivek Verma 21-Dec-2011
        //For Saving Captured image Data into File.
        public Image SaveImage()//(string skillregistryNo)
        {
            IDataObject data;
            Image oImage = null;

            //String dirChar = Path.GetTempPath();
            //string dir = dirChar + "TempCapture";

            //if (!Directory.Exists(dir))
            //{
            //    Directory.CreateDirectory(dir);
            //}
            //string fileName = dir + @"\" + skillregistryNo + ".Jpg";

            //if (File.Exists(fileName))
            //{
            //    File.Delete(fileName);
            //}

            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0);
            data = Clipboard.GetDataObject();
            if (data.GetDataPresent(typeof(System.Drawing.Bitmap)))
            {
                oImage = (Image)data.GetData(typeof(System.Drawing.Bitmap));
                Container.Image = oImage;
                //oImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            Clipboard.Clear();
            data = null;
            return oImage;
        }

        #region IDisposable Members
        public void Dispose()
        {
            CloseConnection();
        }
        #endregion

    }
}

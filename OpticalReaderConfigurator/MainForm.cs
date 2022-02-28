using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace OpticalReaderConfigurator
{
    public partial class MainForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private PhotoSettings photoForm = new PhotoSettings();
        private NetworkSettings networkSettingsForm = new NetworkSettings();
        private Connection connectionForm = new Connection();

        public MainForm()
        {
            InitializeComponent();
        }

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(fh);
            this.panelContent.Tag = fh;
            fh.Show();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(connectionForm);
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(photoForm);
        }

        private void buttonWanSettings_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(networkSettingsForm);
        }
    }
}

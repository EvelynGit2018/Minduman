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
using WindowsViews.Views;

namespace WindowsViews.Views
{
    public partial class GestionarVehiculos : Form
    {
        public GestionarVehiculos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 352)
            {
                MenuVertical.Width = 84;
            }
            else
            {
                MenuVertical.Width = 352;
            }
            FlechaDerecha.Visible = true;
            FlechaIzq.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirLogeoMaquinasInPanel(object Formhijo)
        {
            try
            {
                if (this.panelContenedor.Controls.Count > 0)
                    this.panelContenedor.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void FlechaIzq_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 84)
            {
                MenuVertical.Width = 352;
            }
            else
            {
                MenuVertical.Width = 84;
            }
            FlechaDerecha.Visible = true;
            FlechaIzq.Visible = false;
        }

        private void IcoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IcoRestaurar.Visible = false;
            IcoMaximizar.Visible = true;
        }

        private void IcoMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IcoRestaurar.Visible = true;
            IcoMaximizar.Visible = false;
        }

        private void IcoMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IcoCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlechaDerecha_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 84)
            {
                MenuVertical.Width = 352;
            }
            else
            {
                MenuVertical.Width = 84;
            }
            FlechaDerecha.Visible = false;
            FlechaIzq.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new MenuVehiculos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new IngresoVehiculos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirLogeoMaquinasInPanel(new ListadoVehiculos());
        }
    }
}

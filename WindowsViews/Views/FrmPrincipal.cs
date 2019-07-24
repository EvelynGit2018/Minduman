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

namespace WindowsViews.Views
{
    public partial class FrmPrincipal : Form
    {
        public string TipoAcceso { get; set; }
        public string AccesoActual { get; set; }
        public string AccesoBloqueo { get; set; }
        public int TipoAccesoUsuario { get; set; }

        bool Opt1Open = false;
        int LevelSeparation = 65;
        int SubMenuSeparation = 10;
        int PosMenu1X = 19;
        int PosMenu1Y = 96;
        int PosMenu2X = 19;
        int PosMenu2Y = 161;
        int PosMenu3X = 19;
        int PosMenu3Y = 226;

        

        public FrmPrincipal()
        {
            InitializeComponent();
            IniciarMenuPrincipal();
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

        private void IniciarMenuPrincipal()
        {
            pnlGT.Visible = false;
            pnlGM.Visible = false;
            pnlGV.Visible = false;
            btnGT.Visible = false;
            btnGM.Visible = false;
            btnGV.Visible = false;

        }
        public void ConfigurarMenuAcceso()
        {
            switch (TipoAcceso)
            {
                case "PRODUCCION":
                    Opt1Open = true;
                    AbrirSubMenuP(2);//MAQUINARIAS
                    //MenuAccesoVentas();
                    break;
                case "MANTENCION":
                    Opt1Open = true;
                    AbrirSubMenuP(3);//VEHÍCULOS
                    //MenuAccesoAdmin();
                    break;
                case "AUTOMATIZACION":
                    Opt1Open = true;
                    AbrirSubMenuP(1); // TRANSPORTADORES
                    //MenuAccesoAdmin();
                    break;
                case "INFORMATICA": //TODOS LOS MODULOS
                    //Opt1Open = true;
                    AbrirSubMenuP(0);
                    //MenuAccesoAdmin();
                    break;
            }

            if (AccesoBloqueo != AccesoActual)
            {
                List<Form> lform = new List<Form>();

                foreach (Form OpenForm in Application.OpenForms)
                {
                    if (OpenForm.Name != "FrmPrincipal")
                        lform.Add(OpenForm);
                }

                foreach (Form f in lform)
                {
                    f.Close();
                }
            }

            PosicionMenuAcceso(Convert.ToInt32(TipoAcceso.Trim())); // Aca se pasa la variable con el numero de TipoAcceso en este caso 0 como prueba Admin..
            
        }

        private void PosicionMenuAcceso(int TipoAcceso)
        {
            switch (TipoAcceso)  // Aca se definene las posiciones del menu segun los qcuaes opcioesa a erl uuario segun el TipoAcceso
            {
                case 0: // Acceso tipo Admin
                    btnGT.Visible = true;
                    btnGM.Visible = true;
                    btnGV.Visible = true;
                    btnGT.Location = new Point(PosMenu1X, PosMenu1Y);
                    btnGM.Location = new Point(PosMenu2X, PosMenu2Y);
                    btnGV.Location = new Point(PosMenu3X, PosMenu3Y);
                    break;
                case 1: // Ejem Acceso solo opcion Transportadores
                    btnGT.Visible = true;
                    btnGM.Visible = false;
                    btnGV.Visible = false;
                    btnGT.Location = new Point(PosMenu1X, PosMenu1Y);
                    break;
                case 2: // Ejem Acceso solo opcion Maquinarias
                    btnGT.Visible = false;
                    btnGM.Visible = true;
                    btnGV.Visible = false;
                    btnGM.Location = new Point(PosMenu1X, PosMenu1Y);
                    break;
                case 3: // Ejem Acceso solo opcion Vehículo
                    btnGT.Visible = false;
                    btnGM.Visible = false;
                    btnGV.Visible = true;
                    //btnGT.Location = new Point(PosMenu1X, PosMenu1Y);
                    //btnGM.Location = new Point(PosMenu2X, PosMenu2Y);
                    btnGV.Location = new Point(PosMenu1X, PosMenu1Y);
                    break;
            }
        }

        private void AbrirSubMenuP(int Nivel)
        {
            switch (Nivel)
            {
                case 1: // Opcion Trasportadores
                    if (pnlGT.Visible)
                    {
                        pnlGT.Visible = false;
                        if (btnGM.Visible)  // Posicion Opcion Maquinaria
                            PosicionarMenuMaquinaria();
                        if (btnGV.Visible) // Posicion Opcion Vehiculos
                            PosicionarMenuVehiculos();
                    }
                    else
                    {
                        pnlGT.Visible = true;
                        pnlGT.Top = btnGT.Top + btnGT.Height + SubMenuSeparation;

                        if (btnGM.Visible)  // Posicion Opcion Maquinaria
                            PosicionarMenuMaquinaria();
                        if (btnGV.Visible) // Posicion Opcion Vehiculos
                            PosicionarMenuVehiculos();
                    }
                    break;
                case 2: // Opcion Maquinarias
                    if (pnlGM.Visible)
                    {
                        pnlGM.Visible = false;
                        if (btnGV.Visible) // Posicion Opcion Vehiculos
                            PosicionarMenuVehiculos();
                    }
                    else
                    {
                        pnlGM.Visible = true;
                        pnlGM.Top = btnGM.Top + btnGM.Height + SubMenuSeparation;

                        if (btnGV.Visible) // Posicion Opcion Vehiculos
                            PosicionarMenuVehiculos();
                    }
                    break;
                case 3: // Opcion Vehiculos
                    if (pnlGV.Visible)
                    {
                        pnlGV.Visible = false;
                    }
                    else
                    {
                        pnlGV.Visible = true;
                        pnlGV.Top = btnGV.Top + btnGV.Height + SubMenuSeparation;
                    }
                    break;

            }

        }

        private void PosicionarMenuVehiculos()
        {
            if (pnlGM.Visible)
                btnGV.Top = pnlGM.Top + pnlGM.Height + SubMenuSeparation;
            else
                btnGV.Top = btnGM.Top + LevelSeparation;

            if (pnlGV.Visible)
                pnlGV.Top = btnGV.Top + btnGV.Height + SubMenuSeparation;
        }

        private void PosicionarMenuMaquinaria()
        {
            if (pnlGT.Visible)
                btnGM.Top = pnlGT.Top + pnlGT.Height + SubMenuSeparation;
            else
                btnGM.Top = btnGT.Top + LevelSeparation;

            if (pnlGM.Visible)
                pnlGM.Top = btnGM.Top + btnGM.Height + SubMenuSeparation;
        }

        private void AbrirSubMenu(int iNivel)
        {
            switch (iNivel)
            {
                case 1:
                    if (!Opt1Open)
                    {
                        tmrMostrarMenu.Enabled = true;
                        pnlGT.Location = new Point(30, 157);
                        btnGM.Top = pnlGT.Top + pnlGT.Height;

                        pnlGM.Location = new Point(60, 320);
                        btnGV.Top = pnlGM.Top + pnlGT.Height;

                        pnlGV.Location = new Point(120, 640);
                        // pnlGV.Top = pnlGV.Top + pnlGM.Height;
                        // btnGM.Top = pnlGT.Top + pnlGT.Height;
                        //btnGM.Top = btnGM.Top + Level1Separation;
                        //pnlGM.Top = bntG




                        ////btnGlosario.Location = new Point(20, 215); //PRUEBA BOTON GLOSARIO
                        //btnGlosario.Top = btnGV.Top + Level1Separation; //SEPARACION AUTOMÁTICA
                        //panel17.Top = btnGlosario.Top;
                        pnlGT.Visible = true;
                        pnlGM.Visible = true;
                        pnlGV.Visible = true;
                        Opt1Open = true;
                    }

                    else
                    {
                        pnlGT.Visible = false;

                        //btnGlosario.Top = btnGV.Top + Level1Separation;//SEPARACION AUTOMÁTICA
                        //panel17.Top = btnGlosario.Top;

                        Opt1Open = false;
                    }
                    break;
            }

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IcoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IcoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IcoRestaurar.Visible = true;
            IcoMaximizar.Visible = false;
        }

        private void IcRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IcoRestaurar.Visible = false;
            IcoMaximizar.Visible = true;
        }

        private void IcoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        //private void BtnGestionMaquinas_Click(object sender, EventArgs e)
        //{

        //    AbrirLogeoMaquinasInPanel(new Login());
        //}

        //private void BtnGestionVehiculos_Click(object sender, EventArgs e)
        //{
        //    AbrirLogeoMaquinasInPanel(new Login());
        //}

        //private void BtnGestionTrasportadores_Click(object sender, EventArgs e)
        //{
        //    AbrirLogeoMaquinasInPanel(new Login());
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    AbrirLogeoMaquinasInPanel(new MenuTrasportadores());
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    AbrirLogeoMaquinasInPanel(new IngresoTrasportadores());
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    AbrirLogeoMaquinasInPanel(new ListadoTrasportadores());
        //}

        private void FlechaIzq_Click(object sender, EventArgs e)
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

        private void FlechaDerecha_Click_1(object sender, EventArgs e)
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

        private void IcoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IcoRestaurar.Visible = false;
            IcoMaximizar.Visible = true;
        }

        private void IcoMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IcoMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IcoRestaurar.Visible = true;
            IcoMaximizar.Visible = false;
        }

        private void IcoCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGT_Click(object sender, EventArgs e)
        {
            if (TipoAcceso != "PRODUCCION")
                
            AbrirSubMenuP(1);
        }

        private void btnGM_Click(object sender, EventArgs e)
        {
            if (TipoAcceso != "PRODUCCION")
               
            AbrirSubMenuP(2);
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            if (TipoAcceso != "MANTENCION")
               
            AbrirSubMenuP(3);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Login formLogin = new Login();
            formLogin.ShowDialog(); //Con ShowDialog hacemos la pantalla modal
        }
    }
}

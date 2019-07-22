using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsViews.Views;
using BusinessLayer;
using Entities;

namespace WindowsViews
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnGestionMaquinas_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private bool VerificarCampos()
        {
            bool Valido = true;
            if (txtUsser.Text.Trim().Length == 0)
                Valido = false;
            else if (txtUsser.Text.Trim().Length == 0)
                Valido = false;
            return Valido;
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //FrmPrincipal Menu = new FrmPrincipal();
           // Menu.TipoAccesoUsuario = 0; // Aca debes colocar el numero corresponciente al tipo de acceso una vez validado el usuario y ubicado el tipo de permiso
                                        // Fijate como esta en MinduAutomatizacion

            if (VerificarCampos())
            {
                DataTable dtUserInfo = UsuarioBL.VerificarRutPass(txtUsser.Text.Trim(), txtPass.Text.Trim());
                FrmPrincipal Menu = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];

                //FrmReportesGrid frmReportesG = (FrmReportesGrid)Application.OpenForms["FrmReportesGrid"];

                if (dtUserInfo.Rows.Count > 0) // Verificacion de RUT
                {
                    if (dtUserInfo.Rows[0].Field<string>("Acceso") == "Y") // Verificacion de Pass correcto
                    {
                        switch (dtUserInfo.Rows[0].Field<int>("IdArea"))
                        {
                            case 1: // Verificacion del Acceso 1 Produccion
                                
                                Usuario.Instance().rutUsuario = dtUserInfo.Rows[0].Field<string>("rutUsuario");
                                Usuario.Instance().Nombre = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().Apellido = dtUserInfo.Rows[0].Field<string>("Apellido");
                                Usuario.Instance().Area = dtUserInfo.Rows[0].Field<string>("Area");
                                Usuario.Instance().Usser = dtUserInfo.Rows[0].Field<string>("Usser");
                                Usuario.Instance().Pass = dtUserInfo.Rows[0].Field<string>("Pass");
                                Usuario.Instance().idTipo = dtUserInfo.Rows[0].Field<int>("idTipo");
                                Usuario.Instance().idArea = dtUserInfo.Rows[0].Field<int>("idArea");
                                Usuario.Instance().Correo = dtUserInfo.Rows[0].Field<string>("Correo");
                               // Menu.AsignarNombreUsuario(Usuario.Instance().Usser); //ASIGNAR NOMBRE DE USUARIO EN SESION EN FRMPRINCIPAL
                                Menu.TipoAcceso = "PRODUCCION";
                                Menu.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdArea").ToString();
                                Menu.ConfigurarMenuAcceso();


                                //frmReportesG.AsignarNombreUsuario(Usuario.Instance().UserName);
                                //frmReportesG.TipoAcceso = "ADMIN";
                                //frmReportesG.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                //frmReportesG.ConfigurarListaAcceso();
                                //ClosedFadeOutAsync();
                                break;
                            default:
                            case 2: // Verificacion del Acceso 2 Mantencion
                                Usuario.Instance().rutUsuario = dtUserInfo.Rows[0].Field<string>("rutUsuario");
                                Usuario.Instance().Nombre = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().Apellido = dtUserInfo.Rows[0].Field<string>("Apellido");
                                Usuario.Instance().Area = dtUserInfo.Rows[0].Field<string>("Area");
                                Usuario.Instance().Usser = dtUserInfo.Rows[0].Field<string>("Usser");
                                Usuario.Instance().Pass = dtUserInfo.Rows[0].Field<string>("Pass");
                                Usuario.Instance().idTipo = dtUserInfo.Rows[0].Field<int>("idTipo");
                                Usuario.Instance().idArea = dtUserInfo.Rows[0].Field<int>("idArea");
                                Usuario.Instance().Correo = dtUserInfo.Rows[0].Field<string>("Correo");
                                //frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                Menu.TipoAcceso = "MANTENCION";
                                Menu.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdArea").ToString();
                                Menu.ConfigurarMenuAcceso();

                                //frmReportesG.AsignarNombreUsuario(Usuario.Instance().UserName);
                                //frmReportesG.TipoAcceso = "LECTURA";
                                //frmReportesG.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                //frmReportesG.ConfigurarListaAcceso();
                                //ClosedFadeOutAsync();
                                break;
                            case 3: // Verificacion del Acceso 3 Automatización
                                Usuario.Instance().rutUsuario = dtUserInfo.Rows[0].Field<string>("rutUsuario");
                                Usuario.Instance().Nombre = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().Apellido = dtUserInfo.Rows[0].Field<string>("Apellido");
                                Usuario.Instance().Area = dtUserInfo.Rows[0].Field<string>("Area");
                                Usuario.Instance().Usser = dtUserInfo.Rows[0].Field<string>("Usser");
                                Usuario.Instance().Pass = dtUserInfo.Rows[0].Field<string>("Pass");
                                Usuario.Instance().idTipo = dtUserInfo.Rows[0].Field<int>("idTipo");
                                Usuario.Instance().idArea = dtUserInfo.Rows[0].Field<int>("idArea");
                                Usuario.Instance().Correo = dtUserInfo.Rows[0].Field<string>("Correo");
                                //frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                Menu.TipoAcceso = "AUTOMATIZACION";
                                Menu.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdArea").ToString();
                                Menu.ConfigurarMenuAcceso();

                                //frmReportesG.AsignarNombreUsuario(Usuario.Instance().UserName);
                                //frmReportesG.TipoAcceso = "VENTAS";
                                //frmReportesG.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                //frmReportesG.ConfigurarListaAcceso();
                               // ClosedFadeOutAsync();
                                break;
                                
                            case 4: // Verificacion del Acceso 4Total informáticos
                                Usuario.Instance().rutUsuario = dtUserInfo.Rows[0].Field<string>("rutUsuario");
                                Usuario.Instance().Nombre = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().Apellido = dtUserInfo.Rows[0].Field<string>("Apellido");
                                Usuario.Instance().Area = dtUserInfo.Rows[0].Field<string>("Area");
                                Usuario.Instance().Usser = dtUserInfo.Rows[0].Field<string>("Usser");
                                Usuario.Instance().Pass = dtUserInfo.Rows[0].Field<string>("Pass");
                                Usuario.Instance().idTipo = dtUserInfo.Rows[0].Field<int>("idTipo");
                                Usuario.Instance().idArea = dtUserInfo.Rows[0].Field<int>("idArea");
                                Usuario.Instance().Correo = dtUserInfo.Rows[0].Field<string>("Correo");
                                //frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                Menu.TipoAcceso = "INFORMATICA";
                                Menu.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdArea").ToString();
                                Menu.ConfigurarMenuAcceso();

                                //frmReportesG.AsignarNombreUsuario(Usuario.Instance().UserName);
                                //frmReportesG.TipoAcceso = "VENTAS";
                                //frmReportesG.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                //frmReportesG.ConfigurarListaAcceso();
                                //ClosedFadeOutAsync();
                                break;
                                //MetroMessageBox.Show(frmParentForm, "No Posee la Autorizacion en MinduMas para Acceder al Sistema",
                                //          "Acceso No Habilitado",
                                //          MessageBoxButtons.OK,
                                //          MessageBoxIcon.Information,
                                //          370);
                                break;
                        }
                    }
                    else
                    {
                        
                        //MetroFramework.MetroMessageBox.Show(frmParentForm, "La Contraseña no Coincide",
                        //                    "Contraseña Incorrecta",
                        //                    MessageBoxButtons.OK,
                        //                    MessageBoxIcon.Information,
                        //                    370);
                        //TxtBx_Password.Focus();
                        
                    }
                }
                else
                {
                    //MetroFramework.MetroMessageBox.Show(frmParentForm, "Numero de RUT No Registrado en la Base de Datos",
                    //                            "RUT Sin Coincidencia",
                    //                            MessageBoxButtons.OK,
                    //                            MessageBoxIcon.Information,
                    //                            370);
                    //TxtBx_UserID.Focus();
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Login
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void validar_funcionalidades_disp()
        {

            List<Datos.Funcionalidad> funcionalidades_permitidas = App.currentRol.getFuncionalidades();
            deshabilitar_todos_botones();
            foreach (Datos.Funcionalidad funcionalidad in funcionalidades_permitidas)
            {
                switch(funcionalidad.nombre){
                    
                    case "ABM de Rol":
                        ABMRol_Button.Enabled = true;
                        ABMRol_Button.Visible = true;
                        break;
                    case "ABM de Cliente":
                        ABMCliente_Button.Enabled = true;
                        ABMCliente_Button.Visible = true;
                        break;
                    case "ABM de Empresa de espectaculos":
                        ABMEmpresaEspec_Button.Enabled = true;
                        ABMEmpresaEspec_Button.Visible = true;
                        break;
                    case "ABM grado de publicacion":
                        ABMGradoPubli_Button.Enabled = true;
                        ABMGradoPubli_Button.Visible = true;
                        break;
                    case "Canje y administración de puntos":
                        AdminPuntos_Button.Enabled = true;
                        AdminPuntos_Button.Visible = true;
                        break;
                    case "Comprar":
                        Comprar_Button.Enabled = true;
                        Comprar_Button.Visible = true;
                        break;
                    case "Editar Publicacion":
                        EditarPubli_Button.Enabled = true;
                        EditarPubli_Button.Visible = true;
                        break;
                    case "Generar Pago de comisiones":
                        PagoComisiones_Button.Enabled = true;
                        PagoComisiones_Button.Visible = true;
                        break;
                    case "Generar Publicacion":
                        GenerarPulica_Button.Enabled = true;
                        GenerarPulica_Button.Visible = true;
                        break;
                    case "Historial del cliente":
                        HistorialCli_Button.Enabled = true;
                        HistorialCli_Button.Visible = true;
                        break;
                    case "Listado Estadistico":
                        ListadoEstadistico_Button.Enabled = true;
                        ListadoEstadistico_Button.Visible = true;
                        break;
                    case "Registro de Usuario":
                        RegistroUsuario_Button.Enabled = true;
                        RegistroUsuario_Button.Visible = true;
                        break;
                }
            }


        }


        private void deshabilitar_todos_botones()
        {

            ABMCliente_Button.Enabled = false;
            ABMCliente_Button.Visible = false;
            ABMEmpresaEspec_Button.Enabled = false;
            ABMEmpresaEspec_Button.Visible = false;
            ABMGradoPubli_Button.Enabled = false;
            ABMGradoPubli_Button.Visible = false;
            ABMRol_Button.Enabled = false;
            ABMRol_Button.Visible = false;
            Comprar_Button.Enabled = false;
            Comprar_Button.Visible = false;
            HistorialCli_Button.Enabled = false;
            HistorialCli_Button.Visible = false;
            AdminPuntos_Button.Enabled = false;
            AdminPuntos_Button.Visible = false;
            GenerarPulica_Button.Enabled = false;
            GenerarPulica_Button.Visible = false;
            ListadoEstadistico_Button.Enabled = false;
            ListadoEstadistico_Button.Visible = false;
            PagoComisiones_Button.Enabled = false;
            PagoComisiones_Button.Visible = false;
            RegistroUsuario_Button.Enabled = false;
            RegistroUsuario_Button.Visible = false;
            EditarPubli_Button.Enabled = false;
            EditarPubli_Button.Visible = false;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            validar_funcionalidades_disp();
        }

        private void ABMRol_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Rol.ABMRol abm = new Abm_Rol.ABMRol();
            abm.Show();
        }

        private void ABMCategoria_Button_Click(object sender, EventArgs e)
        {
			this.Hide();
			Abm_Grado.ABMGrado abm = new Abm_Grado.ABMGrado();
			abm.Show();

		}

        private void CerrarSesion_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            App.admin.cerrar_sesion();
        }

		private void ABMGradoPubli_Button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Abm_Grado.ABMGrado abm = new Abm_Grado.ABMGrado();
			abm.Show();
		}
	}
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class Modificacion_Empresa : Form
    {
        int idEmpresa;
        string razonSocial;
        string cuit;
        string domCalle;
        string domNro;
        string domPiso;
        string domDepto;
        string ciudad;
        string codPost;
        string telefono;
        string email;
        bool habilitado;

        public Modificacion_Empresa(int valor)
        {
            InitializeComponent();
            idEmpresa = valor;
            SqlDataReader resultado = App.db.getDatosEmpresa(idEmpresa);

            if (resultado.Read())
            {
                razonSocial_textBox.Text = resultado.GetString(0);
                    this.razonSocial = razonSocial_textBox.Text;
                cuitEmpresa_textBox.Text = resultado.GetString(1);
                    this.cuit = cuitEmpresa_textBox.Text;
                domCalleEmpresa_textBox.Text = resultado.GetString(2);
                    this.domCalle = domCalleEmpresa_textBox.Text;
                domNumeroEmpresa_textBox.Text = resultado.GetDecimal(3).ToString();
                    this.domNro = domNumeroEmpresa_textBox.Text;
                domPisoEmpresa_textBox.Text = resultado.GetDecimal(4).ToString();
                    this.domPiso = domPisoEmpresa_textBox.Text;
                domDeptoEmpresa_textBox.Text = resultado.GetString(5);
                    this.domDepto = domDeptoEmpresa_textBox.Text;
                ciudadEmpresa_textBox.Text = resultado.GetString(6);
                    this.ciudad = ciudadEmpresa_textBox.Text;
                codPostEmpresa_textBox.Text = resultado.GetString(7);
                    this.codPost = codPostEmpresa_textBox.Text;
                telefonoEmpresa_textBox.Text = resultado.GetString(8);
                    this.telefono = telefonoEmpresa_textBox.Text;
                emailEmpresa_textBox.Text = resultado.GetString(9);
                    this.email = emailEmpresa_textBox.Text;
                habilitado_checkBox.Checked = (bool) resultado.GetSqlBoolean(10);
                    this.habilitado = habilitado_checkBox.Checked;
            }
        }
        
        private void Modificacion_Empresa_Load(object sender, EventArgs e)
        {
            this.habilitarEmpresa_button.Visible = !this.habilitado_checkBox.Checked;
        }

        private void habilitado_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            busquedaModificacion_Empresa bModifEmpresa = new busquedaModificacion_Empresa();
            bModifEmpresa.Show();
        }

        private void modificarEmpresa_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.razonSocial);
            List<string> camposAModificar = new List<string>();
            if (razonSocial_textBox.Text != this.razonSocial) camposAModificar.Add("empresa_razon_social = '" + razonSocial_textBox.Text + "'");
            if (cuitEmpresa_textBox.Text != this.cuit) camposAModificar.Add("empresa_cuit = '" + cuitEmpresa_textBox.Text + "'");
            if (domCalleEmpresa_textBox.Text != this.domCalle) camposAModificar.Add("empresa_domicilio_calle = '" + domCalleEmpresa_textBox.Text + "'");
            if (domNumeroEmpresa_textBox.Text != this.domNro) camposAModificar.Add("empresa_domicilio_numero = " + domNumeroEmpresa_textBox.Text);
            if (domPisoEmpresa_textBox.Text != this.domPiso) camposAModificar.Add("empresa_domicilio_piso = " + domPisoEmpresa_textBox.Text);
            if (domDeptoEmpresa_textBox.Text != this.domDepto) camposAModificar.Add("empresa_domicilio_departamento = '" + domDeptoEmpresa_textBox.Text + "'");
            if (ciudadEmpresa_textBox.Text != this.ciudad) camposAModificar.Add("empresa_ciudad = '" + ciudadEmpresa_textBox.Text + "'");
            if (codPostEmpresa_textBox.Text != this.codPost) camposAModificar.Add("empresa_codigo_postal = '" + codPostEmpresa_textBox.Text + "'");
            if (telefonoEmpresa_textBox.Text != this.telefono) camposAModificar.Add("empresa_telefono = '" + telefonoEmpresa_textBox.Text + "'");
            if (emailEmpresa_textBox.Text != this.email) camposAModificar.Add("empresa_email = '" + emailEmpresa_textBox.Text + "'");

            if (!camposAModificar.Any())
            {
                MessageBox.Show("No se modifico ningún campo");
            }

            else
            {

                int resultado = App.db.updateEmpresa(idEmpresa, camposAModificar);

                if (resultado == 1) MessageBox.Show("Empresa actualizada correctamente. ");

                this.Hide();
                busquedaModificacion_Empresa bmodifEmpresa = new busquedaModificacion_Empresa();
                bmodifEmpresa.Show();
            }
        }

        private void habilitarEmpresa_button_Click(object sender, EventArgs e)
        {
            //App.db.rehabilitarEmpresa(idEmpresa);
        }
    }
}

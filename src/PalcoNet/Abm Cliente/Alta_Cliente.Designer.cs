namespace PalcoNet.Abm_Cliente
{
    partial class Alta_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreCliente_textBox = new System.Windows.Forms.TextBox();
            this.apellidoCliente_textBox = new System.Windows.Forms.TextBox();
            this.nroDNI_textBox = new System.Windows.Forms.TextBox();
            this.tipoDNI_comboBox = new System.Windows.Forms.ComboBox();
            this.cuilCliente_textBox = new System.Windows.Forms.TextBox();
            this.fechaNacCliente_textBox = new System.Windows.Forms.TextBox();
            this.telefonoCliente_textBox = new System.Windows.Forms.TextBox();
            this.domCalleCliente_textBox = new System.Windows.Forms.TextBox();
            this.domNumeroCliente_textBox = new System.Windows.Forms.TextBox();
            this.domPisoCliente_textBox = new System.Windows.Forms.TextBox();
            this.domDeptoCliente_textBox = new System.Windows.Forms.TextBox();
            this.codPostCliente_textBox = new System.Windows.Forms.TextBox();
            this.rolCliente_comboBox = new System.Windows.Forms.ComboBox();
            this.altaUsuario_button = new System.Windows.Forms.Button();
            this.emailCliente_textBox = new System.Windows.Forms.TextBox();
            this.numeroTarjeta_textBox = new System.Windows.Forms.TextBox();
            this.vencimientoTarjeta_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombreCliente_textBox
            // 
            this.nombreCliente_textBox.Location = new System.Drawing.Point(118, 43);
            this.nombreCliente_textBox.Name = "nombreCliente_textBox";
            this.nombreCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.nombreCliente_textBox.TabIndex = 0;
            this.nombreCliente_textBox.Text = "Nombre";
            this.nombreCliente_textBox.TextChanged += new System.EventHandler(this.nombreCliente_textBox_TextChanged);
            // 
            // apellidoCliente_textBox
            // 
            this.apellidoCliente_textBox.Location = new System.Drawing.Point(12, 43);
            this.apellidoCliente_textBox.Name = "apellidoCliente_textBox";
            this.apellidoCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoCliente_textBox.TabIndex = 1;
            this.apellidoCliente_textBox.Text = "Apellido";
            this.apellidoCliente_textBox.TextChanged += new System.EventHandler(this.apellidoCliente_textBox_TextChanged);
            // 
            // nroDNI_textBox
            // 
            this.nroDNI_textBox.Location = new System.Drawing.Point(79, 97);
            this.nroDNI_textBox.Name = "nroDNI_textBox";
            this.nroDNI_textBox.Size = new System.Drawing.Size(100, 20);
            this.nroDNI_textBox.TabIndex = 2;
            this.nroDNI_textBox.Text = "Numero DNI";
            this.nroDNI_textBox.TextChanged += new System.EventHandler(this.nroDNI_textBox_TextChanged);
            // 
            // tipoDNI_comboBox
            // 
            this.tipoDNI_comboBox.FormattingEnabled = true;
            this.tipoDNI_comboBox.Items.AddRange(new object[] {
            "DNI",
            "LE"});
            this.tipoDNI_comboBox.Location = new System.Drawing.Point(12, 96);
            this.tipoDNI_comboBox.Name = "tipoDNI_comboBox";
            this.tipoDNI_comboBox.Size = new System.Drawing.Size(61, 21);
            this.tipoDNI_comboBox.TabIndex = 3;
            this.tipoDNI_comboBox.SelectedIndexChanged += new System.EventHandler(this.tipoDNI_comboBox_SelectedIndexChanged);
            // 
            // cuilCliente_textBox
            // 
            this.cuilCliente_textBox.Location = new System.Drawing.Point(12, 149);
            this.cuilCliente_textBox.Name = "cuilCliente_textBox";
            this.cuilCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.cuilCliente_textBox.TabIndex = 4;
            this.cuilCliente_textBox.Text = "CUIL";
            this.cuilCliente_textBox.TextChanged += new System.EventHandler(this.cuilCliente_textBox_TextChanged);
            // 
            // fechaNacCliente_textBox
            // 
            this.fechaNacCliente_textBox.Location = new System.Drawing.Point(12, 175);
            this.fechaNacCliente_textBox.Name = "fechaNacCliente_textBox";
            this.fechaNacCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.fechaNacCliente_textBox.TabIndex = 5;
            this.fechaNacCliente_textBox.Text = "Fecha";
            this.fechaNacCliente_textBox.TextChanged += new System.EventHandler(this.fechaNacCliente_textBox_TextChanged);
            // 
            // telefonoCliente_textBox
            // 
            this.telefonoCliente_textBox.Location = new System.Drawing.Point(12, 201);
            this.telefonoCliente_textBox.Name = "telefonoCliente_textBox";
            this.telefonoCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoCliente_textBox.TabIndex = 6;
            this.telefonoCliente_textBox.Text = "Telefono";
            this.telefonoCliente_textBox.TextChanged += new System.EventHandler(this.telefonoCliente_textBox_TextChanged);
            // 
            // domCalleCliente_textBox
            // 
            this.domCalleCliente_textBox.Location = new System.Drawing.Point(12, 227);
            this.domCalleCliente_textBox.Name = "domCalleCliente_textBox";
            this.domCalleCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.domCalleCliente_textBox.TabIndex = 7;
            this.domCalleCliente_textBox.Text = "Calle";
            this.domCalleCliente_textBox.TextChanged += new System.EventHandler(this.domCalleCliente_textBox_TextChanged);
            // 
            // domNumeroCliente_textBox
            // 
            this.domNumeroCliente_textBox.Location = new System.Drawing.Point(118, 227);
            this.domNumeroCliente_textBox.Name = "domNumeroCliente_textBox";
            this.domNumeroCliente_textBox.Size = new System.Drawing.Size(53, 20);
            this.domNumeroCliente_textBox.TabIndex = 8;
            this.domNumeroCliente_textBox.Text = "Numero";
            this.domNumeroCliente_textBox.TextChanged += new System.EventHandler(this.domNumeroCliente_textBox_TextChanged);
            // 
            // domPisoCliente_textBox
            // 
            this.domPisoCliente_textBox.Location = new System.Drawing.Point(177, 227);
            this.domPisoCliente_textBox.Name = "domPisoCliente_textBox";
            this.domPisoCliente_textBox.Size = new System.Drawing.Size(26, 20);
            this.domPisoCliente_textBox.TabIndex = 9;
            this.domPisoCliente_textBox.Text = "Piso";
            this.domPisoCliente_textBox.TextChanged += new System.EventHandler(this.domPisoCliente_textBox_TextChanged);
            // 
            // domDeptoCliente_textBox
            // 
            this.domDeptoCliente_textBox.Location = new System.Drawing.Point(209, 227);
            this.domDeptoCliente_textBox.Name = "domDeptoCliente_textBox";
            this.domDeptoCliente_textBox.Size = new System.Drawing.Size(43, 20);
            this.domDeptoCliente_textBox.TabIndex = 10;
            this.domDeptoCliente_textBox.Text = "Depto";
            this.domDeptoCliente_textBox.TextChanged += new System.EventHandler(this.domDeptoCliente_textBox_TextChanged);
            // 
            // codPostCliente_textBox
            // 
            this.codPostCliente_textBox.Location = new System.Drawing.Point(12, 253);
            this.codPostCliente_textBox.Name = "codPostCliente_textBox";
            this.codPostCliente_textBox.Size = new System.Drawing.Size(53, 20);
            this.codPostCliente_textBox.TabIndex = 11;
            this.codPostCliente_textBox.Text = "Codigo Postal";
            this.codPostCliente_textBox.TextChanged += new System.EventHandler(this.codPostCliente_textBox_TextChanged);
            // 
            // rolCliente_comboBox
            // 
            this.rolCliente_comboBox.FormattingEnabled = true;
            this.rolCliente_comboBox.Items.AddRange(new object[] {
            "DNI",
            "LE"});
            this.rolCliente_comboBox.Location = new System.Drawing.Point(12, 285);
            this.rolCliente_comboBox.Name = "rolCliente_comboBox";
            this.rolCliente_comboBox.Size = new System.Drawing.Size(61, 21);
            this.rolCliente_comboBox.TabIndex = 12;
            this.rolCliente_comboBox.SelectedIndexChanged += new System.EventHandler(this.rolCliente_comboBox_SelectedIndexChanged);
            // 
            // altaUsuario_button
            // 
            this.altaUsuario_button.Location = new System.Drawing.Point(128, 283);
            this.altaUsuario_button.Name = "altaUsuario_button";
            this.altaUsuario_button.Size = new System.Drawing.Size(75, 23);
            this.altaUsuario_button.TabIndex = 13;
            this.altaUsuario_button.Text = "Confirmar";
            this.altaUsuario_button.UseVisualStyleBackColor = true;
            this.altaUsuario_button.Click += new System.EventHandler(this.altaUsuario_button_Click);
            // 
            // emailCliente_textBox
            // 
            this.emailCliente_textBox.Location = new System.Drawing.Point(118, 201);
            this.emailCliente_textBox.Name = "emailCliente_textBox";
            this.emailCliente_textBox.Size = new System.Drawing.Size(100, 20);
            this.emailCliente_textBox.TabIndex = 14;
            this.emailCliente_textBox.Text = "email";
            this.emailCliente_textBox.TextChanged += new System.EventHandler(this.emailCliente_textBox_TextChanged);
            // 
            // numeroTarjeta_textBox
            // 
            this.numeroTarjeta_textBox.Location = new System.Drawing.Point(325, 97);
            this.numeroTarjeta_textBox.Name = "numeroTarjeta_textBox";
            this.numeroTarjeta_textBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTarjeta_textBox.TabIndex = 15;
            this.numeroTarjeta_textBox.Text = "Numero tarjeta";
            this.numeroTarjeta_textBox.TextChanged += new System.EventHandler(this.numeroTarjeta_textBox_TextChanged);
            // 
            // vencimientoTarjeta_textBox
            // 
            this.vencimientoTarjeta_textBox.Location = new System.Drawing.Point(431, 97);
            this.vencimientoTarjeta_textBox.Name = "vencimientoTarjeta_textBox";
            this.vencimientoTarjeta_textBox.Size = new System.Drawing.Size(100, 20);
            this.vencimientoTarjeta_textBox.TabIndex = 16;
            this.vencimientoTarjeta_textBox.Text = "mm/aa";
            this.vencimientoTarjeta_textBox.TextChanged += new System.EventHandler(this.vencimientoTarjeta_textBox_TextChanged);
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 318);
            this.Controls.Add(this.vencimientoTarjeta_textBox);
            this.Controls.Add(this.numeroTarjeta_textBox);
            this.Controls.Add(this.emailCliente_textBox);
            this.Controls.Add(this.altaUsuario_button);
            this.Controls.Add(this.rolCliente_comboBox);
            this.Controls.Add(this.codPostCliente_textBox);
            this.Controls.Add(this.domDeptoCliente_textBox);
            this.Controls.Add(this.domPisoCliente_textBox);
            this.Controls.Add(this.domNumeroCliente_textBox);
            this.Controls.Add(this.domCalleCliente_textBox);
            this.Controls.Add(this.telefonoCliente_textBox);
            this.Controls.Add(this.fechaNacCliente_textBox);
            this.Controls.Add(this.cuilCliente_textBox);
            this.Controls.Add(this.tipoDNI_comboBox);
            this.Controls.Add(this.nroDNI_textBox);
            this.Controls.Add(this.apellidoCliente_textBox);
            this.Controls.Add(this.nombreCliente_textBox);
            this.Name = "Alta_Cliente";
            this.Text = "Alta de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreCliente_textBox;
        private System.Windows.Forms.TextBox apellidoCliente_textBox;
        private System.Windows.Forms.TextBox nroDNI_textBox;
        private System.Windows.Forms.ComboBox tipoDNI_comboBox;
        private System.Windows.Forms.TextBox cuilCliente_textBox;
        private System.Windows.Forms.TextBox fechaNacCliente_textBox;
        private System.Windows.Forms.TextBox telefonoCliente_textBox;
        private System.Windows.Forms.TextBox domCalleCliente_textBox;
        private System.Windows.Forms.TextBox domNumeroCliente_textBox;
        private System.Windows.Forms.TextBox domPisoCliente_textBox;
        private System.Windows.Forms.TextBox domDeptoCliente_textBox;
        private System.Windows.Forms.TextBox codPostCliente_textBox;
        private System.Windows.Forms.ComboBox rolCliente_comboBox;
        private System.Windows.Forms.Button altaUsuario_button;
        private System.Windows.Forms.TextBox emailCliente_textBox;
        private System.Windows.Forms.TextBox numeroTarjeta_textBox;
        private System.Windows.Forms.TextBox vencimientoTarjeta_textBox;
    }
}
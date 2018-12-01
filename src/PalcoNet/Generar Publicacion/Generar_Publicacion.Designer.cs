namespace PalcoNet.Generar_Publicacion
{
    partial class Generar_Publicacion
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
            this.components = new System.ComponentModel.Container();
            this.SigEstado_button = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Estado_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Completar = new System.Windows.Forms.GroupBox();
            this.verubic_button = new System.Windows.Forms.Button();
            this.cantidadUbicaciones_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Grado_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Rubro_comboBox = new System.Windows.Forms.ComboBox();
            this.Direccion_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaEspec_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha_publi_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarUbi_Button = new System.Windows.Forms.Button();
            this.Generar_Button = new System.Windows.Forms.Button();
            this.Descartar_Button = new System.Windows.Forms.Button();
            this.Volver_linkLabel = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Estado.SuspendLayout();
            this.Completar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SigEstado_button
            // 
            this.SigEstado_button.Location = new System.Drawing.Point(104, 102);
            this.SigEstado_button.Name = "SigEstado_button";
            this.SigEstado_button.Size = new System.Drawing.Size(146, 38);
            this.SigEstado_button.TabIndex = 2;
            this.SigEstado_button.Text = "Siguiente Estado";
            this.SigEstado_button.UseVisualStyleBackColor = true;
            this.SigEstado_button.Click += new System.EventHandler(this.SigEstado_button_Click);
            // 
            // Estado
            // 
            this.Estado.Controls.Add(this.label1);
            this.Estado.Controls.Add(this.Estado_Textbox);
            this.Estado.Controls.Add(this.SigEstado_button);
            this.Estado.Location = new System.Drawing.Point(608, 12);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(310, 177);
            this.Estado.TabIndex = 3;
            this.Estado.TabStop = false;
            this.Estado.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actual";
            // 
            // Estado_Textbox
            // 
            this.Estado_Textbox.Enabled = false;
            this.Estado_Textbox.Location = new System.Drawing.Point(104, 49);
            this.Estado_Textbox.Name = "Estado_Textbox";
            this.Estado_Textbox.Size = new System.Drawing.Size(145, 26);
            this.Estado_Textbox.TabIndex = 1;
            this.Estado_Textbox.Text = "Borrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(194, 40);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(319, 26);
            this.Descripcion_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ubicaciones";
            // 
            // Completar
            // 
            this.Completar.Controls.Add(this.verubic_button);
            this.Completar.Controls.Add(this.cantidadUbicaciones_textbox);
            this.Completar.Controls.Add(this.label9);
            this.Completar.Controls.Add(this.Grado_comboBox);
            this.Completar.Controls.Add(this.label8);
            this.Completar.Controls.Add(this.Rubro_comboBox);
            this.Completar.Controls.Add(this.Direccion_TextBox);
            this.Completar.Controls.Add(this.label7);
            this.Completar.Controls.Add(this.label6);
            this.Completar.Controls.Add(this.FechaEspec_dateTimePicker);
            this.Completar.Controls.Add(this.label5);
            this.Completar.Controls.Add(this.Fecha_publi_TextBox);
            this.Completar.Controls.Add(this.label4);
            this.Completar.Controls.Add(this.AgregarUbi_Button);
            this.Completar.Controls.Add(this.label2);
            this.Completar.Controls.Add(this.label3);
            this.Completar.Controls.Add(this.Descripcion_textBox);
            this.Completar.Location = new System.Drawing.Point(12, 12);
            this.Completar.Name = "Completar";
            this.Completar.Size = new System.Drawing.Size(576, 488);
            this.Completar.TabIndex = 7;
            this.Completar.TabStop = false;
            this.Completar.Text = "Completar";
            // 
            // verubic_button
            // 
            this.verubic_button.Location = new System.Drawing.Point(496, 133);
            this.verubic_button.Name = "verubic_button";
            this.verubic_button.Size = new System.Drawing.Size(53, 30);
            this.verubic_button.TabIndex = 22;
            this.verubic_button.Text = "Ver";
            this.verubic_button.UseVisualStyleBackColor = true;
            this.verubic_button.Click += new System.EventHandler(this.verubic_button_Click);
            // 
            // cantidadUbicaciones_textbox
            // 
            this.cantidadUbicaciones_textbox.Enabled = false;
            this.cantidadUbicaciones_textbox.Location = new System.Drawing.Point(496, 101);
            this.cantidadUbicaciones_textbox.Name = "cantidadUbicaciones_textbox";
            this.cantidadUbicaciones_textbox.Size = new System.Drawing.Size(43, 26);
            this.cantidadUbicaciones_textbox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ubicaciones agregadas:";
            // 
            // Grado_comboBox
            // 
            this.Grado_comboBox.FormattingEnabled = true;
            this.Grado_comboBox.Location = new System.Drawing.Point(194, 426);
            this.Grado_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Grado_comboBox.Name = "Grado_comboBox";
            this.Grado_comboBox.Size = new System.Drawing.Size(319, 28);
            this.Grado_comboBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 431);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Grado";
            // 
            // Rubro_comboBox
            // 
            this.Rubro_comboBox.FormattingEnabled = true;
            this.Rubro_comboBox.Location = new System.Drawing.Point(194, 295);
            this.Rubro_comboBox.Name = "Rubro_comboBox";
            this.Rubro_comboBox.Size = new System.Drawing.Size(200, 28);
            this.Rubro_comboBox.TabIndex = 17;
            this.Rubro_comboBox.SelectedIndexChanged += new System.EventHandler(this.Rubro_comboBox_SelectedIndexChanged);
            // 
            // Direccion_TextBox
            // 
            this.Direccion_TextBox.Location = new System.Drawing.Point(194, 360);
            this.Direccion_TextBox.Name = "Direccion_TextBox";
            this.Direccion_TextBox.Size = new System.Drawing.Size(319, 26);
            this.Direccion_TextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direccion Espectaculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rubro";
            // 
            // FechaEspec_dateTimePicker
            // 
            this.FechaEspec_dateTimePicker.Location = new System.Drawing.Point(194, 232);
            this.FechaEspec_dateTimePicker.Name = "FechaEspec_dateTimePicker";
            this.FechaEspec_dateTimePicker.Size = new System.Drawing.Size(319, 26);
            this.FechaEspec_dateTimePicker.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Espectaculo";
            // 
            // Fecha_publi_TextBox
            // 
            this.Fecha_publi_TextBox.Enabled = false;
            this.Fecha_publi_TextBox.Location = new System.Drawing.Point(194, 166);
            this.Fecha_publi_TextBox.Name = "Fecha_publi_TextBox";
            this.Fecha_publi_TextBox.Size = new System.Drawing.Size(114, 26);
            this.Fecha_publi_TextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Publicacion";
            // 
            // AgregarUbi_Button
            // 
            this.AgregarUbi_Button.Location = new System.Drawing.Point(194, 98);
            this.AgregarUbi_Button.Name = "AgregarUbi_Button";
            this.AgregarUbi_Button.Size = new System.Drawing.Size(92, 32);
            this.AgregarUbi_Button.TabIndex = 7;
            this.AgregarUbi_Button.Text = "Agregar";
            this.AgregarUbi_Button.UseVisualStyleBackColor = true;
            this.AgregarUbi_Button.Click += new System.EventHandler(this.AgregarUbi_Button_Click);
            // 
            // Generar_Button
            // 
            this.Generar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar_Button.Location = new System.Drawing.Point(708, 245);
            this.Generar_Button.Name = "Generar_Button";
            this.Generar_Button.Size = new System.Drawing.Size(112, 48);
            this.Generar_Button.TabIndex = 8;
            this.Generar_Button.Text = "Generar";
            this.Generar_Button.UseVisualStyleBackColor = true;
            this.Generar_Button.Click += new System.EventHandler(this.Generar_Button_Click);
            // 
            // Descartar_Button
            // 
            this.Descartar_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descartar_Button.Location = new System.Drawing.Point(708, 351);
            this.Descartar_Button.Name = "Descartar_Button";
            this.Descartar_Button.Size = new System.Drawing.Size(114, 48);
            this.Descartar_Button.TabIndex = 9;
            this.Descartar_Button.Text = "Descartar";
            this.Descartar_Button.UseVisualStyleBackColor = true;
            this.Descartar_Button.Click += new System.EventHandler(this.Descartar_Button_Click);
            // 
            // Volver_linkLabel
            // 
            this.Volver_linkLabel.AutoSize = true;
            this.Volver_linkLabel.Location = new System.Drawing.Point(8, 529);
            this.Volver_linkLabel.Name = "Volver_linkLabel";
            this.Volver_linkLabel.Size = new System.Drawing.Size(53, 20);
            this.Volver_linkLabel.TabIndex = 10;
            this.Volver_linkLabel.TabStop = true;
            this.Volver_linkLabel.Text = "Volver";
            this.Volver_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Volver_linkLabel_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Generar_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.Volver_linkLabel);
            this.Controls.Add(this.Descartar_Button);
            this.Controls.Add(this.Generar_Button);
            this.Controls.Add(this.Completar);
            this.Controls.Add(this.Estado);
            this.Name = "Generar_Publicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Publicacion";
            this.Load += new System.EventHandler(this.Generar_Publicacion_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Generar_Publicacion_MouseClick);
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            this.Completar.ResumeLayout(false);
            this.Completar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SigEstado_button;
        private System.Windows.Forms.GroupBox Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Estado_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Completar;
        private System.Windows.Forms.TextBox Direccion_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaEspec_dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fecha_publi_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarUbi_Button;
        private System.Windows.Forms.Button Generar_Button;
        private System.Windows.Forms.Button Descartar_Button;
        private System.Windows.Forms.LinkLabel Volver_linkLabel;
        private System.Windows.Forms.ComboBox Rubro_comboBox;
        private System.Windows.Forms.ComboBox Grado_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cantidadUbicaciones_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button verubic_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
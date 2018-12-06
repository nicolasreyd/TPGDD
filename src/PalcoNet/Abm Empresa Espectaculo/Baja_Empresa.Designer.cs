namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class Baja_Empresa
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.limpiarPantalla_button = new System.Windows.Forms.Button();
            this.busquedaCliente_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedaEmail_textBox = new System.Windows.Forms.TextBox();
            this.busquedaCuit_textBox = new System.Windows.Forms.TextBox();
            this.busquedaRazonSocial_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(73, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // limpiarPantalla_button
            // 
            this.limpiarPantalla_button.Location = new System.Drawing.Point(393, 348);
            this.limpiarPantalla_button.Name = "limpiarPantalla_button";
            this.limpiarPantalla_button.Size = new System.Drawing.Size(75, 23);
            this.limpiarPantalla_button.TabIndex = 55;
            this.limpiarPantalla_button.Text = "Limpiar";
            this.limpiarPantalla_button.UseVisualStyleBackColor = true;
            this.limpiarPantalla_button.Click += new System.EventHandler(this.limpiarPantalla_button_Click);
            // 
            // busquedaCliente_button
            // 
            this.busquedaCliente_button.Location = new System.Drawing.Point(499, 85);
            this.busquedaCliente_button.Name = "busquedaCliente_button";
            this.busquedaCliente_button.Size = new System.Drawing.Size(75, 23);
            this.busquedaCliente_button.TabIndex = 52;
            this.busquedaCliente_button.Text = "Buscar";
            this.busquedaCliente_button.UseVisualStyleBackColor = true;
            this.busquedaCliente_button.Click += new System.EventHandler(this.busquedaCliente_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "CUIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Razón Social";
            // 
            // busquedaEmail_textBox
            // 
            this.busquedaEmail_textBox.Location = new System.Drawing.Point(368, 43);
            this.busquedaEmail_textBox.Name = "busquedaEmail_textBox";
            this.busquedaEmail_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaEmail_textBox.TabIndex = 47;
            // 
            // busquedaCuit_textBox
            // 
            this.busquedaCuit_textBox.Location = new System.Drawing.Point(214, 43);
            this.busquedaCuit_textBox.Name = "busquedaCuit_textBox";
            this.busquedaCuit_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaCuit_textBox.TabIndex = 45;
            // 
            // busquedaRazonSocial_textBox
            // 
            this.busquedaRazonSocial_textBox.Location = new System.Drawing.Point(50, 43);
            this.busquedaRazonSocial_textBox.Name = "busquedaRazonSocial_textBox";
            this.busquedaRazonSocial_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaRazonSocial_textBox.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(50, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 218);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Modificar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Modificar";
            this.Eliminar.ToolTipText = "Modificar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 56;
            // 
            // Baja_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.limpiarPantalla_button);
            this.Controls.Add(this.busquedaCliente_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedaEmail_textBox);
            this.Controls.Add(this.busquedaCuit_textBox);
            this.Controls.Add(this.busquedaRazonSocial_textBox);
            this.Name = "Baja_Empresa";
            this.Text = "Baja de Empresa de Espectáculos";
            this.Load += new System.EventHandler(this.Baja_Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button limpiarPantalla_button;
        private System.Windows.Forms.Button busquedaCliente_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busquedaEmail_textBox;
        private System.Windows.Forms.TextBox busquedaCuit_textBox;
        private System.Windows.Forms.TextBox busquedaRazonSocial_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
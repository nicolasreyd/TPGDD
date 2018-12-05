namespace PalcoNet.Abm_Cliente
{
    partial class busquedaModificacion_Cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.busquedaCliente_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedaEmail_textBox = new System.Windows.Forms.TextBox();
            this.busquedaDNI_textBox = new System.Windows.Forms.TextBox();
            this.busquedaApellido_textBox = new System.Windows.Forms.TextBox();
            this.busquedaNombre_textBox = new System.Windows.Forms.TextBox();
            this.limpiarPantalla_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(41, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 218);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // busquedaCliente_button
            // 
            this.busquedaCliente_button.Location = new System.Drawing.Point(490, 89);
            this.busquedaCliente_button.Name = "busquedaCliente_button";
            this.busquedaCliente_button.Size = new System.Drawing.Size(75, 23);
            this.busquedaCliente_button.TabIndex = 17;
            this.busquedaCliente_button.Text = "Buscar";
            this.busquedaCliente_button.UseVisualStyleBackColor = true;
            this.busquedaCliente_button.Click += new System.EventHandler(this.busquedaCliente_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // busquedaEmail_textBox
            // 
            this.busquedaEmail_textBox.Location = new System.Drawing.Point(359, 47);
            this.busquedaEmail_textBox.Name = "busquedaEmail_textBox";
            this.busquedaEmail_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaEmail_textBox.TabIndex = 12;
            this.busquedaEmail_textBox.TextChanged += new System.EventHandler(this.busquedaEmail_textBox_TextChanged);
            // 
            // busquedaDNI_textBox
            // 
            this.busquedaDNI_textBox.Location = new System.Drawing.Point(253, 47);
            this.busquedaDNI_textBox.Name = "busquedaDNI_textBox";
            this.busquedaDNI_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaDNI_textBox.TabIndex = 11;
            this.busquedaDNI_textBox.TextChanged += new System.EventHandler(this.busquedaDNI_textBox_TextChanged);
            // 
            // busquedaApellido_textBox
            // 
            this.busquedaApellido_textBox.Location = new System.Drawing.Point(147, 47);
            this.busquedaApellido_textBox.Name = "busquedaApellido_textBox";
            this.busquedaApellido_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaApellido_textBox.TabIndex = 10;
            this.busquedaApellido_textBox.TextChanged += new System.EventHandler(this.busquedaApellido_textBox_TextChanged);
            // 
            // busquedaNombre_textBox
            // 
            this.busquedaNombre_textBox.Location = new System.Drawing.Point(41, 47);
            this.busquedaNombre_textBox.Name = "busquedaNombre_textBox";
            this.busquedaNombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaNombre_textBox.TabIndex = 9;
            this.busquedaNombre_textBox.TextChanged += new System.EventHandler(this.busquedaNombre_textBox_TextChanged);
            // 
            // limpiarPantalla_button
            // 
            this.limpiarPantalla_button.Location = new System.Drawing.Point(490, 398);
            this.limpiarPantalla_button.Name = "limpiarPantalla_button";
            this.limpiarPantalla_button.Size = new System.Drawing.Size(75, 23);
            this.limpiarPantalla_button.TabIndex = 18;
            this.limpiarPantalla_button.Text = "Limpiar";
            this.limpiarPantalla_button.UseVisualStyleBackColor = true;
            this.limpiarPantalla_button.Click += new System.EventHandler(this.limpiarPantalla_button_Click);
            // 
            // busquedaModificacion_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 433);
            this.Controls.Add(this.limpiarPantalla_button);
            this.Controls.Add(this.busquedaCliente_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedaEmail_textBox);
            this.Controls.Add(this.busquedaDNI_textBox);
            this.Controls.Add(this.busquedaApellido_textBox);
            this.Controls.Add(this.busquedaNombre_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "busquedaModificacion_Cliente";
            this.Text = "Modificacion Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button busquedaCliente_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busquedaEmail_textBox;
        private System.Windows.Forms.TextBox busquedaDNI_textBox;
        private System.Windows.Forms.TextBox busquedaApellido_textBox;
        private System.Windows.Forms.TextBox busquedaNombre_textBox;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button limpiarPantalla_button;


    }
}
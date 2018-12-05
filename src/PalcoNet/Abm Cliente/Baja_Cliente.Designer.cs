namespace PalcoNet.Abm_Cliente
{
    partial class Baja_Cliente
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
            this.busquedaNombre_textBox = new System.Windows.Forms.TextBox();
            this.busquedaApellido_textBox = new System.Windows.Forms.TextBox();
            this.busquedaDNI_textBox = new System.Windows.Forms.TextBox();
            this.busquedaEmail_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.busquedaCliente_button = new System.Windows.Forms.Button();
            this.darDeBaja_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.limpiarPantalla_button = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedaNombre_textBox
            // 
            this.busquedaNombre_textBox.Location = new System.Drawing.Point(32, 79);
            this.busquedaNombre_textBox.Name = "busquedaNombre_textBox";
            this.busquedaNombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaNombre_textBox.TabIndex = 0;
            this.busquedaNombre_textBox.TextChanged += new System.EventHandler(this.busquedaNombre_textBox_TextChanged);
            // 
            // busquedaApellido_textBox
            // 
            this.busquedaApellido_textBox.Location = new System.Drawing.Point(138, 79);
            this.busquedaApellido_textBox.Name = "busquedaApellido_textBox";
            this.busquedaApellido_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaApellido_textBox.TabIndex = 1;
            this.busquedaApellido_textBox.TextChanged += new System.EventHandler(this.busquedaApellido_textBox_TextChanged);
            // 
            // busquedaDNI_textBox
            // 
            this.busquedaDNI_textBox.Location = new System.Drawing.Point(244, 79);
            this.busquedaDNI_textBox.Name = "busquedaDNI_textBox";
            this.busquedaDNI_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaDNI_textBox.TabIndex = 2;
            this.busquedaDNI_textBox.TextChanged += new System.EventHandler(this.busquedaDNI_textBox_TextChanged);
            // 
            // busquedaEmail_textBox
            // 
            this.busquedaEmail_textBox.Location = new System.Drawing.Point(350, 79);
            this.busquedaEmail_textBox.Name = "busquedaEmail_textBox";
            this.busquedaEmail_textBox.Size = new System.Drawing.Size(100, 20);
            this.busquedaEmail_textBox.TabIndex = 3;
            this.busquedaEmail_textBox.TextChanged += new System.EventHandler(this.busquedaEmail_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // busquedaCliente_button
            // 
            this.busquedaCliente_button.Location = new System.Drawing.Point(481, 121);
            this.busquedaCliente_button.Name = "busquedaCliente_button";
            this.busquedaCliente_button.Size = new System.Drawing.Size(75, 23);
            this.busquedaCliente_button.TabIndex = 8;
            this.busquedaCliente_button.Text = "Buscar";
            this.busquedaCliente_button.UseVisualStyleBackColor = true;
            this.busquedaCliente_button.Click += new System.EventHandler(this.busquedaCliente_button_Click);
            // 
            // darDeBaja_button
            // 
            this.darDeBaja_button.Location = new System.Drawing.Point(481, 384);
            this.darDeBaja_button.Name = "darDeBaja_button";
            this.darDeBaja_button.Size = new System.Drawing.Size(75, 23);
            this.darDeBaja_button.TabIndex = 10;
            this.darDeBaja_button.Text = "Dar de baja";
            this.darDeBaja_button.UseVisualStyleBackColor = true;
            this.darDeBaja_button.Click += new System.EventHandler(this.darDeBaja_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 195);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // limpiarPantalla_button
            // 
            this.limpiarPantalla_button.Location = new System.Drawing.Point(375, 384);
            this.limpiarPantalla_button.Name = "limpiarPantalla_button";
            this.limpiarPantalla_button.Size = new System.Drawing.Size(75, 23);
            this.limpiarPantalla_button.TabIndex = 12;
            this.limpiarPantalla_button.Text = "Limpiar";
            this.limpiarPantalla_button.UseVisualStyleBackColor = true;
            this.limpiarPantalla_button.Click += new System.EventHandler(this.limpiarPantalla_button_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Baja_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 419);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.limpiarPantalla_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.darDeBaja_button);
            this.Controls.Add(this.busquedaCliente_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busquedaEmail_textBox);
            this.Controls.Add(this.busquedaDNI_textBox);
            this.Controls.Add(this.busquedaApellido_textBox);
            this.Controls.Add(this.busquedaNombre_textBox);
            this.Name = "Baja_Cliente";
            this.Text = "Baja_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox busquedaNombre_textBox;
        private System.Windows.Forms.TextBox busquedaApellido_textBox;
        private System.Windows.Forms.TextBox busquedaDNI_textBox;
        private System.Windows.Forms.TextBox busquedaEmail_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button busquedaCliente_button;
        private System.Windows.Forms.Button darDeBaja_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button limpiarPantalla_button;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
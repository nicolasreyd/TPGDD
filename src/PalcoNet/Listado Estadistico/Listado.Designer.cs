namespace PalcoNet.Listado_Estadistico
{
    partial class Listado
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
            this.trimestre_comboBox = new System.Windows.Forms.ComboBox();
            this.trimestre = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.Label();
            this.listar = new System.Windows.Forms.Button();
            this.anio_textBox = new System.Windows.Forms.TextBox();
            this.listado_comboBox = new System.Windows.Forms.ComboBox();
            this.grado = new System.Windows.Forms.Label();
            this.grado_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trimestre_comboBox
            // 
            this.trimestre_comboBox.FormattingEnabled = true;
            this.trimestre_comboBox.Location = new System.Drawing.Point(138, 68);
            this.trimestre_comboBox.Name = "trimestre_comboBox";
            this.trimestre_comboBox.Size = new System.Drawing.Size(121, 21);
            this.trimestre_comboBox.TabIndex = 1;
            // 
            // trimestre
            // 
            this.trimestre.AutoSize = true;
            this.trimestre.Location = new System.Drawing.Point(56, 76);
            this.trimestre.Name = "trimestre";
            this.trimestre.Size = new System.Drawing.Size(50, 13);
            this.trimestre.TabIndex = 3;
            this.trimestre.Text = "Trimestre";
            // 
            // anio
            // 
            this.anio.AutoSize = true;
            this.anio.Location = new System.Drawing.Point(56, 30);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(26, 13);
            this.anio.TabIndex = 5;
            this.anio.Text = "Año";
            this.anio.Click += new System.EventHandler(this.label3_Click);
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(758, 146);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(75, 23);
            this.listar.TabIndex = 6;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // anio_textBox
            // 
            this.anio_textBox.Location = new System.Drawing.Point(138, 23);
            this.anio_textBox.Name = "anio_textBox";
            this.anio_textBox.Size = new System.Drawing.Size(121, 20);
            this.anio_textBox.TabIndex = 7;
            // 
            // listado_comboBox
            // 
            this.listado_comboBox.FormattingEnabled = true;
            this.listado_comboBox.Location = new System.Drawing.Point(138, 120);
            this.listado_comboBox.Name = "listado_comboBox";
            this.listado_comboBox.Size = new System.Drawing.Size(121, 21);
            this.listado_comboBox.TabIndex = 8;
            this.listado_comboBox.SelectedIndexChanged += new System.EventHandler(this.listado_comboBox_SelectedIndexChanged);
            // 
            // grado
            // 
            this.grado.AutoSize = true;
            this.grado.Location = new System.Drawing.Point(333, 128);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(36, 13);
            this.grado.TabIndex = 10;
            this.grado.Text = "Grado";
            // 
            // grado_comboBox
            // 
            this.grado_comboBox.FormattingEnabled = true;
            this.grado_comboBox.Location = new System.Drawing.Point(395, 125);
            this.grado_comboBox.Name = "grado_comboBox";
            this.grado_comboBox.Size = new System.Drawing.Size(121, 21);
            this.grado_comboBox.TabIndex = 11;
            this.grado_comboBox.SelectedIndexChanged += new System.EventHandler(this.grado_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(56, 502);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 538);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grado_comboBox);
            this.Controls.Add(this.grado);
            this.Controls.Add(this.listado_comboBox);
            this.Controls.Add(this.anio_textBox);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.trimestre);
            this.Controls.Add(this.trimestre_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listado";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox trimestre_comboBox;
        private System.Windows.Forms.Label trimestre;
        private System.Windows.Forms.Label listado;
        private System.Windows.Forms.Label anio;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.TextBox anio_textBox;
        private System.Windows.Forms.ComboBox listado_comboBox;
        private System.Windows.Forms.Label grado;
        private System.Windows.Forms.ComboBox grado_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
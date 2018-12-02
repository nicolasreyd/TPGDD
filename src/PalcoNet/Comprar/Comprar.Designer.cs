namespace PalcoNet.Comprar
{
    partial class Comprar
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
            this.filtrar = new System.Windows.Forms.GroupBox();
            this.fechaDesde_textBox = new System.Windows.Forms.DateTimePicker();
            this.fechaHasta_textBox = new System.Windows.Forms.DateTimePicker();
            this.categoria_listBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion_textBox = new System.Windows.Forms.TextBox();
            this.compra_limpiar = new System.Windows.Forms.Button();
            this.compra_buscar = new System.Windows.Forms.Button();
            this.Comprar_Entrada = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.filtrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comprar_Entrada});
            this.dataGridView1.Location = new System.Drawing.Point(43, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filtrar
            // 
            this.filtrar.Controls.Add(this.fechaDesde_textBox);
            this.filtrar.Controls.Add(this.fechaHasta_textBox);
            this.filtrar.Controls.Add(this.categoria_listBox);
            this.filtrar.Controls.Add(this.label4);
            this.filtrar.Controls.Add(this.label3);
            this.filtrar.Controls.Add(this.label2);
            this.filtrar.Controls.Add(this.label1);
            this.filtrar.Controls.Add(this.descripcion_textBox);
            this.filtrar.Location = new System.Drawing.Point(43, 12);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(718, 182);
            this.filtrar.TabIndex = 1;
            this.filtrar.TabStop = false;
            this.filtrar.Text = "filtrar";
            this.filtrar.Enter += new System.EventHandler(this.filtrar_Enter);
            // 
            // fechaDesde_textBox
            // 
            this.fechaDesde_textBox.Location = new System.Drawing.Point(263, 119);
            this.fechaDesde_textBox.Name = "fechaDesde_textBox";
            this.fechaDesde_textBox.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde_textBox.TabIndex = 11;
            // 
            // fechaHasta_textBox
            // 
            this.fechaHasta_textBox.Location = new System.Drawing.Point(483, 119);
            this.fechaHasta_textBox.Name = "fechaHasta_textBox";
            this.fechaHasta_textBox.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta_textBox.TabIndex = 10;
            // 
            // categoria_listBox
            // 
            this.categoria_listBox.FormattingEnabled = true;
            this.categoria_listBox.Location = new System.Drawing.Point(10, 52);
            this.categoria_listBox.Name = "categoria_listBox";
            this.categoria_listBox.Size = new System.Drawing.Size(244, 124);
            this.categoria_listBox.TabIndex = 9;
            this.categoria_listBox.SelectedIndexChanged += new System.EventHandler(this.categoria_listBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categorias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descripcion_textBox
            // 
            this.descripcion_textBox.Location = new System.Drawing.Point(340, 36);
            this.descripcion_textBox.Name = "descripcion_textBox";
            this.descripcion_textBox.Size = new System.Drawing.Size(343, 20);
            this.descripcion_textBox.TabIndex = 1;
            this.descripcion_textBox.TextChanged += new System.EventHandler(this.descripcion_textBox_TextChanged);
            // 
            // compra_limpiar
            // 
            this.compra_limpiar.Location = new System.Drawing.Point(57, 200);
            this.compra_limpiar.Name = "compra_limpiar";
            this.compra_limpiar.Size = new System.Drawing.Size(75, 23);
            this.compra_limpiar.TabIndex = 2;
            this.compra_limpiar.Text = "Limpiar";
            this.compra_limpiar.UseVisualStyleBackColor = true;
            this.compra_limpiar.Click += new System.EventHandler(this.compra_limpiar_Click);
            // 
            // compra_buscar
            // 
            this.compra_buscar.Location = new System.Drawing.Point(613, 200);
            this.compra_buscar.Name = "compra_buscar";
            this.compra_buscar.Size = new System.Drawing.Size(75, 23);
            this.compra_buscar.TabIndex = 3;
            this.compra_buscar.Text = "Buscar";
            this.compra_buscar.UseVisualStyleBackColor = true;
            this.compra_buscar.Click += new System.EventHandler(this.compra_buscar_Click);
            // 
            // Comprar_Entrada
            // 
            this.Comprar_Entrada.HeaderText = "Comprar";
            this.Comprar_Entrada.Name = "Comprar_Entrada";
            this.Comprar_Entrada.UseColumnTextForButtonValue = true;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 561);
            this.Controls.Add(this.compra_buscar);
            this.Controls.Add(this.compra_limpiar);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.filtrar.ResumeLayout(false);
            this.filtrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox filtrar;
        private System.Windows.Forms.Button compra_limpiar;
        private System.Windows.Forms.Button compra_buscar;
        private System.Windows.Forms.TextBox descripcion_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox categoria_listBox;
        private System.Windows.Forms.DateTimePicker fechaDesde_textBox;
        private System.Windows.Forms.DateTimePicker fechaHasta_textBox;
        private System.Windows.Forms.DataGridViewButtonColumn Comprar_Entrada;
    }
}
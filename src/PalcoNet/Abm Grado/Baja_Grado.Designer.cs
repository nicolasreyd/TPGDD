namespace PalcoNet.Abm_Grado
{
	partial class Baja_Grado
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.prioridad = new System.Windows.Forms.Label();
			this.prioridad_textBox = new System.Windows.Forms.TextBox();
			this.limpiar_button = new System.Windows.Forms.Button();
			this.buscar_button = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.prioridad);
			this.groupBox1.Controls.Add(this.prioridad_textBox);
			this.groupBox1.Location = new System.Drawing.Point(69, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(354, 101);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// prioridad
			// 
			this.prioridad.AutoSize = true;
			this.prioridad.Location = new System.Drawing.Point(70, 58);
			this.prioridad.Name = "prioridad";
			this.prioridad.Size = new System.Drawing.Size(48, 13);
			this.prioridad.TabIndex = 1;
			this.prioridad.Text = "Prioridad";
			this.prioridad.Click += new System.EventHandler(this.label1_Click);
			// 
			// prioridad_textBox
			// 
			this.prioridad_textBox.Location = new System.Drawing.Point(180, 51);
			this.prioridad_textBox.Name = "prioridad_textBox";
			this.prioridad_textBox.Size = new System.Drawing.Size(100, 20);
			this.prioridad_textBox.TabIndex = 2;
			this.prioridad_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// limpiar_button
			// 
			this.limpiar_button.Location = new System.Drawing.Point(69, 163);
			this.limpiar_button.Name = "limpiar_button";
			this.limpiar_button.Size = new System.Drawing.Size(75, 23);
			this.limpiar_button.TabIndex = 3;
			this.limpiar_button.Text = "limpiar";
			this.limpiar_button.UseVisualStyleBackColor = true;
			this.limpiar_button.Click += new System.EventHandler(this.limpiar_button_Click);
			// 
			// buscar_button
			// 
			this.buscar_button.Location = new System.Drawing.Point(348, 163);
			this.buscar_button.Name = "buscar_button";
			this.buscar_button.Size = new System.Drawing.Size(75, 23);
			this.buscar_button.TabIndex = 4;
			this.buscar_button.Text = "Buscar";
			this.buscar_button.UseVisualStyleBackColor = true;
			this.buscar_button.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
			this.dataGridView1.Location = new System.Drawing.Point(69, 217);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(354, 150);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// Eliminar
			// 
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Eliminar.UseColumnTextForButtonValue = true;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(66, 405);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(36, 13);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "volver";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Baja_Grado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 465);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.limpiar_button);
			this.Controls.Add(this.buscar_button);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Baja_Grado";
			this.Text = "Baja Grado";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label prioridad;
		private System.Windows.Forms.TextBox prioridad_textBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buscar_button;
		private System.Windows.Forms.Button limpiar_button;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
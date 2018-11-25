namespace PalcoNet.Abm_Grado
{
	partial class Modificacion_Formulario
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
			this.prioridad_textBox = new System.Windows.Forms.TextBox();
			this.comision_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.prioridad_textBox);
			this.groupBox1.Controls.Add(this.comision_textBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(35, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 156);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Completar";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// prioridad_textBox
			// 
			this.prioridad_textBox.Location = new System.Drawing.Point(164, 44);
			this.prioridad_textBox.Name = "prioridad_textBox";
			this.prioridad_textBox.Size = new System.Drawing.Size(100, 20);
			this.prioridad_textBox.TabIndex = 3;
			this.prioridad_textBox.TextChanged += new System.EventHandler(this.prioridad_textBox_TextChanged);
			// 
			// comision_textBox
			// 
			this.comision_textBox.Location = new System.Drawing.Point(164, 105);
			this.comision_textBox.Name = "comision_textBox";
			this.comision_textBox.Size = new System.Drawing.Size(100, 20);
			this.comision_textBox.TabIndex = 2;
			this.comision_textBox.TextChanged += new System.EventHandler(this.comision_textBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Comision";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prioridad";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(292, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Guardar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(32, 232);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(36, 13);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "volver";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Modificacion_Formulario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 292);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Modificacion_Formulario";
			this.Text = "Modificar Grado";
			this.Load += new System.EventHandler(this.Modificacion_Formulario_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox prioridad_textBox;
		private System.Windows.Forms.TextBox comision_textBox;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
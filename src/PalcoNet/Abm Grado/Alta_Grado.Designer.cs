﻿namespace PalcoNet.Abm_Grado
{
	partial class Alta_Grado
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
			this.label1 = new System.Windows.Forms.Label();
			this.prioridad_textBox = new System.Windows.Forms.TextBox();
			this.comision_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Alta = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 0;
			// 
			// prioridad_textBox
			// 
			this.prioridad_textBox.Location = new System.Drawing.Point(160, 66);
			this.prioridad_textBox.Name = "prioridad_textBox";
			this.prioridad_textBox.Size = new System.Drawing.Size(100, 20);
			this.prioridad_textBox.TabIndex = 2;
			this.prioridad_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// comision_textBox
			// 
			this.comision_textBox.Location = new System.Drawing.Point(160, 136);
			this.comision_textBox.Name = "comision_textBox";
			this.comision_textBox.Size = new System.Drawing.Size(100, 20);
			this.comision_textBox.TabIndex = 3;
			this.comision_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Prioridad";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Comision";
			// 
			// Alta
			// 
			this.Alta.Location = new System.Drawing.Point(185, 222);
			this.Alta.Name = "Alta";
			this.Alta.Size = new System.Drawing.Size(75, 23);
			this.Alta.TabIndex = 6;
			this.Alta.Text = "Alta";
			this.Alta.UseVisualStyleBackColor = true;
			this.Alta.Click += new System.EventHandler(this.Alta_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(31, 232);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(36, 13);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "volver";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Alta_Grado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 316);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.Alta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comision_textBox);
			this.Controls.Add(this.prioridad_textBox);
			this.Controls.Add(this.label1);
			this.Name = "Alta_Grado";
			this.Text = "Alta Grado";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox prioridad_textBox;
		private System.Windows.Forms.TextBox comision_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Alta;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
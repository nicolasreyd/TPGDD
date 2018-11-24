namespace PalcoNet.Abm_Grado
{
	partial class ABMGrado
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
			this.GradoAlta_Button = new System.Windows.Forms.Button();
			this.GradoBaja_Button = new System.Windows.Forms.Button();
			this.GradoModificacion_Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GradoAlta_Button
			// 
			this.GradoAlta_Button.Location = new System.Drawing.Point(80, 53);
			this.GradoAlta_Button.Name = "GradoAlta_Button";
			this.GradoAlta_Button.Size = new System.Drawing.Size(75, 23);
			this.GradoAlta_Button.TabIndex = 0;
			this.GradoAlta_Button.Text = "Alta";
			this.GradoAlta_Button.UseVisualStyleBackColor = true;
			this.GradoAlta_Button.Click += new System.EventHandler(this.button1_Click);
			// 
			// GradoBaja_Button
			// 
			this.GradoBaja_Button.Location = new System.Drawing.Point(80, 109);
			this.GradoBaja_Button.Name = "GradoBaja_Button";
			this.GradoBaja_Button.Size = new System.Drawing.Size(75, 23);
			this.GradoBaja_Button.TabIndex = 1;
			this.GradoBaja_Button.Text = "Baja";
			this.GradoBaja_Button.UseVisualStyleBackColor = true;
			this.GradoBaja_Button.Click += new System.EventHandler(this.GradoBaja_Button_Click);
			// 
			// GradoModificacion_Button
			// 
			this.GradoModificacion_Button.Location = new System.Drawing.Point(80, 166);
			this.GradoModificacion_Button.Name = "GradoModificacion_Button";
			this.GradoModificacion_Button.Size = new System.Drawing.Size(75, 23);
			this.GradoModificacion_Button.TabIndex = 2;
			this.GradoModificacion_Button.Text = "Modificacion";
			this.GradoModificacion_Button.UseVisualStyleBackColor = true;
			this.GradoModificacion_Button.Click += new System.EventHandler(this.GradoModificacion_Button_Click);
			// 
			// ABMGrado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 259);
			this.Controls.Add(this.GradoModificacion_Button);
			this.Controls.Add(this.GradoBaja_Button);
			this.Controls.Add(this.GradoAlta_Button);
			this.Name = "ABMGrado";
			this.Text = "Grado Publicacion";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button GradoAlta_Button;
		private System.Windows.Forms.Button GradoBaja_Button;
		private System.Windows.Forms.Button GradoModificacion_Button;
	}
}
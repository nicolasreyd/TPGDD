namespace PalcoNet.Abm_Rol
{
    partial class ABMRol
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
            this.button1 = new System.Windows.Forms.Button();
            this.RolBaja_Button = new System.Windows.Forms.Button();
            this.RolAlta_Button = new System.Windows.Forms.Button();
            this.volver_menuprincipal = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RolBaja_Button);
            this.groupBox1.Controls.Add(this.RolAlta_Button);
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion Accion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RolBaja_Button
            // 
            this.RolBaja_Button.Location = new System.Drawing.Point(86, 128);
            this.RolBaja_Button.Name = "RolBaja_Button";
            this.RolBaja_Button.Size = new System.Drawing.Size(126, 37);
            this.RolBaja_Button.TabIndex = 1;
            this.RolBaja_Button.Text = "Baja";
            this.RolBaja_Button.UseVisualStyleBackColor = true;
            this.RolBaja_Button.Click += new System.EventHandler(this.RolBaja_Button_Click);
            // 
            // RolAlta_Button
            // 
            this.RolAlta_Button.Location = new System.Drawing.Point(86, 55);
            this.RolAlta_Button.Name = "RolAlta_Button";
            this.RolAlta_Button.Size = new System.Drawing.Size(126, 35);
            this.RolAlta_Button.TabIndex = 0;
            this.RolAlta_Button.Text = "Alta";
            this.RolAlta_Button.UseVisualStyleBackColor = true;
            this.RolAlta_Button.Click += new System.EventHandler(this.RolAlta_Button_Click);
            // 
            // volver_menuprincipal
            // 
            this.volver_menuprincipal.AutoSize = true;
            this.volver_menuprincipal.Location = new System.Drawing.Point(36, 317);
            this.volver_menuprincipal.Name = "volver_menuprincipal";
            this.volver_menuprincipal.Size = new System.Drawing.Size(53, 20);
            this.volver_menuprincipal.TabIndex = 1;
            this.volver_menuprincipal.TabStop = true;
            this.volver_menuprincipal.Text = "Volver";
            this.volver_menuprincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.volver_menuprincipal_LinkClicked);
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.Controls.Add(this.volver_menuprincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.ABMRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RolBaja_Button;
        private System.Windows.Forms.Button RolAlta_Button;
        private System.Windows.Forms.LinkLabel volver_menuprincipal;
    }
}
namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class ABMEmpresa
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
            this.BajaCliente_button = new System.Windows.Forms.Button();
            this.ModificacionCliente_button = new System.Windows.Forms.Button();
            this.ClienteAlta_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BajaCliente_button);
            this.groupBox1.Controls.Add(this.ModificacionCliente_button);
            this.groupBox1.Controls.Add(this.ClienteAlta_Button);
            this.groupBox1.Location = new System.Drawing.Point(43, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // BajaCliente_button
            // 
            this.BajaCliente_button.Location = new System.Drawing.Point(57, 124);
            this.BajaCliente_button.Name = "BajaCliente_button";
            this.BajaCliente_button.Size = new System.Drawing.Size(75, 23);
            this.BajaCliente_button.TabIndex = 2;
            this.BajaCliente_button.Text = "Baja";
            this.BajaCliente_button.UseVisualStyleBackColor = true;
            this.BajaCliente_button.Click += new System.EventHandler(this.BajaCliente_button_Click);
            // 
            // ModificacionCliente_button
            // 
            this.ModificacionCliente_button.Location = new System.Drawing.Point(57, 80);
            this.ModificacionCliente_button.Name = "ModificacionCliente_button";
            this.ModificacionCliente_button.Size = new System.Drawing.Size(75, 23);
            this.ModificacionCliente_button.TabIndex = 1;
            this.ModificacionCliente_button.Text = "Modificación";
            this.ModificacionCliente_button.UseVisualStyleBackColor = true;
            this.ModificacionCliente_button.Click += new System.EventHandler(this.ModificacionCliente_button_Click);
            // 
            // ClienteAlta_Button
            // 
            this.ClienteAlta_Button.Location = new System.Drawing.Point(57, 36);
            this.ClienteAlta_Button.Name = "ClienteAlta_Button";
            this.ClienteAlta_Button.Size = new System.Drawing.Size(75, 23);
            this.ClienteAlta_Button.TabIndex = 0;
            this.ClienteAlta_Button.Text = "Alta";
            this.ClienteAlta_Button.UseVisualStyleBackColor = true;
            this.ClienteAlta_Button.Click += new System.EventHandler(this.ClienteAlta_Button_Click);
            // 
            // ABMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "ABMEmpresa";
            this.Text = "ABMEmpresa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BajaCliente_button;
        private System.Windows.Forms.Button ModificacionCliente_button;
        private System.Windows.Forms.Button ClienteAlta_Button;
    }
}
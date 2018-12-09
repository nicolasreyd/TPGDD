namespace PalcoNet.Registro_de_Usuario
{
    partial class Registro_Usuario
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.rol_comboBox = new System.Windows.Forms.ComboBox();
            this.aceptar_button = new System.Windows.Forms.Button();
            this.volver_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.rol_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repetirPassword_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(145, 81);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(100, 20);
            this.username_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(145, 107);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 1;
            // 
            // rol_comboBox
            // 
            this.rol_comboBox.FormattingEnabled = true;
            this.rol_comboBox.Items.AddRange(new object[] {
            "Cliente",
            "Empresa"});
            this.rol_comboBox.Location = new System.Drawing.Point(145, 159);
            this.rol_comboBox.Name = "rol_comboBox";
            this.rol_comboBox.Size = new System.Drawing.Size(121, 21);
            this.rol_comboBox.TabIndex = 2;
            // 
            // aceptar_button
            // 
            this.aceptar_button.Location = new System.Drawing.Point(197, 227);
            this.aceptar_button.Name = "aceptar_button";
            this.aceptar_button.Size = new System.Drawing.Size(75, 23);
            this.aceptar_button.TabIndex = 3;
            this.aceptar_button.Text = "Aceptar";
            this.aceptar_button.UseVisualStyleBackColor = true;
            this.aceptar_button.Click += new System.EventHandler(this.aceptar_button_Click);
            // 
            // volver_button
            // 
            this.volver_button.Location = new System.Drawing.Point(12, 227);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(92, 23);
            this.volver_button.TabIndex = 4;
            this.volver_button.Text = "Volver a login";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(43, 84);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(96, 13);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Nombre de usuario";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(78, 114);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(61, 13);
            this.pass_label.TabIndex = 6;
            this.pass_label.Text = "Contraseña";
            // 
            // rol_label
            // 
            this.rol_label.AutoSize = true;
            this.rol_label.Location = new System.Drawing.Point(116, 167);
            this.rol_label.Name = "rol_label";
            this.rol_label.Size = new System.Drawing.Size(23, 13);
            this.rol_label.TabIndex = 7;
            this.rol_label.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Repetir contraseña";
            // 
            // repetirPassword_textBox
            // 
            this.repetirPassword_textBox.Location = new System.Drawing.Point(145, 133);
            this.repetirPassword_textBox.Name = "repetirPassword_textBox";
            this.repetirPassword_textBox.PasswordChar = '*';
            this.repetirPassword_textBox.Size = new System.Drawing.Size(100, 20);
            this.repetirPassword_textBox.TabIndex = 8;
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repetirPassword_textBox);
            this.Controls.Add(this.rol_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.aceptar_button);
            this.Controls.Add(this.rol_comboBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Name = "Registro_Usuario";
            this.Text = "Registro de nuevo usuario";
            this.Load += new System.EventHandler(this.Registro_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.ComboBox rol_comboBox;
        private System.Windows.Forms.Button aceptar_button;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label rol_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repetirPassword_textBox;
    }
}
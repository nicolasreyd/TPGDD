namespace PalcoNet.Login
{
    partial class Reset_Password
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
            this.cambiarPass_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.repetirPass_textBox = new System.Windows.Forms.TextBox();
            this.ingresarPass_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cambiarPass_button
            // 
            this.cambiarPass_button.Location = new System.Drawing.Point(171, 180);
            this.cambiarPass_button.Name = "cambiarPass_button";
            this.cambiarPass_button.Size = new System.Drawing.Size(75, 23);
            this.cambiarPass_button.TabIndex = 16;
            this.cambiarPass_button.Text = "Aceptar";
            this.cambiarPass_button.UseVisualStyleBackColor = true;
            this.cambiarPass_button.Click += new System.EventHandler(this.cambiarPass_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Repetir contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingresar contraseña";
            // 
            // repetirPass_textBox
            // 
            this.repetirPass_textBox.Location = new System.Drawing.Point(146, 106);
            this.repetirPass_textBox.Name = "repetirPass_textBox";
            this.repetirPass_textBox.PasswordChar = '*';
            this.repetirPass_textBox.Size = new System.Drawing.Size(100, 20);
            this.repetirPass_textBox.TabIndex = 13;
            // 
            // ingresarPass_textBox
            // 
            this.ingresarPass_textBox.Location = new System.Drawing.Point(146, 59);
            this.ingresarPass_textBox.Name = "ingresarPass_textBox";
            this.ingresarPass_textBox.PasswordChar = '*';
            this.ingresarPass_textBox.Size = new System.Drawing.Size(100, 20);
            this.ingresarPass_textBox.TabIndex = 12;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cambiarPass_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repetirPass_textBox);
            this.Controls.Add(this.ingresarPass_textBox);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambiarPass_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repetirPass_textBox;
        private System.Windows.Forms.TextBox ingresarPass_textBox;
    }
}
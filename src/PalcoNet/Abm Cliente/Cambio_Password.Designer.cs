namespace PalcoNet.Abm_Cliente
{
    partial class Cambio_Password
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
            this.ingresarPass_textBox = new System.Windows.Forms.TextBox();
            this.repetirPass_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cambiarPass_button = new System.Windows.Forms.Button();
            this.volver_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ingresarPass_textBox
            // 
            this.ingresarPass_textBox.Location = new System.Drawing.Point(135, 95);
            this.ingresarPass_textBox.Name = "ingresarPass_textBox";
            this.ingresarPass_textBox.PasswordChar = '*';
            this.ingresarPass_textBox.Size = new System.Drawing.Size(100, 20);
            this.ingresarPass_textBox.TabIndex = 0;
            // 
            // repetirPass_textBox
            // 
            this.repetirPass_textBox.Location = new System.Drawing.Point(135, 142);
            this.repetirPass_textBox.Name = "repetirPass_textBox";
            this.repetirPass_textBox.PasswordChar = '*';
            this.repetirPass_textBox.Size = new System.Drawing.Size(100, 20);
            this.repetirPass_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repetir contraseña";
            // 
            // cambiarPass_button
            // 
            this.cambiarPass_button.Location = new System.Drawing.Point(160, 216);
            this.cambiarPass_button.Name = "cambiarPass_button";
            this.cambiarPass_button.Size = new System.Drawing.Size(75, 23);
            this.cambiarPass_button.TabIndex = 4;
            this.cambiarPass_button.Text = "Aceptar";
            this.cambiarPass_button.UseVisualStyleBackColor = true;
            this.cambiarPass_button.Click += new System.EventHandler(this.cambiarPass_button_Click);
            // 
            // volver_linkLabel
            // 
            this.volver_linkLabel.AutoSize = true;
            this.volver_linkLabel.Location = new System.Drawing.Point(42, 226);
            this.volver_linkLabel.Name = "volver_linkLabel";
            this.volver_linkLabel.Size = new System.Drawing.Size(37, 13);
            this.volver_linkLabel.TabIndex = 5;
            this.volver_linkLabel.TabStop = true;
            this.volver_linkLabel.Text = "Volver";
            this.volver_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.volver_linkLabel_LinkClicked);
            // 
            // Cambio_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.volver_linkLabel);
            this.Controls.Add(this.cambiarPass_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repetirPass_textBox);
            this.Controls.Add(this.ingresarPass_textBox);
            this.Name = "Cambio_Password";
            this.Text = "Cambio_Password";
            this.Load += new System.EventHandler(this.Cambio_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ingresarPass_textBox;
        private System.Windows.Forms.TextBox repetirPass_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cambiarPass_button;
        private System.Windows.Forms.LinkLabel volver_linkLabel;
    }
}
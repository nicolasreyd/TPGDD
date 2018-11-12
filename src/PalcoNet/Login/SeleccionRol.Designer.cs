namespace PalcoNet.Login
{
    partial class SeleccionRol
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
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonOKRoles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Location = new System.Drawing.Point(191, 60);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(184, 28);
            this.comboRoles.TabIndex = 0;
            this.comboRoles.SelectedIndexChanged += new System.EventHandler(this.comboRoles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles Disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonOKRoles
            // 
            this.ButtonOKRoles.Location = new System.Drawing.Point(55, 147);
            this.ButtonOKRoles.Name = "ButtonOKRoles";
            this.ButtonOKRoles.Size = new System.Drawing.Size(92, 35);
            this.ButtonOKRoles.TabIndex = 2;
            this.ButtonOKRoles.Text = "OK";
            this.ButtonOKRoles.UseVisualStyleBackColor = true;
            this.ButtonOKRoles.Click += new System.EventHandler(this.ButtonOKRoles_Click);
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 234);
            this.Controls.Add(this.ButtonOKRoles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRoles);
            this.Name = "SeleccionRol";
            this.Text = "SeleccionRol";
            this.Load += new System.EventHandler(this.SeleccionRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonOKRoles;
    }
}
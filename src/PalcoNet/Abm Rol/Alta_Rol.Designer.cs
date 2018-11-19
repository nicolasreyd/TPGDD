namespace PalcoNet.Abm_Rol
{
    partial class Alta_Rol
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
            this.Funcionalidades_label = new System.Windows.Forms.Label();
            this.nombreRol_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpiar_Button = new System.Windows.Forms.Button();
            this.Alta_Button = new System.Windows.Forms.Button();
            this.volver_ambRol = new System.Windows.Forms.LinkLabel();
            this.funcionalidades_checklist = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.funcionalidades_checklist);
            this.groupBox1.Controls.Add(this.Funcionalidades_label);
            this.groupBox1.Controls.Add(this.nombreRol_Textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completar";
            // 
            // Funcionalidades_label
            // 
            this.Funcionalidades_label.AutoSize = true;
            this.Funcionalidades_label.Location = new System.Drawing.Point(34, 137);
            this.Funcionalidades_label.Name = "Funcionalidades_label";
            this.Funcionalidades_label.Size = new System.Drawing.Size(125, 20);
            this.Funcionalidades_label.TabIndex = 2;
            this.Funcionalidades_label.Text = "Funcionalidades";
            // 
            // nombreRol_Textbox
            // 
            this.nombreRol_Textbox.Location = new System.Drawing.Point(202, 56);
            this.nombreRol_Textbox.Name = "nombreRol_Textbox";
            this.nombreRol_Textbox.Size = new System.Drawing.Size(222, 26);
            this.nombreRol_Textbox.TabIndex = 1;
            this.nombreRol_Textbox.TextChanged += new System.EventHandler(this.nomreRol_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Rol";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Limpiar_Button
            // 
            this.Limpiar_Button.Location = new System.Drawing.Point(250, 432);
            this.Limpiar_Button.Name = "Limpiar_Button";
            this.Limpiar_Button.Size = new System.Drawing.Size(106, 37);
            this.Limpiar_Button.TabIndex = 1;
            this.Limpiar_Button.Text = "Limpiar";
            this.Limpiar_Button.UseVisualStyleBackColor = true;
            // 
            // Alta_Button
            // 
            this.Alta_Button.Location = new System.Drawing.Point(432, 432);
            this.Alta_Button.Name = "Alta_Button";
            this.Alta_Button.Size = new System.Drawing.Size(107, 37);
            this.Alta_Button.TabIndex = 2;
            this.Alta_Button.Text = "Alta";
            this.Alta_Button.UseVisualStyleBackColor = true;
            this.Alta_Button.Click += new System.EventHandler(this.Alta_Button_Click);
            // 
            // volver_ambRol
            // 
            this.volver_ambRol.AutoSize = true;
            this.volver_ambRol.Location = new System.Drawing.Point(48, 448);
            this.volver_ambRol.Name = "volver_ambRol";
            this.volver_ambRol.Size = new System.Drawing.Size(53, 20);
            this.volver_ambRol.TabIndex = 3;
            this.volver_ambRol.TabStop = true;
            this.volver_ambRol.Text = "Volver";
            this.volver_ambRol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.volver_ambRol_LinkClicked);
            // 
            // funcionalidades_checklist
            // 
            this.funcionalidades_checklist.FormattingEnabled = true;
            this.funcionalidades_checklist.Location = new System.Drawing.Point(202, 137);
            this.funcionalidades_checklist.Name = "funcionalidades_checklist";
            this.funcionalidades_checklist.Size = new System.Drawing.Size(222, 214);
            this.funcionalidades_checklist.TabIndex = 3;
            // 
            // Alta_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 492);
            this.Controls.Add(this.volver_ambRol);
            this.Controls.Add(this.Alta_Button);
            this.Controls.Add(this.Limpiar_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alta_Rol";
            this.Text = "Alta de Rol";
            this.Load += new System.EventHandler(this.Alta_Rol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreRol_Textbox;
        private System.Windows.Forms.Label Funcionalidades_label;
        private System.Windows.Forms.Button Limpiar_Button;
        private System.Windows.Forms.Button Alta_Button;
        private System.Windows.Forms.LinkLabel volver_ambRol;
        private System.Windows.Forms.CheckedListBox funcionalidades_checklist;
    }
}
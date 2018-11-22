namespace PalcoNet.Abm_Rol
{
    partial class Modificacion_Rol
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_Textbox = new System.Windows.Forms.TextBox();
            this.Limpiar_Button = new System.Windows.Forms.Button();
            this.Buscar_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre_Textbox);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Rol";
            // 
            // nombre_Textbox
            // 
            this.nombre_Textbox.Location = new System.Drawing.Point(89, 31);
            this.nombre_Textbox.Name = "nombre_Textbox";
            this.nombre_Textbox.Size = new System.Drawing.Size(100, 20);
            this.nombre_Textbox.TabIndex = 0;
            // 
            // Limpiar_Button
            // 
            this.Limpiar_Button.Location = new System.Drawing.Point(25, 118);
            this.Limpiar_Button.Name = "Limpiar_Button";
            this.Limpiar_Button.Size = new System.Drawing.Size(75, 23);
            this.Limpiar_Button.TabIndex = 1;
            this.Limpiar_Button.Text = "Limpiar";
            this.Limpiar_Button.UseVisualStyleBackColor = true;
            this.Limpiar_Button.Click += new System.EventHandler(this.Limpiar_Button_Click);
            // 
            // Buscar_Button
            // 
            this.Buscar_Button.Location = new System.Drawing.Point(194, 118);
            this.Buscar_Button.Name = "Buscar_Button";
            this.Buscar_Button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_Button.TabIndex = 2;
            this.Buscar_Button.Text = "Buscar";
            this.Buscar_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 148);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modificacion_Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar_Button);
            this.Controls.Add(this.Limpiar_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificacion_Rol";
            this.Text = "Modificacion_Rol";
            this.Load += new System.EventHandler(this.Modificacion_Rol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_Textbox;
        private System.Windows.Forms.Button Limpiar_Button;
        private System.Windows.Forms.Button Buscar_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class Generar_Rendiciones
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Todas_checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rendir_Button = new System.Windows.Forms.Button();
            this.Limpiar_button1 = new System.Windows.Forms.Button();
            this.Cantidad_textBox1 = new System.Windows.Forms.TextBox();
            this.Empresa_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rendidas_textBox1 = new System.Windows.Forms.TextBox();
            this.Ver_button1 = new System.Windows.Forms.Button();
            this.Volver_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Todas_checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Rendir_Button);
            this.groupBox1.Controls.Add(this.Limpiar_button1);
            this.groupBox1.Controls.Add(this.Cantidad_textBox1);
            this.groupBox1.Controls.Add(this.Empresa_comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Completar";
            // 
            // Todas_checkBox1
            // 
            this.Todas_checkBox1.AutoSize = true;
            this.Todas_checkBox1.Location = new System.Drawing.Point(316, 106);
            this.Todas_checkBox1.Name = "Todas_checkBox1";
            this.Todas_checkBox1.Size = new System.Drawing.Size(15, 14);
            this.Todas_checkBox1.TabIndex = 7;
            this.Todas_checkBox1.UseVisualStyleBackColor = true;
            this.Todas_checkBox1.CheckedChanged += new System.EventHandler(this.Todas_checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Todas";
            // 
            // Rendir_Button
            // 
            this.Rendir_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendir_Button.Location = new System.Drawing.Point(327, 144);
            this.Rendir_Button.Name = "Rendir_Button";
            this.Rendir_Button.Size = new System.Drawing.Size(103, 37);
            this.Rendir_Button.TabIndex = 5;
            this.Rendir_Button.Text = "Rendir";
            this.Rendir_Button.UseVisualStyleBackColor = true;
            this.Rendir_Button.Click += new System.EventHandler(this.Rendir_Button_Click);
            // 
            // Limpiar_button1
            // 
            this.Limpiar_button1.Location = new System.Drawing.Point(31, 154);
            this.Limpiar_button1.Name = "Limpiar_button1";
            this.Limpiar_button1.Size = new System.Drawing.Size(79, 27);
            this.Limpiar_button1.TabIndex = 4;
            this.Limpiar_button1.Text = "Limpiar";
            this.Limpiar_button1.UseVisualStyleBackColor = true;
            this.Limpiar_button1.Click += new System.EventHandler(this.Limpiar_button1_Click);
            // 
            // Cantidad_textBox1
            // 
            this.Cantidad_textBox1.Location = new System.Drawing.Point(174, 100);
            this.Cantidad_textBox1.Name = "Cantidad_textBox1";
            this.Cantidad_textBox1.Size = new System.Drawing.Size(60, 20);
            this.Cantidad_textBox1.TabIndex = 3;
            // 
            // Empresa_comboBox1
            // 
            this.Empresa_comboBox1.FormattingEnabled = true;
            this.Empresa_comboBox1.Location = new System.Drawing.Point(174, 41);
            this.Empresa_comboBox1.Name = "Empresa_comboBox1";
            this.Empresa_comboBox1.Size = new System.Drawing.Size(157, 21);
            this.Empresa_comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Compras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(115, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Se rindieron";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "compras";
            this.label5.Visible = false;
            // 
            // rendidas_textBox1
            // 
            this.rendidas_textBox1.Enabled = false;
            this.rendidas_textBox1.Location = new System.Drawing.Point(184, 251);
            this.rendidas_textBox1.Name = "rendidas_textBox1";
            this.rendidas_textBox1.Size = new System.Drawing.Size(41, 20);
            this.rendidas_textBox1.TabIndex = 10;
            this.rendidas_textBox1.Visible = false;
            // 
            // Ver_button1
            // 
            this.Ver_button1.Location = new System.Drawing.Point(299, 249);
            this.Ver_button1.Name = "Ver_button1";
            this.Ver_button1.Size = new System.Drawing.Size(58, 23);
            this.Ver_button1.TabIndex = 11;
            this.Ver_button1.Text = "Ver";
            this.Ver_button1.UseVisualStyleBackColor = true;
            // 
            // Volver_linkLabel1
            // 
            this.Volver_linkLabel1.AutoSize = true;
            this.Volver_linkLabel1.Location = new System.Drawing.Point(24, 283);
            this.Volver_linkLabel1.Name = "Volver_linkLabel1";
            this.Volver_linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.Volver_linkLabel1.TabIndex = 12;
            this.Volver_linkLabel1.TabStop = true;
            this.Volver_linkLabel1.Text = "Volver";
            this.Volver_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Volver_linkLabel1_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Generar_Rendiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.Controls.Add(this.Volver_linkLabel1);
            this.Controls.Add(this.Ver_button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rendidas_textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "Generar_Rendiciones";
            this.Text = "Rendiciones";
            this.Load += new System.EventHandler(this.Generar_Rendiciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Todas_checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Rendir_Button;
        private System.Windows.Forms.TextBox Cantidad_textBox1;
        private System.Windows.Forms.ComboBox Empresa_comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar_button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rendidas_textBox1;
        private System.Windows.Forms.Button Ver_button1;
        private System.Windows.Forms.LinkLabel Volver_linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
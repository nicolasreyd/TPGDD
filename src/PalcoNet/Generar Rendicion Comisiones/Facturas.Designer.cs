namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class Facturas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_totalPaginas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Pagina = new System.Windows.Forms.Label();
            this.btn_Sig = new System.Windows.Forms.Button();
            this.btn_Previo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(42, 431);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_totalPaginas
            // 
            this.lbl_totalPaginas.AutoSize = true;
            this.lbl_totalPaginas.Location = new System.Drawing.Point(614, 415);
            this.lbl_totalPaginas.Name = "lbl_totalPaginas";
            this.lbl_totalPaginas.Size = new System.Drawing.Size(18, 20);
            this.lbl_totalPaginas.TabIndex = 2;
            this.lbl_totalPaginas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // lbl_Pagina
            // 
            this.lbl_Pagina.AutoSize = true;
            this.lbl_Pagina.Location = new System.Drawing.Point(517, 414);
            this.lbl_Pagina.Name = "lbl_Pagina";
            this.lbl_Pagina.Size = new System.Drawing.Size(18, 20);
            this.lbl_Pagina.TabIndex = 4;
            this.lbl_Pagina.Text = "0";
            // 
            // btn_Sig
            // 
            this.btn_Sig.Location = new System.Drawing.Point(676, 411);
            this.btn_Sig.Name = "btn_Sig";
            this.btn_Sig.Size = new System.Drawing.Size(83, 40);
            this.btn_Sig.TabIndex = 5;
            this.btn_Sig.Text = "sig";
            this.btn_Sig.UseVisualStyleBackColor = true;
            this.btn_Sig.Click += new System.EventHandler(this.btn_Sig_Click);
            // 
            // btn_Previo
            // 
            this.btn_Previo.Location = new System.Drawing.Point(413, 411);
            this.btn_Previo.Name = "btn_Previo";
            this.btn_Previo.Size = new System.Drawing.Size(77, 40);
            this.btn_Previo.TabIndex = 6;
            this.btn_Previo.Text = "ant";
            this.btn_Previo.UseVisualStyleBackColor = true;
            this.btn_Previo.Click += new System.EventHandler(this.btn_Previo_Click);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 482);
            this.Controls.Add(this.btn_Previo);
            this.Controls.Add(this.btn_Sig);
            this.Controls.Add(this.lbl_Pagina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_totalPaginas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_totalPaginas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Pagina;
        private System.Windows.Forms.Button btn_Sig;
        private System.Windows.Forms.Button btn_Previo;
    }
}
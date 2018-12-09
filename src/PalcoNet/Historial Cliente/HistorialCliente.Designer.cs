namespace PalcoNet.Historial_Cliente
{
    partial class HistorialCliente
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
            this.btn_Sig = new System.Windows.Forms.Button();
            this.btn_Previo = new System.Windows.Forms.Button();
            this.lbl_Pagina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_totalPaginas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Sig
            // 
            this.btn_Sig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sig.Location = new System.Drawing.Point(632, 319);
            this.btn_Sig.Name = "btn_Sig";
            this.btn_Sig.Size = new System.Drawing.Size(131, 37);
            this.btn_Sig.TabIndex = 1;
            this.btn_Sig.Text = "Siguiente";
            this.btn_Sig.UseVisualStyleBackColor = true;
            this.btn_Sig.Click += new System.EventHandler(this.btn_Sig_Click);
            // 
            // btn_Previo
            // 
            this.btn_Previo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Previo.Location = new System.Drawing.Point(12, 316);
            this.btn_Previo.Name = "btn_Previo";
            this.btn_Previo.Size = new System.Drawing.Size(137, 42);
            this.btn_Previo.TabIndex = 2;
            this.btn_Previo.Text = "Atras";
            this.btn_Previo.UseVisualStyleBackColor = true;
            this.btn_Previo.Click += new System.EventHandler(this.btn_Previo_Click);
            // 
            // lbl_Pagina
            // 
            this.lbl_Pagina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pagina.AutoSize = true;
            this.lbl_Pagina.Location = new System.Drawing.Point(340, 331);
            this.lbl_Pagina.Name = "lbl_Pagina";
            this.lbl_Pagina.Size = new System.Drawing.Size(13, 13);
            this.lbl_Pagina.TabIndex = 3;
            this.lbl_Pagina.Tag = "";
            this.lbl_Pagina.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // lbl_totalPaginas
            // 
            this.lbl_totalPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalPaginas.AutoSize = true;
            this.lbl_totalPaginas.Location = new System.Drawing.Point(422, 331);
            this.lbl_totalPaginas.Name = "lbl_totalPaginas";
            this.lbl_totalPaginas.Size = new System.Drawing.Size(13, 13);
            this.lbl_totalPaginas.TabIndex = 5;
            this.lbl_totalPaginas.Text = "0";
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 370);
            this.Controls.Add(this.lbl_totalPaginas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Pagina);
            this.Controls.Add(this.btn_Previo);
            this.Controls.Add(this.btn_Sig);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistorialCliente";
            this.Text = "Historial de Cliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sig;
        private System.Windows.Forms.Button btn_Previo;
        private System.Windows.Forms.Label lbl_Pagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_totalPaginas;
    }
}
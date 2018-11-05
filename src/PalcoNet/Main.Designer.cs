namespace PalcoNet
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.iralogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iralogin
            // 
            this.iralogin.Location = new System.Drawing.Point(81, 94);
            this.iralogin.Name = "iralogin";
            this.iralogin.Size = new System.Drawing.Size(75, 23);
            this.iralogin.TabIndex = 0;
            this.iralogin.Text = "Ir al login";
            this.iralogin.UseVisualStyleBackColor = true;
            this.iralogin.Click += new System.EventHandler(this.iralogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.iralogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iralogin;
    }
}


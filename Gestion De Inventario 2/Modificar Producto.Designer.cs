namespace Gestion_De_Inventario_2
{
    partial class Modificar_Producto
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
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.txtDescripcionM = new System.Windows.Forms.TextBox();
            this.txtStockM = new System.Windows.Forms.TextBox();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.btnMostrarFormulario = new System.Windows.Forms.Button();
            this.cmbCategoriaM = new System.Windows.Forms.ComboBox();
            this.lblCodigoM = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblPrecioM = new System.Windows.Forms.Label();
            this.lblCategoriaM = new System.Windows.Forms.Label();
            this.lblStockM = new System.Windows.Forms.Label();
            this.lblDescripcionM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNombreM.Location = new System.Drawing.Point(62, 113);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(100, 20);
            this.txtNombreM.TabIndex = 1;
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCodigoM.Location = new System.Drawing.Point(62, 40);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.Size = new System.Drawing.Size(169, 20);
            this.txtCodigoM.TabIndex = 2;
            // 
            // txtDescripcionM
            // 
            this.txtDescripcionM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDescripcionM.Location = new System.Drawing.Point(62, 257);
            this.txtDescripcionM.Name = "txtDescripcionM";
            this.txtDescripcionM.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionM.TabIndex = 9;
            // 
            // txtStockM
            // 
            this.txtStockM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStockM.Location = new System.Drawing.Point(286, 186);
            this.txtStockM.Name = "txtStockM";
            this.txtStockM.Size = new System.Drawing.Size(100, 20);
            this.txtStockM.TabIndex = 10;
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrecioM.Location = new System.Drawing.Point(286, 113);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioM.TabIndex = 11;
            // 
            // btnMostrarFormulario
            // 
            this.btnMostrarFormulario.Location = new System.Drawing.Point(117, 327);
            this.btnMostrarFormulario.Name = "btnMostrarFormulario";
            this.btnMostrarFormulario.Size = new System.Drawing.Size(224, 68);
            this.btnMostrarFormulario.TabIndex = 12;
            this.btnMostrarFormulario.Text = "Modificar";
            this.btnMostrarFormulario.UseVisualStyleBackColor = true;
            this.btnMostrarFormulario.Click += new System.EventHandler(this.btnMostrarFormulario_Click);
            // 
            // cmbCategoriaM
            // 
            this.cmbCategoriaM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbCategoriaM.FormattingEnabled = true;
            this.cmbCategoriaM.Location = new System.Drawing.Point(62, 185);
            this.cmbCategoriaM.Name = "cmbCategoriaM";
            this.cmbCategoriaM.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoriaM.TabIndex = 13;
            // 
            // lblCodigoM
            // 
            this.lblCodigoM.AutoSize = true;
            this.lblCodigoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoM.Location = new System.Drawing.Point(59, 24);
            this.lblCodigoM.Name = "lblCodigoM";
            this.lblCodigoM.Size = new System.Drawing.Size(55, 13);
            this.lblCodigoM.TabIndex = 14;
            this.lblCodigoM.Text = "CODIGO";
            this.lblCodigoM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(59, 136);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(44, 13);
            this.lblNombreM.TabIndex = 15;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblPrecioM
            // 
            this.lblPrecioM.AutoSize = true;
            this.lblPrecioM.Location = new System.Drawing.Point(283, 136);
            this.lblPrecioM.Name = "lblPrecioM";
            this.lblPrecioM.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioM.TabIndex = 16;
            this.lblPrecioM.Text = "Precio";
            // 
            // lblCategoriaM
            // 
            this.lblCategoriaM.AutoSize = true;
            this.lblCategoriaM.Location = new System.Drawing.Point(59, 209);
            this.lblCategoriaM.Name = "lblCategoriaM";
            this.lblCategoriaM.Size = new System.Drawing.Size(54, 13);
            this.lblCategoriaM.TabIndex = 17;
            this.lblCategoriaM.Text = "Categoría";
            // 
            // lblStockM
            // 
            this.lblStockM.AutoSize = true;
            this.lblStockM.Location = new System.Drawing.Point(283, 209);
            this.lblStockM.Name = "lblStockM";
            this.lblStockM.Size = new System.Drawing.Size(35, 13);
            this.lblStockM.TabIndex = 18;
            this.lblStockM.Text = "Stock";
            // 
            // lblDescripcionM
            // 
            this.lblDescripcionM.AutoSize = true;
            this.lblDescripcionM.Location = new System.Drawing.Point(59, 280);
            this.lblDescripcionM.Name = "lblDescripcionM";
            this.lblDescripcionM.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionM.TabIndex = 19;
            this.lblDescripcionM.Text = "Descripción";
            // 
            // Modificar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.lblDescripcionM);
            this.Controls.Add(this.lblStockM);
            this.Controls.Add(this.lblCategoriaM);
            this.Controls.Add(this.lblPrecioM);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.lblCodigoM);
            this.Controls.Add(this.cmbCategoriaM);
            this.Controls.Add(this.btnMostrarFormulario);
            this.Controls.Add(this.txtPrecioM);
            this.Controls.Add(this.txtStockM);
            this.Controls.Add(this.txtDescripcionM);
            this.Controls.Add(this.txtCodigoM);
            this.Controls.Add(this.txtNombreM);
            this.Name = "Modificar_Producto";
            this.Text = "Modificar_Producto";
            this.Load += new System.EventHandler(this.Modificar_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.TextBox txtStockM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.Button btnMostrarFormulario;
        private System.Windows.Forms.ComboBox cmbCategoriaM;
        private System.Windows.Forms.Label lblCodigoM;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblPrecioM;
        private System.Windows.Forms.Label lblCategoriaM;
        private System.Windows.Forms.Label lblStockM;
        private System.Windows.Forms.Label lblDescripcionM;
    }
}
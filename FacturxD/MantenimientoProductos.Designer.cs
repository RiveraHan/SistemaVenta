namespace FacturxD
{
    partial class MantenimientoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPro = new MiLibreria.ErrorTxtBox();
            this.txtNomPro = new MiLibreria.ErrorTxtBox();
            this.txtPrecio = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 21);
            this.button1.Size = new System.Drawing.Size(114, 20);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 78);
            this.button2.Size = new System.Drawing.Size(114, 20);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 134);
            this.button3.Size = new System.Drawing.Size(114, 20);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 181);
            this.button4.Size = new System.Drawing.Size(114, 20);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 240);
            this.btnSalir.Size = new System.Drawing.Size(114, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID producto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(153, 47);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(152, 20);
            this.txtIdPro.TabIndex = 14;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(153, 112);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(152, 20);
            this.txtNomPro.TabIndex = 15;
            this.txtNomPro.Validar = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(153, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(152, 20);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Validar = true;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 355);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoProductos";
            this.Text = "MantenimientoProductos";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtNomPro, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MiLibreria.ErrorTxtBox txtIdPro;
        private MiLibreria.ErrorTxtBox txtNomPro;
        private MiLibreria.ErrorTxtBox txtPrecio;
    }
}
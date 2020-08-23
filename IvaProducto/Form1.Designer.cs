namespace IvaProducto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo del IVA de un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el precio del producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(558, 99);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(156, 39);
            this.txtprecio.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 110);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular Iva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(98, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor IVA";
            this.label3.Visible = false;
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbliva.Location = new System.Drawing.Point(377, 202);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(99, 32);
            this.lbliva.TabIndex = 5;
            this.lbliva.Text = "label4";
            this.lbliva.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(98, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor por pagar";
            this.label5.Visible = false;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblvalor.Location = new System.Drawing.Point(377, 253);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(99, 32);
            this.lblvalor.TabIndex = 7;
            this.lblvalor.Text = "label6";
            this.lblvalor.Visible = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(825, 227);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(275, 110);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "Limpiar campo";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1035);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btnlimpiar;
    }
}


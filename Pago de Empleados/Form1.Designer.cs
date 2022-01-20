namespace Pago_de_Empleados
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEmpleados = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtCostoHoras = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontoNeto = new System.Windows.Forms.Label();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.lblMontoBruto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Pago de empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo de Horas";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(151, 215);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(413, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEmpleados
            // 
            this.txtEmpleados.Location = new System.Drawing.Point(165, 92);
            this.txtEmpleados.Name = "txtEmpleados";
            this.txtEmpleados.Size = new System.Drawing.Size(213, 20);
            this.txtEmpleados.TabIndex = 7;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(165, 154);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(213, 20);
            this.txtHoras.TabIndex = 8;
            // 
            // txtCostoHoras
            // 
            this.txtCostoHoras.Location = new System.Drawing.Point(522, 157);
            this.txtCostoHoras.Name = "txtCostoHoras";
            this.txtCostoHoras.Size = new System.Drawing.Size(147, 20);
            this.txtCostoHoras.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoBruto);
            this.groupBox1.Controls.Add(this.lblMontoDescuento);
            this.groupBox1.Controls.Add(this.lblMontoNeto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(87, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadro de Resumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Bruto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto Neto";
            // 
            // lblMontoNeto
            // 
            this.lblMontoNeto.AutoSize = true;
            this.lblMontoNeto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoNeto.Location = new System.Drawing.Point(407, 79);
            this.lblMontoNeto.Name = "lblMontoNeto";
            this.lblMontoNeto.Size = new System.Drawing.Size(103, 19);
            this.lblMontoNeto.TabIndex = 7;
            this.lblMontoNeto.Text = "lblMontoNeto";
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDescuento.Location = new System.Drawing.Point(191, 79);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(139, 19);
            this.lblMontoDescuento.TabIndex = 11;
            this.lblMontoDescuento.Text = "lblMontoDescuento";
            // 
            // lblMontoBruto
            // 
            this.lblMontoBruto.AutoSize = true;
            this.lblMontoBruto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoBruto.Location = new System.Drawing.Point(26, 79);
            this.lblMontoBruto.Name = "lblMontoBruto";
            this.lblMontoBruto.Size = new System.Drawing.Size(107, 19);
            this.lblMontoBruto.TabIndex = 12;
            this.lblMontoBruto.Text = "lblMontoBruto";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCostoHoras);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtEmpleados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtEmpleados;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtCostoHoras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMontoNeto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMontoBruto;
        private System.Windows.Forms.Label lblMontoDescuento;
        private System.Windows.Forms.Button btnSalir;
    }
}


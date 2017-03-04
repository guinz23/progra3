namespace WindowsFormsApplication1
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
            this.txtvalorUno = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtValorDos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbresta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.Calcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalorUno
            // 
            this.txtvalorUno.Location = new System.Drawing.Point(38, 98);
            this.txtvalorUno.Name = "txtvalorUno";
            this.txtvalorUno.Size = new System.Drawing.Size(100, 20);
            this.txtvalorUno.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(335, 98);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // txtValorDos
            // 
            this.txtValorDos.Location = new System.Drawing.Point(192, 102);
            this.txtValorDos.Name = "txtValorDos";
            this.txtValorDos.Size = new System.Drawing.Size(100, 20);
            this.txtValorDos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMultiplicacion);
            this.groupBox1.Controls.Add(this.rbresta);
            this.groupBox1.Controls.Add(this.rbSuma);
            this.groupBox1.Location = new System.Drawing.Point(82, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(6, 28);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(50, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbresta
            // 
            this.rbresta.AutoSize = true;
            this.rbresta.Location = new System.Drawing.Point(86, 28);
            this.rbresta.Name = "rbresta";
            this.rbresta.Size = new System.Drawing.Size(53, 17);
            this.rbresta.TabIndex = 1;
            this.rbresta.TabStop = true;
            this.rbresta.Text = "Resta";
            this.rbresta.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(177, 28);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.rbMultiplicacion.TabIndex = 2;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Text = "multiplicacion";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(382, 214);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(91, 36);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 364);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorDos);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtvalorUno);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalorUno;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtValorDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbresta;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.Button Calcular;
    }
}

